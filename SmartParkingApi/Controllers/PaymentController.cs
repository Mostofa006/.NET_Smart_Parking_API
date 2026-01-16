using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartParkingApi.Controllers
{
    [RoutePrefix("api/payment")]
    public class PaymentController : ApiController
    {
        [HttpGet]
        [Route("user")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = PaymentService.Get(); // Returns List<PaymentDTO>
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
