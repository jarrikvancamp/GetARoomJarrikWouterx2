using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetARoom.DAL.SpecificRepositories.Interfaces
{
  public  interface IAddressRepository : IRepository<Address>
    {
        Address GetAddressWithPostal(int id);
        IEnumerable<Address> GetAllAdressesWithPostal();
    }
}
