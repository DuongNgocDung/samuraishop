using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetMultiPagingByTag(string tag, int page, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.Tag.Name == tag && p.Status
                        orderby p.CategoryID, p.ID
                        select p;

            totalRow = query.Count();
            var skip = (page - 1) * pageSize;
            var display = Math.Min(totalRow - skip, pageSize);
            var finalRecords = query.Skip(skip).Take(display);
            return finalRecords;
        }
    }
}