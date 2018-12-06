using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardValidation.Domain
{
    public class CardInfoModel
    {
        public Guid Card_Info_Id { get; set; }

        public int Card_Number { get; set; }

        public int Card_Expiry_Month { get; set; }

        public int Card_Expiry_year { get; set; }
    }
}
