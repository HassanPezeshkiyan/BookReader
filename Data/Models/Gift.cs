﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReader.Data.Models
{
    public class Gift
    {
        public int Id { get; set; }
        public int GiftGiverId { get; set; }
        public int GiftRecipientId { get; set; }
        public int WalletId{ get; set; }
        public int InvoiceId { get; set; }
        public string GiftCode { get; set; }
        public DateTime RecieveDate { get; set; }
        public DateTime CreationDate { get; set; }

        public User Giver { get; set; }
        public User Recipient { get; set; }
        //TODO: wallet model is needed here
        //TODO: invoice model is needed here

    }
}
