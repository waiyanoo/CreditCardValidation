using CreditCardValidation.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCardValidation.Domain;
using CreditCardValidation.Repository.EntityFramework;

namespace CreditCardValidation.Repository
{
    public class CreditCardValidationRepository : ICreditCardValidationRepository
    {
        private CreditCard_DBEntities contex;
        public CreditCardValidationRepository()
        {
            contex = new CreditCard_DBEntities();
        }

        public bool FindById(Decimal id)
        {
            using(contex = new CreditCard_DBEntities())
            {
                var result = contex.FindCreditCardByNumber(id);
                if(result != null)
                {
                    return true;
                }
                return false;
            };
        }
    }
}
