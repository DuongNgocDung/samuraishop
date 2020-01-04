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
    public class TagController : ApiControllerBase
    {
        private ITagService _tagService;

        public TagController(IErrorService errorService, ITagService tagTagService) : base(errorService)
        {
            _tagService = tagTagService;
        }

        /// <summary>
        /// add
        /// </summary>
        /// <param name="request"></param>
        /// <param name="vModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Add(HttpRequestMessage request, TagViewModel vModel)
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
                    Tag dModel = new Tag();
                    dModel.UpdateTag(vModel);

                    var tag = _tagService.Add(dModel);
                    _tagService.SaveChanges();

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
        public HttpResponseMessage Update(HttpRequestMessage request, TagViewModel vModel)
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
                    Tag dModel = _tagService.GetByKey(vModel.ID);
                    dModel.UpdateTag(vModel);

                    _tagService.Update(dModel);
                    _tagService.SaveChanges();

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
        public HttpResponseMessage Delete(HttpRequestMessage request, TagViewModel vModel)
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
                    Tag dModel = _tagService.GetByKey(vModel.ID);
                    var result = _tagService.Delete(dModel);
                    _tagService.SaveChanges();

                    vModel = Mapper.Map<TagViewModel>(result);
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
            var listDataModel = _tagService.GetAllPaging(page, pageSize, out totalRow);
            var listViewModel = Mapper.Map<List<TagViewModel>>(listDataModel);
            HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listViewModel);
            return CreateHttpResponse(request, () => { return response; });
        }

        /// <summary>
        /// get by ID
        /// </summary>
        /// <param name="request"></param>s
        /// <param name="productID"></param>
        /// <param name="tagID"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("get-by-key")]
        public HttpResponseMessage GetByKey(HttpRequestMessage request, string ID)
        {
            return CreateHttpResponse(request, () =>
            {
                Tag dModel = _tagService.GetByKey(ID);
                var vModel = Mapper.Map<TagViewModel>(dModel);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, vModel);
                return response;
            });
        }
    }
}