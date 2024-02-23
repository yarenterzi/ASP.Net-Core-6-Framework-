using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //Sqlde ki Column ,C# da Propertyleri | Sqlde ki Table , C# da Classları tutar
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int  AppUserId{ get;set; }
        public AppUser AppUser { get; set; }
        public string PersonCount { get; set; }
         
        public DateTime ReservationDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
