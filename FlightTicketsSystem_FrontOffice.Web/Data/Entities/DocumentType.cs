﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightTicketsSystem_FrontOffice.Web.Data.Entities
{
    public class DocumentType : IEntity
    {
        public int Id { get; set; }

        public string Type { get; set; }


        public User user { get; set; }

    }
}
