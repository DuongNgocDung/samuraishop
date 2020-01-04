using AutoMapper;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.Infrastructure.Core;
using Web.Infrastructure.Extensions;
using Web.Models;

namespace Web.Api
{
    public class PostTagTagController : ApiControllerBase
    {
        private IPostTagService _postTagService;

        public PostTagTagController(IErrorService errorService, IPostTagService postTagTagService) : base(errorService)
        {
            _postTagService = postTagTagService;
        }

        /// <summary>
        /// add
        /// </summary>
        /// <param name="request"></param>
        /// <param name="vModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Add(HttpRequestMessage request, PostTagViewModel vModel)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    PostTag dModel = new PostTag();
                    dModel.UpdatePostTag(vModel);

                    var postTag = _postTagService.Add(dModel);
                    _postTagService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, vModel);
                }
                return response;
            });
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="request"></param>
        /// <param name="vModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("update")]
        public HttpResponseMessage Update(HttpRequestMessage request, PostTagViewModel vModel)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    PostTag dModel = _postTagService.GetByKey(vModel.PostID, vModel.TagID);
                    dModel.UpdatePostTag(vModel);

                    _postTagService.Update(dModel);
                    _postTagService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        /// <summary>
        /// delete one records
        /// </summary>
        /// <param name="request"></param>
        /// <param name="vModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("delete")]
        public HttpResponseMessage Delete(HttpRequestMessage request, PostTagViewModel vModel)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    PostTag dModel = _postTagService.GetByKey(vModel.PostID, vModel.TagID);
                    var result = _postTagService.Delete(dModel);
                    _postTagService.SaveChanges();

                    vModel = Mapper.Map<PostTagViewModel>(result);
                    response = request.CreateResponse(HttpStatusCode.Moved, vModel);
                }
                return response;
            });
        }

        /// <summary>
        /// get all where status is true paging
        /// </summary>
        /// <param name="request"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("get-all-paging")]
        public HttpResponseMessage GetAllPaging(HttpRequestMessage request, int page, int pageSize, out int totalRow)
        {
            var listDataModel = _postTagService.GetAllPaging(page, pageSize, out totalRow);
            var listViewModel = Mapper.Map<List<PostTagViewModel>>(listDataModel);
            HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listViewModel);
            return CreateHttpResponse(request, () => { return response; });
        }

        /// <summary>
        /// get by ID
        /// </summary>
        /// <param name="request"></param>s
        /// <param name="postID"></param>
        /// <param name="tagID"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("get-by-key")]
        public HttpResponseMessage GetByKey(HttpRequestMessage request, int postID, string tagID)
        {
            return CreateHttpResponse(request, () =>
            {
                PostTag dModel = _postTagService.GetByKey(postID, tagID);
                var vModel = Mapper.Map<PostTagViewModel>(dModel);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, vModel);
                return response;
            });
        }
    }
}