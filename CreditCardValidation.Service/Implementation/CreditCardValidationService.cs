using CreditCardValidation.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCardValidation.Domain;
using CreditCardValidation.Repository.Interface;
using CreditCardValidation.Repository;
using CreditCardValidation.Repository.Implementation;

namespace CreditCardValidation.Service.Implementation
{
    public class CreditCardValidationService : ICreditCardValidationService
    {
        private readonly ICreditCardValidationRepository _creditCardValidationRepository;
        #region "Constructors"


        public CreditCardValidationService()
            : this(new CreditCardValidationRepository())
        {
        }


        public CreditCardValidationService(ICreditCardValidationRepository CreditCardValidationRepository)
        {
            _creditCardValidationRepository = CreditCardValidationRepository;
        }

        #endregion "End Constructors"
        public bool ReadCreditCardInfo(CardInfoModel request)
        {
           return _creditCardValidationRepository.FindById(request.Card_Number);
        }
    }
}
