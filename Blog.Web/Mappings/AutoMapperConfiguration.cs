using AutoMapper;
using Blog.Model.Models;
using Blog.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}