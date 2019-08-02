using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Offer.Models
{
    public class Postcode
    {
        public int ID { get; set; }
        public string Pcode { set; get; }
        public string Locality { set; get; }
        public string State { set; get; }
        public string Comments { set; get; }
        public string DeliveryOffice { set; get; }
        public string PreSortIndicator { set; get; }
        public string ParcelZone { set; get; }
        public string BSPnumber { set; get; }
        public string BSPname { set; get; }
        public string Catogory { set; get; }
    }
}
