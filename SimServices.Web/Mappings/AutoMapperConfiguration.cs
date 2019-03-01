using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimServices.Model.Models;
using SimServices.Web.Models;
using AutoMapper;

namespace SimServices.Web.Mappings
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