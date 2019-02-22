using System;
using System.ComponentModel.DataAnnotations;

namespace Asseco_Winform.Dto
{
    public class CustomerInfoDto
    {
        public string SubscriberNumber { get; set; }

        public decimal DebtLoadingAmount { get; set; }

        public DateTime LastPaymentDate { get; set; }

        public string TermYear { get; set; }

        public string BillNo { get; set; }

    }
}
