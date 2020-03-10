﻿namespace MyCalisthenicApp.Services.Contracts
{
    using System.Threading.Tasks;

    using MyCalisthenicApp.ViewModels.Categories;

    public interface ICategoriesService
    {
        Task<CategoryViewModel> GetCategoryByProgramId(string id);
    }
}
