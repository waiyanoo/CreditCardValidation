using CreditCardValidation.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCardValidation.Domain;
using CreditCardValidation.Repository.EntityFramework;

namespace CreditCardValidation.Repository.Implementation
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
                CardInfoModel model = new CardInfoModel();
                var result = contex.FindCreditCardByNumber(id);
                foreach (card_info_tbl tbl  in result)
                {
                    return true;

                }
               
                return false;
            };
        }
    }
}
