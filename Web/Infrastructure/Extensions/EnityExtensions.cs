using Model.Models;
using Web.Models;

namespace Web.Infrastructure.Extensions
{
    /// <summary>
    /// tức là các entity model sẽ có thêm cái phương thức này khi mà nó đc using cái namespace này vô
    /// Khi mà map từ database qua ViewModel thì có thể map 1-1 được, còn ngược lại thì ko nên do ở view model còn thêm
    /// nhìu phương thức/ thuộc tính nhằm phục vụ cho mục đích hiển thị
    /// </summary>
    /// <param name=""></param>
    public static class EnityExtensions
    {
        /// <summary>
        /// update value from FooterViewModel to Footer
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdateFooter(this Footer dModel, FooterViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.Content = vModel.Content;
        }

        /// <summary>
        /// update value from MenuViewModel to Menu
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdateMenu(this Menu dModel, MenuViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.Name = vModel.Name;
            dModel.URL = vModel.URL;
            dModel.DisplayOrder = vModel.DisplayOrder;
            dModel.GroupID = vModel.GroupID;
            dModel.Target = vModel.Target;
            dModel.Status = vModel.Status;
        }

        /// <summary>
        /// update value from MenuGroupViewModel to MenuGroup
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdateMenuGroup(this MenuGroup dModel, MenuGroupViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.Name = vModel.Name;
        }

        /// <summary>
        /// update value from OrderViewModel to Order
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdateOrder(this Order dModel, OrderViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.CustomerName = vModel.CustomerName;
            dModel.CustomerAddress = vModel.CustomerAddress;
            dModel.CustomerEmail = vModel.CustomerEmail;
            dModel.CustomerMobile = vModel.CustomerMobile;
            dModel.CustomerMessage = vModel.CustomerMessage;
            dModel.PaymentMethod = vModel.PaymentMethod;
            dModel.PaymentStatus = vModel.PaymentStatus;
            dModel.Status = vModel.Status;
            dModel.CreateDate = vModel.CreateDate;
            dModel.CreateBy = vModel.CreateBy;
        }

        /// <summary>
        /// update value from OrderDetailViewModel to OrderDetail
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdateOrderDetail(this OrderDetail dModel, OrderDetailViewModel vModel)
        {
            dModel.ProductID = vModel.ProductID;
            dModel.OrderID = vModel.OrderID;
            dModel.Quantity = vModel.Quantity;
        }

        /// <summary>
        /// update value from PageViewModel to Page
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdatePage(this Page dModel, PageViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.Name = vModel.Name;
            dModel.Alias = vModel.Alias;
            dModel.Content = vModel.Content;
            dModel.MetaKeyword = vModel.MetaKeyword;
            dModel.MetaDescription = vModel.MetaDescription;
            dModel.Status = vModel.Status;
            dModel.CreateDate = vModel.CreateDate;
            dModel.CreateBy = vModel.CreateBy;
            dModel.UpdateDate = vModel.UpdateDate;
            dModel.UpdateBy = vModel.UpdateBy;
        }

        /// <summary>
        /// update value from PostViewModel to Post
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdatePost(this Post dModel, PostViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.Name = vModel.Name;
            dModel.Alias = vModel.Alias;
            dModel.CategoryID = vModel.CategoryID;
            dModel.Image = vModel.Image;
            dModel.Description = vModel.Description;
            dModel.Content = vModel.Content;
            dModel.HomeFlag = vModel.HomeFlag;
            dModel.HotFlag = vModel.HotFlag;
            dModel.ViewCount = vModel.ViewCount;
            dModel.MetaKeyword = vModel.MetaKeyword;
            dModel.MetaDescription = vModel.MetaDescription;
            dModel.Status = vModel.Status;
            dModel.CreateDate = vModel.CreateDate;
            dModel.CreateBy = vModel.CreateBy;
            dModel.UpdateDate = vModel.UpdateDate;
            dModel.UpdateBy = vModel.UpdateBy;
        }

        /// <summary>
        /// update value from PostCategoryViewModel to PostCategory
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdatePostCategory(this PostCategory dModel, PostCategoryViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.Name = vModel.Name;
            dModel.Alias = vModel.Alias;
            dModel.Description = vModel.Description;
            dModel.ParentID = vModel.ParentID;
            dModel.DisplayOrder = vModel.DisplayOrder;
            dModel.Image = vModel.Image;
            dModel.HomeFlag = vModel.HomeFlag;
            dModel.MetaKeyword = vModel.MetaKeyword;
            dModel.MetaDescription = vModel.MetaDescription;
            dModel.Status = vModel.Status;
            dModel.CreateDate = vModel.CreateDate;
            dModel.CreateBy = vModel.CreateBy;
            dModel.UpdateDate = vModel.UpdateDate;
            dModel.UpdateBy = vModel.UpdateBy;
        }

