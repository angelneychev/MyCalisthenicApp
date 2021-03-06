﻿namespace MyCalisthenicApp.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MyCalisthenicApp.Services.Common;
    using MyCalisthenicApp.Services.Contracts;

    public class ProgramsController : BaseController
    {
        private readonly IProgramsService programsService;
        private readonly ICategoriesService categoriesService;
        private readonly IExercisesService exercisesService;
        private readonly ICommentsService commentsService;

        public ProgramsController(
            IProgramsService programsService,
            ICategoriesService categoriesService,
            IExercisesService exercisesService,
            ICommentsService commentsService)
        {
            this.programsService = programsService;
            this.categoriesService = categoriesService;
            this.exercisesService = exercisesService;
            this.commentsService = commentsService;
        }

        public async Task<IActionResult> Index()
        {
            var programs = await this.programsService.GetAllProgramsAsync();

            return this.View(programs);
        }

        [Authorize]
        public async Task<IActionResult> Details(string id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("Error404");
            }

            var programDetails = await this.programsService
                .GetProgramDetailsByIdAsync(id);

            var category = await this.categoriesService.GetCategoryByProgramIdAsync(id);
            programDetails.Category = category;

            var exercises = await this.exercisesService.GetExercisesByCategoryIdAsync(category.Id);
            category.Exercises = exercises;

            var comments = await this.commentsService.GetCommentsByProgramIdAsync(id);
            programDetails.Comments = comments;

            return this.View(programDetails);
        }

        public async Task<IActionResult> FilterByBeginner()
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("Error404");
            }

            var programs = await this.programsService.GetProgramsByCategoryAsync(ServicesConstants.BeginnerCategoryName);

            return this.View("Index", programs);
        }

        public async Task<IActionResult> FilterByIntermediate()
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("Error404");
            }

            var programs = await this.programsService.GetProgramsByCategoryAsync(ServicesConstants.IntermediateCategoryName);

            return this.View("Index", programs);
        }

        public async Task<IActionResult> Filter(string type)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("Error404");
            }

            var programs = await this.programsService.GetProgramsByCategoryAsync(type);

            return this.View("Index", programs);
        }

        [Authorize]
        public async Task<IActionResult> Rate(string id)
        {
            await this.programsService.AddRatingAsync(id);

            return this.RedirectToAction(nameof(this.Details), new { id = id });
        }
    }
}
