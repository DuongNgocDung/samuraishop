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

namespace Web.Api
{
    public class OrderController : ApiControllerBase
    {
        private IOrderService _orderService;

        public OrderController(IErrorService errorService, IOrderService orderService) : base(errorService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// add
        /// </summary>
        /// <param name="request"></param>
        /// <param name="vModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Add(HttpRequestMessage request, OrderViewModel vModel)
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
                    Order dModel = new Order();
                    dModel.UpdateOrder(vModel);
                    var Order = _orderService.Add(dModel);
                    _orderService.SaveChanges();

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
        public HttpResponseMessage Update(HttpRequestMessage request, OrderViewModel vModel)
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
                    Order dModel = _orderService.GetByKey(vModel.ID);
                    dModel.UpdateOrder(vModel);

                    _orderService.Update(dModel);
                    _orderService.SaveChanges();

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
        public HttpResponseMessage Delete(HttpRequestMessage request, OrderViewModel vModel)
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
                    Order dModel = _orderService.GetByKey(vModel.ID);
                    var result = _orderService.Delete(dModel);
                    _orderService.SaveChanges();

                    vModel = Mapper.Map<OrderViewModel>(result);
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
            var listDataModel = _orderService.GetAllPaging(page, pageSize, out totalRow);
            var listViewModel = Mapper.Map<List<OrderViewModel>>(listDataModel);
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
                Order dModel = _orderService.GetByKey(ID);
                var vModel = Mapper.Map<OrderViewModel>(dModel);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, vModel);
                return response;
            });
        }
    }
}
