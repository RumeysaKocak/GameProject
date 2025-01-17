﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
   public class Campaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public double DiscountRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastDate { get; set; }
    }
}
