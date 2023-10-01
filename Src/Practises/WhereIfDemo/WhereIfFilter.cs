using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIfDemo
{


    public class WhereIfFilter
    {
        public int? CountryId { get; set; }
        public int? MinWeight { get; set; }
        public int? MaxWeight { get; set; }

        public List<Parcel> FilterList(IQueryable<Parcel> parcels, WhereIfFilter filters)
        {
            return parcels.WhereIf(filters.CountryId > 0, a => a.CountryId == filters.CountryId)
                .WhereIf(filters.MinWeight > 0 && filters.MaxWeight > 0, a => a.Weight > filters.MinWeight && a.Weight < filters.MaxWeight)
                .ToList();

        }

        public void PrintList(List<Parcel> myList)
        {
            foreach (var item in myList)
                Console.WriteLine(item.CountryId + " " + item.Weight + " " + item.TrackingNumber);
        }
    }
}
