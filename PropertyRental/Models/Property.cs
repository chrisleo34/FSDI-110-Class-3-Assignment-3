using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PropertyRental.Models;


namespace PropertyRental.Models
{
    public class Property
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Rooms { get; set; }
        
        public int email { get; set; }

        public decimal bathRooms { get; set; }

        public decimal Price { get; set; }

        public int SqrFeet { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }
    }
}
