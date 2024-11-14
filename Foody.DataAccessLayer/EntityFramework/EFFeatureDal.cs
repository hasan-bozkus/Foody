using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class EFFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EFFeatureDal(FoodyContext context) : base(context)
        {
        }

        public List<Feature> FeatureListByStatusTrue()
        {
            var context = new FoodyContext();
            var values = context.Features.Where(x => x.Status).ToList();
            return values;
        }
    }
}
