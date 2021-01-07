using DoinGood.Contracts;
using DoinGood.Models;
using GoogleMaps.LocationServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Data
{
    public class CatalystRepository : RepositoryBase<Catalyst>, ICatalystRepository
    {
        public CatalystRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public Catalyst GetCatalyst(string catalystUserId) => FindByCondition(c => c.IdentityUserId == catalystUserId).Include(e => e.Address).FirstOrDefault();

        public Catalyst GetCatalystDetails(int id) => FindByCondition(c => c.CatalystId == id).Include(e => e.Address).FirstOrDefault();

        public Catalyst GeoCode(Catalyst catalyst)
        {
            string address = catalyst.Address.StreetAddress.ToString() + ", " + catalyst.Address.City.ToString() + ", " + catalyst.Address.State.ToString() + ", " + catalyst.Address.Zip.ToString();
            var geocode = new GoogleLocationService(APIKey.GoogleApi);
            var coords = geocode.GetLatLongFromAddress(address);
            catalyst.Lat = coords.Latitude;
            catalyst.Lng = coords.Longitude;
            return catalyst;
        }
    }
}
