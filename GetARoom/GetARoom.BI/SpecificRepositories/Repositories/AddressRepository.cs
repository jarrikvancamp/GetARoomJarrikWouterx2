using GetARoom.DAL.SpecificRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GetARoom.DAL.SpecificRepositories.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(GetARoomEntities db) : base(db)
        {
        }

        public Address GetAddressWithPostal(int id)
        {
            return _db.Address.Include(x => x.Postal).FirstOrDefault(x => x.AddressId == id);
        }

        public IEnumerable<Address> GetAllAdressesWithPostal()
        {
            return _db.Address.Include(x => x.Postal);
        }
    }
}
