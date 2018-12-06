using CreditCardValidation.Domain;
using CreditCardValidation.Service.Implementation;
using CreditCardValidation.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace CreditCardValidation.Controllers
{
    [RoutePrefix("CreditCardService")]
    public class CreditCardValidationController : ApiController
    {
        private readonly ICreditCardValidationService _CreditCardValidationService;

        public CreditCardValidationController()
            : this(new CreditCardValidationService())
        {
        }

        public CreditCardValidationController(ICreditCardValidationService creditCardValidationService)
        {
            _CreditCardValidationService = creditCardValidationService;
        }
        [HttpGet]
        [Route("ReadCreditCardbyCardNumber/{id}")]
        [ResponseType(typeof(bool))]
        public HttpResponseMessage ReadCreditCardbyCardNumber(string id)
        {
            CardInfoModel request = new CardInfoModel();
            request.Card_Number = Convert.ToDecimal( id);
            var serviceResponse = _CreditCardValidationService.ReadCreditCardInfo(request);

            return Request.CreateResponse(HttpStatusCode.OK, serviceResponse);
        }
    }
}
