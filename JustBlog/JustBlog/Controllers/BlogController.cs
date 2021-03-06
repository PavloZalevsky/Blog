﻿using JustBlog.Core;
using JustBlog.Models;
using System.Web.Mvc;

namespace JustBlog.Controllers
{
    public class BlogController
    {
        private readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public ViewResult Posts(int p = 1)
        {
            // pick latest 10 posts
            var posts = _blogRepository.Posts(p - 1, 10);

            var totalPosts = _blogRepository.TotalPosts();

            var listViewModel = new  ListViewModel
            {
                
                Posts = posts,
                TotalPosts = totalPosts
            };

            ViewBag.Title = "Latest Posts";

            return View("List", listViewModel);
        }
    }
}