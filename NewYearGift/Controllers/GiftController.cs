﻿using System;
using System.Collections.Generic;
using NewYearGift.Models;
using NewYearGift.Repositories;

namespace NewYearGift.Controllers
{
    public class GiftController
    {
        private readonly IGiftRepository _giftRepository;
        private readonly ISweetRepository _sweetRepository;
        public GiftController(IGiftRepository giftService, ISweetRepository sweetService)
        {
            _giftRepository = giftService;
            _sweetRepository = sweetService;
        }

        public List<Gift> GetAll()
        {
            throw new NotImplementedException();
            //return _giftRepository.ListAll();
        }

        public Gift GetById(int id)
        {
            return _giftRepository.GetById(id);
        }

        public Gift Add(Gift gift)
        {
            throw new NotImplementedException();
            //return _giftRepository.Add(gift);
        }
        public Gift Update(int id, Gift gift)
        {
            throw new NotImplementedException();
            //return _giftRepository.Update(id, gift);
        }

        public Gift Delete(int id)
        {
            throw new NotImplementedException();
            //return _giftRepository.Delete(id);
        }

        public void AddSweetToGift(int giftId, int sweetId, int count)
        {
            var sweet = _sweetRepository.GetById(sweetId);
            _giftRepository.AddSweetToGift(giftId, sweet, count);
        }

        public void Order(int giftId, SweetsOrderRule orderRule)
        {
            _giftRepository.Order(giftId, orderRule);
        }

        public Sweet FindSweetBySugarRange(int giftId, int startValue, int endValue)
        {
            return _giftRepository.FindSweetBySugarRange(giftId, startValue, endValue);
        }
    }
}
