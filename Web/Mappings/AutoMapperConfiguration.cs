using AutoMapper;
using Model.Models;
using Web.Models;

namespace Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Footer, FooterViewModel>();
            Mapper.CreateMap<Menu, MenuViewModel>();
            Mapper.CreateMap<MenuGroup, MenuGroupViewModel>();
            Mapper.CreateMap<Order, OrderViewModel>();
            Mapper.CreateMap<OrderDetail, OrderDetailViewModel>();
            Mapper.CreateMap<Page, PageViewModel>();
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<PostTag, PostTagViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();
            Mapper.CreateMap<ProductTag, ProductTagViewModel>();
            Mapper.CreateMap<Slide, SlideViewModel>();
            Mapper.CreateMap<SupportOnline, SupportOnlineViewModel>();
            Mapper.CreateMap<SystemConfig, SystemConfigViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
            Mapper.CreateMap<VisistorStatistic, VisistorStatisticViewModel>();
        }
    }
}