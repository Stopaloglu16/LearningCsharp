using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIfDemo
{
    public class Parcel
    {
        public int Id { get; set; }
        public string TrackingNumber { get; set; }
        public int CountryId { get; set; }
        public int Weight { get; set; }
    }

  

    public class Model
    {
        public static IQueryable<Parcel> CreateParcelList()
        {
            var list = new List<Parcel>();

            Random random = new Random();
            
            for (int i = 1; i < 10; i++)
            {
                list.Add(new Parcel
                {
                    Id = i,
                    TrackingNumber = "BARCODE" + random.Next(10,99) + DateTime.Now.Millisecond.ToString("D3") + i.ToString("D2"),
                    CountryId = random.Next(1, 10),
                    Weight = random.Next(1, 1000)
                });

                Task.Delay(random.Next(1000));
            }

            return list.AsQueryable();
        }

    }

}
