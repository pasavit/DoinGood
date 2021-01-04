using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Models
{
    public class Address
    {
        [Key]
        public int AddressId;

        public string StreetAddress;

        public string City;

        public string State;

        public int Zip;

        public int Lat;

        public int Lng;
    }
}
