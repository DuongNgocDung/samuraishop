using AutoMapper;
using Model.Models;
using Web.Models;

namespace Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            //var configPost = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<Post, PostViewModel>();
            //});
            //configPost.CreateMapper();

            //var configPostCategory = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<PostCategory, PostCategoryViewModel>();
            //});
            //configPost.CreateMapper();

            //var configTag = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<Tag, TagViewModel>();
            //});
            //configPost.CreateMapper();

            //var configPostTag = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<PostTag, PostTagViewModel>();
            //});
            //configPost.CreateMapper();
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
            Mapper.CreateMap<PostTag, PostTagViewModel>();
        }
    }
}