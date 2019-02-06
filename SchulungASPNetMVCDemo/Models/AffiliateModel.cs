﻿using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchulungASPNetMVCDemo.Models
{
    public class AffiliateModel : TableEntity
    {
        public string Affiliate { get; set; }
        public string Article { get; set; }
    }
}
