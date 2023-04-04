using BLL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsCat.Controllers
{
    public class NewsController : ApiController
    {
        [HttpGet]
        [Route("api/newses")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = NewsServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
        [HttpGet]
        [Route("api/newses/{id:int}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, NewsServices.Get(id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }


        [HttpGet]
        [Route("api/newses/{cname}")]
        public HttpResponseMessage GetN(string cname)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, NewsServices.GetN(cname));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/newses/{date:datetime}")]
        public HttpResponseMessage GetD(DateTime date)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, NewsServices.GetD(date));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/newses/{date:datetime}/{cname}")]
        public HttpResponseMessage GetDN(DateTime date,string cname)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, NewsServices.GetDN(date,cname));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
