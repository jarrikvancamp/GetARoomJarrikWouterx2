using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetARoom.DAL;


using GetARoom.BLL;
using GetARoom.BLL.Exceptions;
using GetARoom.BLL.ObjectHandlers;

namespace GetARoom.UnitTests
{
    
    [TestClass]
    public class RepositoryTest
    {
        

        [TestMethod]
        public void GetById_Should_Throw_Negative_Exception()
        {
            
            // arrange
           
            int numberToBeChecked = -5;
            try
            {


                Hotel actualRole =_RepositoryHandlerCollection.HotelHandler.GetById(numberToBeChecked);
                Assert.Fail();
            }
            catch (NegativeNumberInDatabaseSearchException nn)
            {

            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Add_Hotel_Without_all_required()
        {
            var _db = _RepositoryHandlerCollection.HotelHandler;

            Hotel h = new Hotel() {
                HotelName ="Bellagio",
                
            };

            Assert.IsTrue(!_db.Add(h));
        }
       

    }


}
