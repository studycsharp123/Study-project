using Study.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Data
{
    public class StudyDbContext : DbContext
    {
        //truyen collection string vao base
        //nhan data tu webconfig cua webapi, muc dich de cau hinh cho appconfig trong data layer
        public StudyDbContext() : base("StudyConnection")
        {
            //su dung de cau hinh access den data base trong SQL server
            this.Configuration.LazyLoadingEnabled = false;
            //khi load bang cha thi se khong tu dong include them bang con
        }
        //khai bao danh sach table
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

        public DbSet<SystemSetting> SystemSettings { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VistorStatistics { get; set; }

        //ghi de method DbContext

        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}
