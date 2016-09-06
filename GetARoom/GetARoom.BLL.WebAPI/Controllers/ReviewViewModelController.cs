using GetARoom.BLL.WebAPI.Models.Helpers;
using GetARoom.BLL.WebAPI.Models.ViewModels;
using GetARoom.DAL;
using GetARoom.DAL.SpecificRepositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GetARoom.BLL.WebAPI.Controllers
{
    public class ReviewViewModelController : ApiController
    {
        private Repository<User> unit = new Repository<User>(new GetARoomEntities());
        public IEnumerable<ReviewViewModel> GetReviewsForHotel(int id)
        {
            var rev = HotelHelper.GetReviewsForHotel(id);
            var vms = new List<ReviewViewModel>();
            foreach (var item in rev)
            {
                var vm = new ReviewViewModel
                {
                    Header = item.ReviewHeader,
                    CurrentDate = item.ReviewDate,
                    Description = item.ReviewDescription,
                    Rating = int.Parse(item.ReviewScore),
                    User = unit.GetById(item.UserId)
                };
                vms.Add(vm);
            }
            return vms;
        }


    }
}
