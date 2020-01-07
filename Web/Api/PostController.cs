using AutoMapper;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using Web.Infrastructure.Core;
using Web.Infrastructure.Extensions;
using Web.Models;

namespace Web.api
{
    public class PostController : ApiControllerBase
    {
        private IPostService _postService;

        public PostController(IErrorService errorService, IPostService postService) : base(errorService)
        {
            this._postService = postService;
        }

        /// <summary>
        /// add
        /// </summary>
        /// <param name="request"></param>
        /// <param name="vModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Add(HttpRequestMessage request, PostViewModel vModel)
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
                    Post dModel = new Post();
                    dModel.UpdatePost(vModel);

                    var post = _postService.Add(dModel);
                    _postService.SaveChanges();

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
        public HttpResponseMessage Update(HttpRequestMessage request, PostViewModel vModel)
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
                    Post dModel = _postService.GetByKey(vModel.ID);
                    dModel.UpdatePost(vModel);

                    _postService.Update(dModel);
                    _postService.SaveChanges();

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
        public HttpResponseMessage Delete(HttpRequestMessage request, PostViewModel vModel)
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
                    Post dModel = _postService.GetByKey(vModel.ID);
                    var result = _postService.Delete(dModel);
                    _postService.SaveChanges();

                    vModel = Mapper.Map<PostViewModel>(result);
                    response = request.CreateResponse(HttpStatusCode.Moved, vModel);
                }
                return response;
            });
        }

        /// <summary>
        /// Get all records in data
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get-all")]
        public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listDataModel = _postService.GetAll();
                var listViewModel = Mapper.Map<List<PostViewModel>>(listDataModel);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listViewModel);
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
            var listDataModel = _postService.GetAllPaging(page, pageSize, out totalRow);
            var listViewModel = Mapper.Map<List<PostViewModel>>(listDataModel);
            HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listViewModel);
            return CreateHttpResponse(request, () => { return response; });
        }

        /// <summary>
        /// get all where status is true and by category id paging
        /// </summary>
        /// <param name="request"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("get-paging-by-tag")]
        public HttpResponseMessage GetAllPagingByTag(HttpRequestMessage request, string tag, int page, int pageSize, out int totalRow)
        {
            var listDataModel = _postService.GetAllPagingByTag(tag, page, pageSize, out totalRow);
            var listViewModel = Mapper.Map<List<PostViewModel>>(listDataModel);
            HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listViewModel);
            return CreateHttpResponse(request, () => { return response; });
        }

        /// <summary>
        /// get all where status is true and by category id paging
        /// </summary>
        /// <param name="request"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("get-paging-by-category-id")]
        public HttpResponseMessage GetPagingByCategoryID(HttpRequestMessage request, int categoryID, int page, int pageSize, out int totalRow)
        {
            var listDataModel = _postService.GetPagingByCategoryID(categoryID, page, pageSize, out totalRow);
            var listViewModel = Mapper.Map<List<PostViewModel>>(listDataModel);
            HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listViewModel);
            return CreateHttpResponse(request, () => { return response; });
        }

        /// <summary>
        /// get by ID
        /// </summary>
        /// <param name="request"></param>s
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("get-by-key")]
        public HttpResponseMessage GetByKey(HttpRequestMessage request, int ID)
        {
            return CreateHttpResponse(request, () =>
            {
                Post dModel = _postService.GetByKey(ID);
                var vModel = Mapper.Map<PostViewModel>(dModel);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, vModel);
                return response;
            });
        }
    }
}