﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMDataLayer
{
    public class Report : Entity<Report>
    {
        private Guid _userId;

        private Guid _orderId;

        [Column]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateTime { get; set; }

        public string Status { get; set; }

        public User User
        {
            get { return User.Items.Where(items => items.Id == _userId).FirstOrDefault(); }
            set { _userId = value.Id; }
        }

        public Order Order
        {
            get { return Order.Items.Where(items => items.Id == _orderId).FirstOrDefault(); }
            set { _orderId = value.Id; }
        }

        public IEnumerable<User> Users
        {
            get { return User.Items.Where(items => items.Id == User.Id); }
        }

        public IEnumerable<Order> Orders
        {
            get { return Order.Items.Where(items => items.Id == User.Id); }
        }
    }
}
