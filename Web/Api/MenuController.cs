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
    public class MenuController : ApiControllerBase
    {
        private IMenuService _menuService;

        public MenuController(IErrorService errorService, IMenuService menuService) : base(errorService)
        {
            _menuService = menuService;
        }

        /// <summary>
        /// add
        /// </summary>
        /// <param name="request"></param>
        /// <param name="vModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Add(HttpRequestMessage request, MenuViewModel vModel)
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
                    Menu dModel = new Menu();
                    dModel.UpdateMenu(vModel);

                    var menu = _menuService.Add(dModel);
                    _menuService.SaveChanges();

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
        public HttpResponseMessage Update(HttpRequestMessage request, MenuViewModel vModel)
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
                    Menu dModel = _menuService.GetByKey(vModel.ID);
                    dModel.UpdateMenu(vModel);

                    _menuService.Update(dModel);
                    _menuService.SaveChanges();

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
        public HttpResponseMessage Delete(HttpRequestMessage request, MenuViewModel vModel)
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
                    Menu dModel = _menuService.GetByKey(vModel.ID);
                    var result = _menuService.Delete(dModel);
                    _menuService.SaveChanges();

                    vModel = Mapper.Map<MenuViewModel>(result);
                    response = request.CreateResponse(HttpStatusCode.Moved, vModel);
                }
                return response;
            });
        }

        /// <summary>
        /// Get all paging
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get-all-paging")]
        public HttpResponseMessage GetAllPaging(HttpRequestMessage request, int page, int pageSize, out int totalRow)
        {
            var listDataModel = _menuService.GetAllPaging(page, pageSize, out totalRow);
            var listViewModel = Mapper.Map<List<MenuViewModel>>(listDataModel);
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
                Menu dModel = _menuService.GetByKey(ID);
                var vModel = Mapper.Map<MenuViewModel>(dModel);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, vModel);
                return response;
            });
        }
    }
}