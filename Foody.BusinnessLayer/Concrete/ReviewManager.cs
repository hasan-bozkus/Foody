﻿using Foody.BusinnessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinnessLayer.Concrete
{
    public class ReviewManager : IReviewService
    {
        private readonly IReviewDal _reviewDal;

        public ReviewManager(IReviewDal reviewDal = null)
        {
            _reviewDal = reviewDal;
        }

        public void TDelete(int id)
        {
            _reviewDal.Delete(id);
        }

        public List<Review> TGetAll()
        {
            return _reviewDal.GetAll();
        }

        public Review TGetById(int id)
        {
            return _reviewDal.GetById(id);
        }

        public void TInsert(Review entity)
        {
            _reviewDal.Update(entity);
        }

        public void TUpdate(Review entity)
        {
            _reviewDal.Update(entity);
        }
    }
}
