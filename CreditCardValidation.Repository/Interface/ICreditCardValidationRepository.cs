using CreditCardValidation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardValidation.Repository.Interface
{
    public interface ICreditCardValidationRepository
    {
        bool FindById(Decimal id);
    }
}
