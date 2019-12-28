using Model.Models;
using Service.Interface;
using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Infrastructure.Core
{
    /// <summary>
    /// "Chủ yếu cái Api này dùng để sử dụng các phương thức chung nên bắt lỗi ta cũng bắt lỗi chung ở trong này"
    /// => đéo hiểu
    /// </summary>
    public class ApiControllerBase : ApiController
    {
        private IErrorService _errorService;

        public ApiControllerBase(IErrorService errorService)
        {
            this._errorService = errorService;
        }

        protected HttpResponseMessage CreateHttpResponse(HttpRequestMessage requestMessage, Func<HttpResponseMessage> function)
        {
            HttpResponseMessage response = null;
            try
            {
                response = function.Invoke();
            }
            catch(DbEntityValidationException ex) //cái này để log cụ thể nó xảy ra ở cái table nào (chắc v)
            {
                foreach(var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation error.");
                    foreach(var ve in eve.ValidationErrors)
                    {
                        Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                    }
                }
            }
            catch (DbUpdateException dbEx) //hình như cái này là log tầng database - repository ? => nên phải inner vào bên trong để lấy vấn đề
            {
                LogError(dbEx);
                response = requestMessage.CreateResponse(HttpStatusCode.BadRequest, dbEx.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                response = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return response;
        }

        /// <summary>
        /// Lưu lỗi vào database
        /// </summary>
        /// <param name="ex"></param>
        private void LogError(Exception ex)
        {
            try
            {
                Error err = new Error()
                {
                    Message = ex.Message,
                    StackTrace = ex.StackTrace,
                    CreateDate = DateTime.Now
                };

                _errorService.Add(err);
                _errorService.SaveChanges();
            }
            catch
            {
            }
        }
    }
}