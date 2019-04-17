using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisingApp.Models
{
    interface ISlot
    {
        int Id{ get; set; }
        DateTime slotTime  { get; set; }
        int duration { get; set; }
        Advert advertInSlot { get; set; }
    }

    public class Slot : ISlot
    {
        public Slot()
        {
        }
        public int Id { get; set; }
        public DateTime slotTime { get; set; }
        public Advert advertInSlot { get; set; }
        public int duration { get; set; }
    }
}
