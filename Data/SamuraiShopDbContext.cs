using Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SamuraiShopDbContext : DbContext
    {
        public SamuraiShopDbContext() : base("SamuraiShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false; //khi load 1 bảng cha thì ko tự động inclulde thêm bảng con nữa
        }

        //tiếp theo là phần khai báo các danh sách các bảng
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisistorStatistic> VisistorStatistics { get; set; }

        /// <summary>
        /// Phương thức này chạy khi khởi tạo framework enitity
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
