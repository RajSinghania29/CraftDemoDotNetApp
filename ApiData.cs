﻿/* -------------------------------------------------------------------------------------------------
   Restricted - Copyright (C) Siemens Healthcare GmbH, 2022. All rights reserved
   ------------------------------------------------------------------------------------------------- */
   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftDemonstration
{
    public class ApiData
    {
       public Demo photos { get; set; }

    }

    public class Demo
    {
        public int page { get; set; }

        public int pages { get; set; }

        public int perpage { get; set; }

        public int total { get; set; }

        public List<Photos> photo { get; set; }
    }
    public class Photos
    {
        public string id { get; set; }
        public string owner { get; set; }
        public string secret { get; set; }
        public string server { get; set; }
        public int farm { get; set; }
        public string title { get; set; }
        public int ispublic { get; set; }
        public int isfriend { get; set; }
        public int isfamily { get; set; }
    }
}
