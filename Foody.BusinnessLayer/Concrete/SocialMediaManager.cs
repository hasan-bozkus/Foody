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
    public class SocialMediaManager : GenericManager<SocialMedia>, ISocialMediaService
    {
        public SocialMediaManager(IGenericDal<SocialMedia> genericDal) : base(genericDal)
        {
        }
    }
}