        /// <summary>
        /// update value from PostTagViewModel to PostTag
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdatePostTag(this PostTag dModel, PostTagViewModel vModel)
        {
            dModel.PostID = vModel.PostID;
            dModel.TagID = vModel.TagID;
        }

        /// <summary>
        /// update value from ProductViewModel to Product
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdateProduct(this Product dModel, ProductViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.Name = vModel.Name;
            dModel.Alias = vModel.Alias;
            dModel.CategoryID = vModel.CategoryID;
            dModel.Image = vModel.Image;
            dModel.MoreImages = vModel.MoreImages;
            dModel.Price = vModel.Price;
            dModel.Promotion = vModel.Promotion;
            dModel.Warranty = vModel.Warranty;
            dModel.Description = vModel.Description;
            dModel.Content = vModel.Content;
            dModel.HomeFlag = vModel.HomeFlag;
            dModel.HotFlag = vModel.HotFlag;
            dModel.ViewCount = vModel.ViewCount;
            dModel.MetaKeyword = vModel.MetaKeyword;
            dModel.MetaDescription = vModel.MetaDescription;
            dModel.Status = vModel.Status;
            dModel.CreateDate = vModel.CreateDate;
            dModel.CreateBy = vModel.CreateBy;
            dModel.UpdateDate = vModel.UpdateDate;
            dModel.UpdateBy = vModel.UpdateBy;
        }

        /// <summary>
        /// update value from ProductCategoryViewModel to ProductCategory
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdateProductCategory(this ProductCategory dModel, ProductCategoryViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.Name = vModel.Name;
            dModel.Alias = vModel.Alias;
            dModel.Description = vModel.Description;
            dModel.ParentID = vModel.ParentID;
            dModel.DisplayOrder = vModel.DisplayOrder;
            dModel.Image = vModel.Image;
            dModel.HomeFlag = vModel.HomeFlag;
            dModel.MetaKeyword = vModel.MetaKeyword;
            dModel.MetaDescription = vModel.MetaDescription;
            dModel.Status = vModel.Status;
            dModel.CreateDate = vModel.CreateDate;
            dModel.CreateBy = vModel.CreateBy;
            dModel.UpdateDate = vModel.UpdateDate;
            dModel.UpdateBy = vModel.UpdateBy;
        }

        /// <summary>
        /// update value from ProductTagViewModel to ProductTag
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdateProductTag(this ProductTag dModel, ProductTagViewModel vModel)
        {
            dModel.ProductID = vModel.ProductID;
            dModel.TagID = vModel.TagID;
        }

        /// <summary>
        /// update value from SlideViewModel to Slide
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdateSlide(this Slide dModel, SlideViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.Name = vModel.Name;
            dModel.Description = vModel.Description;
            dModel.Image = vModel.Image;
            dModel.URL = vModel.URL;
            dModel.DisplayOrder = vModel.DisplayOrder;
            dModel.Status = vModel.Status;
        }

        /// <summary>
        /// update value fromm SupportOnlineViewModel to SupportOnline
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdateSupportOnline(this SupportOnline dModel, SupportOnlineViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.Name = vModel.Name;
            dModel.Department = vModel.Department;
            dModel.Skype = vModel.Skype;
            dModel.Mobile = vModel.Mobile;
            dModel.Email = vModel.Email;
            dModel.Yahoo = vModel.Yahoo;
            dModel.Facebook = vModel.Facebook;
            dModel.DisplayOrder = vModel.DisplayOrder;
            dModel.Status = vModel.Status;
        }

        /// <summary>
        /// update data from SystemConfigViewModel to SystemConfig
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdateSystemConfig(this SystemConfig dModel, SystemConfigViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.Code = vModel.Code;
            dModel.ValueString = vModel.ValueString;
            dModel.ValueInt = vModel.ValueInt;
        }

        /// <summary>
        /// update value from TagViewModel to Tag
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdateTag(this Tag dModel, TagViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.Name = vModel.Name;
            dModel.Type = vModel.Type;
        }

        /// <summary>
        /// update value from VisistorStatisticViewModel to VisistorStatistic
        /// </summary>
        /// <param name="dModel"></param>
        /// <param name="vModel"></param>
        public static void UpdateVisistorStatistic(this VisistorStatistic dModel, VisistorStatisticViewModel vModel)
        {
            dModel.ID = vModel.ID;
            dModel.VisistedDate = vModel.VisistedDate;
            dModel.IPAddress = vModel.IPAddress;
        }
    }
}