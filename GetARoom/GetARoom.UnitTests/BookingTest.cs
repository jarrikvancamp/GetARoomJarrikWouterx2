using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetARoom.BLL.ObjectHandlers;

namespace GetARoom.UnitTests
{
    [TestClass]
    public class BookingTest
    {
        [TestMethod]
        public void TestFreeRooms()
        {
         _RepositoryHandlerCollection.HotelHandler.UnbookedRooms(new DateTime(2016,01,01), new DateTime(2018,01,01));

        }
    }
}
