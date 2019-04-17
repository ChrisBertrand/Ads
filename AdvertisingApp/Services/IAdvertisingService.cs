using AdvertisingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisingApp.Services
{
    public interface IAdvertisingService
    {
        bool BookAdvert(Advert ad);
    }

    /// <summary>
    /// The service deals with all advertising related methods
    /// </summary>
    public class AdvertisingService : IAdvertisingService
    {
        public bool BookAdvert(Advert ad)
        {
            throw new NotImplementedException();
        }
    }
}
