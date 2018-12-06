using CreditCardValidation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardValidation.Service.Interface
{
    public interface ICreditCardValidationService
    {
        bool ReadCreditCardInfo(CardInfoModel request); 
    }
}
