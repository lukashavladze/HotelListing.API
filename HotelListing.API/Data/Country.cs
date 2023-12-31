﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Data
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public  List<Hotel> Hotels { get; set; } = new List<Hotel>();
    }
}