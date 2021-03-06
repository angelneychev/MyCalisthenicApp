﻿namespace MyCalisthenicApp.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MyCalisthenicApp.ViewModels.Exercises;

    public interface IExercisesService
    {
        Task<IEnumerable<ExercisesViewModel>> GetExercisesByCategoryIdAsync(string id);

        Task<IList<ExercisesAdminViewModel>> GetAllExercisesForAdminAsync();

        Task<ExerciseAdminEditViewModel> GetExerciseByIdAsync(string id);

        Task EditExerciseAsync(ExerciseAdminEditViewModel inputModel);

        Task CreateExerciseAsync(ExerciseAdminCreateViewModel inputModel);
    }
}
