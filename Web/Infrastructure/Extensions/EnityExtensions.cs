using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.Infrastructure.Extensions
{
    public static class EnityExtensions
    {
        /// <summary>
        /// tức là các PostCategory sẽ có thêm cái phương thức này khi mà nó đc using cái namespace này vô
        /// Khi mà map từ database qua ViewModel thì có thể map 1-1 được
        /// </summary>
        /// <param name=""></param>
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVm)
        {
            postCategory.ID = postCategoryVm.ID;
            postCategory.Name = postCategoryVm.Name;
            postCategory.Alias = postCategoryVm.Alias;
            postCategory.Description = postCategoryVm.Description;
            postCategory.ParentID = postCategoryVm.ParentID;
            postCategory.DisplayOrder = postCategoryVm.DisplayOrder;
            postCategory.Image = postCategoryVm.Image;
            postCategory.HomeFlag = postCategoryVm.HomeFlag;
            postCategory.MetaKeyword = postCategoryVm.MetaKeyword;
            postCategory.MetaDescription = postCategoryVm.MetaDescription;
            postCategory.Status = postCategoryVm.Status;
            postCategory.CreateDate = postCategoryVm.CreateDate;
            postCategory.CreateBy = postCategoryVm.CreateBy;
            postCategory.UpdateDate = postCategoryVm.UpdateDate;
            postCategory.UpdateBy = postCategoryVm.UpdateBy;
        }

        public static void UpdatePost(this Post post, PostViewModel postVm)
        {
            post.ID = postVm.ID;
            post.Name = postVm.Name;
            post.Alias = postVm.Alias;
            post.CategoryID = postVm.CategoryID;
            post.Image = postVm.Image;
            post.Description = postVm.Description;
            post.Content = postVm.Content;
            post.HomeFlag = postVm.HomeFlag;
            post.HotFlag = postVm.HotFlag;
            post.ViewCount = postVm.ViewCount;
            post.MetaKeyword = postVm.MetaKeyword;
            post.MetaDescription = postVm.MetaDescription;
            post.Status = postVm.Status;
            post.CreateDate = postVm.CreateDate;
            post.CreateBy = postVm.CreateBy;
            post.UpdateDate = postVm.UpdateDate;
            post.UpdateBy = postVm.UpdateBy;
        }

        public static void UpdatePostTag(this PostTag postTag, PostTagViewModel postTagVm)
        {
            postTag.PostID = postTagVm.PostID;
            postTag.TagID = postTagVm.TagID;
        }

        public static void UpdateTag(this Tag tag, TagViewModel tagVm)
        {
            tag.ID = tagVm.ID;
            tag.Name = tagVm.Name;
            tag.Type = tagVm.Type;
        }
    }
}