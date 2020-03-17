﻿namespace MyCalisthenicApp.Web.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using MyCalisthenicApp.Services.Contracts;

    public class ProductsController : BaseController
    {
        private readonly IProductsService productsService;
        private readonly ICommentsService commentsService;
        private readonly IImagesService imagesService;

        public ProductsController(IProductsService productsService, ICommentsService commentsService, IImagesService imagesService)
        {
            this.productsService = productsService;
            this.commentsService = commentsService;
            this.imagesService = imagesService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await this.productsService.GetAllProductsAsync();

            return this.View(products);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("Error404");
            }

            var product = await this.productsService.GetProductsByIdAsync(id);

            var comments = await this.commentsService.GetCommentsByProductIdAsync(product.Id);
            product.Comments = comments;

            var images = await this.imagesService.GetImagesByProductIdAsync(id);
            product.Images = images;

            return this.View(product);
        }

        public async Task<IActionResult> Filter(string name)
        {
            var products = await this.productsService.GetProductsByCategoryAsync(name);

            return this.View("Index", products);
        }

        public async Task<IActionResult> Sort(string sort)
        {
            var products = await this.productsService.GetProductsAndSortAsync(sort);

            return this.View("Index", products);
        }

        [Authorize]
        public async Task<IActionResult> Rate(string id)
        {
            await this.productsService.AddRatingAsync(id);

            return this.RedirectToAction(nameof(this.Details), new { id = id });
        }
    }
}
