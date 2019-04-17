using System;
using Xunit;
using AdvertisingApp;
using AdvertisingApp.Services;

namespace Advertising.Tests
{
    public class Advert_Tests
    {
        private readonly AdvertisingService _advertisingService;

        public Advert_Tests()
        {
            _advertisingService = new AdvertisingService();
        }

        [Fact]
        public void BookAdvert_Succeeds_AddingToEmptySlot()
        {
            var ad = new AdvertisingApp.Models.Advert();
            ad.Id = 1;
            ad.Name = "New Advert";
            ad.Length = 30;
            var result = _advertisingService.BookAdvert(ad);
            Assert.True(result, $"{ad.Name} should have been added successfully");
        }

        //[Fact]
        //public void BookAdvert_Fails_AddingToBusySlot()
        //{

        //}
    }
}
