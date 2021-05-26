﻿using System;
using System.Collections.Generic;
using System.Text;
using NewYearGift.Models;

namespace NewYearGift.Services
{
    class SweetInMemoryService:ISweetService
    {
        private readonly List<Sweet> _sweetsList = new List<Sweet>()
        {
            new ChocolateSweet("Ромашка", "Коммунарка", weight: 10.4d, sugarWeight: 4.2d, price: 0.50m, "Молочный"),
            new ChocolateSweet("Черемуха", "Коммунарка", weight: 12.4d, sugarWeight: 3.5d, price: 0.45m, "Темный"),
            new Lollipop("Леденец", "Коммунарка", weight: 8d, sugarWeight: 6d, price: 0.22m, "Дюшес"),
            new Lollipop("Леденец", "Коммунарка", weight: 8d, sugarWeight: 6d, price: 0.22m, "Мята"),
            new Lollipop("Леденец", "Коммунарка", weight: 8d, sugarWeight: 6d, price: 0.22m, "Барбарис"),
        };

        public List<Sweet> GetAll() => _sweetsList;

        public Sweet GetById(int id)
        {
            if (id < 0 || id >= _sweetsList.Count)
            {
                throw new ArgumentException("Такой сладости не существует.", nameof(id));
            }

            return _sweetsList[id];
        } 

        public Sweet Add(Sweet sweet)
        {
            if (sweet == null)
            {
                throw new ArgumentNullException(nameof(sweet), "Сладость не может быть null");
            }
            _sweetsList.Add(sweet);
            return sweet;
        }

        public Sweet Update(int id, Sweet sweet)
        {
            if (id < 0 || id >= _sweetsList.Count)
            {
                throw new ArgumentException("Такой сладости не существует.", nameof(id));
            }
            if (sweet == null)
            {
                throw new ArgumentNullException(nameof(sweet), "Сладость не может быть null");
            }
            _sweetsList[id] = sweet;
            return sweet;
        }

        public Sweet Delete(int id)
        {
            if (id < 0 || id >= _sweetsList.Count)
            {
                throw new ArgumentException("Такой сладости не существует.", nameof(id));
            }

            var deletedSweet = _sweetsList[id];
            _sweetsList.RemoveAt(id);
            return deletedSweet;
        }
    }
}
