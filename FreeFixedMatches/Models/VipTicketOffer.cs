﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeFixedMatches.Models
{
    public class VipTicketOffer
    {
        public int Id { get; set; }
        public string NameOffer { get; set; }
        public string TextOffer { get; set; }
        public int PriceOffer { get; set; }
    }
}