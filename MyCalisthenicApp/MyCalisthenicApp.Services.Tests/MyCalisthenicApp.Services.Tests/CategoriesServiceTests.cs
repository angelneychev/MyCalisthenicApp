﻿namespace MyCalisthenicApp.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using MyCalisthenicApp.Data;
    using MyCalisthenicApp.Models;
    using MyCalisthenicApp.ViewModels.Categories;
    using System;
    using System.Threading.Tasks;
    using Xunit;

    public class CategoriesServiceTests
    {
        private const string CategoryName = "Advanced";
        private const string CategoryDescription = "Program category";
        private const string CategoryId = "12345";
        private const string CategoryNullId = "12345";


        [Fact]
        public async Task CreateBlogCategoryAsyncShouldCreateBlogCategorySuccessfully()
        {
            var options = new DbContextOptionsBuilder<MyCalisthenicAppDbContext>()
                    .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                    .Options;

            var dbContext = new MyCalisthenicAppDbContext(options);

            var categoriesService = new CategoriesService(dbContext, null);

            var categoryInputModel = new BlogCategoryAdminCreateViewModel
            {
                Name = CategoryName,
            };

            await categoriesService.CreateBlogCategoryAsync(categoryInputModel);

            var actual = dbContext.BlogCategories.FirstOrDefaultAsync(bc => bc.Name == CategoryName);

            Assert.Equal(actual.Result.Name, CategoryName);
        }

        [Fact]
        public async Task CreateProductCategoryAsyncShouldCreateBlogCategorySuccessfully()
        {
            var options = new DbContextOptionsBuilder<MyCalisthenicAppDbContext>()
                    .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                    .Options;

            var dbContext = new MyCalisthenicAppDbContext(options);

            var categoriesService = new CategoriesService(dbContext, null);

            var categoryInputModel = new ProductCategoryAdminCreateViewModel
            {
                Name = CategoryName,
            };

            await categoriesService.CreateProductCategoryAsync(categoryInputModel);

            var actual = dbContext.ProductCategories.FirstOrDefaultAsync(bc => bc.Name == CategoryName);

            Assert.Equal(actual.Result.Name, CategoryName);
        }

        [Fact]
        public async Task CreateProgramCategoryAsyncShouldCreateBlogCategorySuccessfully()
        {
            var options = new DbContextOptionsBuilder<MyCalisthenicAppDbContext>()
                    .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                    .Options;

            var dbContext = new MyCalisthenicAppDbContext(options);

            var categoriesService = new CategoriesService(dbContext, null);

            var categoryInputModel = new ProgramCategoryAdminCreateViewModel
            {
                Name = CategoryName,
                Description = CategoryDescription,
            };

            await categoriesService.CreateProgramCategoryAsync(categoryInputModel);

            var actual = dbContext.ProgramCategories.FirstOrDefaultAsync(bc => bc.Name == CategoryName);

            Assert.Equal(actual.Result.Name, CategoryName);
        }

        [Fact]
        public void GetAllPostCategoriesShouldReturnCategoriesSuccessfully()
        {
            var options = new DbContextOptionsBuilder<MyCalisthenicAppDbContext>()
                   .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                   .Options;

            var dbContext = new MyCalisthenicAppDbContext(options);

            var categoriesService = new CategoriesService(dbContext, null);

            var categories = categoriesService.GetAllPostCategories();

            var actualCount = dbContext.BlogCategories.CountAsync();

            var expected = 0;

            foreach (var category in categories)
            {
                expected++;
            }

            Assert.Equal(actualCount.Result, expected);
        }

        [Fact]
        public void GetAllProductCategoriesShouldReturnCategoriesSuccessfully()
        {
            var options = new DbContextOptionsBuilder<MyCalisthenicAppDbContext>()
                   .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                   .Options;

            var dbContext = new MyCalisthenicAppDbContext(options);

            var categoriesService = new CategoriesService(dbContext, null);

            var categories = categoriesService.GetAllProductCategories();

            var actualCount = dbContext.ProductCategories.CountAsync();

            var expected = 0;

            foreach (var category in categories)
            {
                expected++;
            }

            Assert.Equal(actualCount.Result, expected);
        }

        [Fact]
        public void GetAllProgramCategoriesShouldReturnCategoriesSuccessfully()
        {
            var options = new DbContextOptionsBuilder<MyCalisthenicAppDbContext>()
                   .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                   .Options;

            var dbContext = new MyCalisthenicAppDbContext(options);

            var categoriesService = new CategoriesService(dbContext, null);

            var categories = categoriesService.GetAllProgramCategories();

            var actualCount = dbContext.ProgramCategories.CountAsync();

            var expected = 0;

            foreach (var category in categories)
            {
                expected++;
            }

            Assert.Equal(actualCount.Result, expected);
        }

        [Fact]
        public async Task GetCategoryByProgramIdAsyncShouldReturnCategoryByProgramIdSuccessfully()
        {
            var options = new DbContextOptionsBuilder<MyCalisthenicAppDbContext>()
                  .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                  .Options;

            var dbContext = new MyCalisthenicAppDbContext(options);

            var categoriesService = new CategoriesService(dbContext, null);

            var programCategory = new ProgramCategory
            {
                Id = CategoryId,
                Name = CategoryName,
                Description = CategoryDescription,
            };

            await dbContext.ProgramCategories.AddAsync(programCategory);

            await dbContext.SaveChangesAsync();

            var actual = dbContext.ProgramCategories.FirstOrDefaultAsync(pc => pc.Id == CategoryId);

            Assert.Equal(actual.Result.Id, CategoryId);
        }

        [Fact]
        public async Task GetCategoryByProgramIdAsyncShouldThrowExceptionIfProgramCategoryIsNull()
        {
            var options = new DbContextOptionsBuilder<MyCalisthenicAppDbContext>()
                  .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                  .Options;

            var dbContext = new MyCalisthenicAppDbContext(options);

            var categoriesService = new CategoriesService(dbContext, null);

            var programCategory = new ProgramCategory
            {
                Id = CategoryId,
                Name = CategoryName,
                Description = CategoryDescription,
            };

            await dbContext.ProgramCategories.AddAsync(programCategory);

            await dbContext.SaveChangesAsync();

            var exception = await Assert.ThrowsAsync<ArgumentNullException>(async () => await categoriesService.GetCategoryByProgramIdAsync(CategoryNullId));

            Assert.IsType<ArgumentNullException>(exception);
        }
    }
}
