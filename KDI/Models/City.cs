﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KDI.Models
{
    public class City
    {
        public int Id { get; set; }
        public int CityId { get; set; }

        public string CityName { get; set; }
        public string Population { get; set; }
    }
}