﻿namespace MyCalisthenicApp.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MyCalisthenicApp.ViewModels.Posts;

    public interface IPostsService
    {
        Task<IEnumerable<PopularPostsHomeViewModel>> GetPopularPostsAsync();

        Task<PostDetailsViewModel> GetPostDetailsByIdAsync(string id);

        Task<IEnumerable<PostDetailsSidebarViewModel>> GetFourLatestPostsAsync();

        Task<IEnumerable<PostDetailsViewModel>> GetAllPostsAsync();

        Task<IEnumerable<PostDetailsViewModel>> SortPostsByCategoryAsync(string sort);

        Task AddRatingAsync(string id);

        bool GetPostById(string id);

        Task<IEnumerable<PostDetailsViewModel>> GetPostsBySearchAsync(PostSearchViewModel inputModel);
    }
}
