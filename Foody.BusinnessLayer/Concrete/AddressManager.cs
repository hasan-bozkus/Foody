using Foody.BusinnessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinnessLayer.Concrete
{
    public class AddressManager : GenericManager<Address>, IAddressService
    {
        public AddressManager(IGenericDal<Address> genericDal) : base(genericDal)
        {
        }
    }
}
