using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MvcApp.Models
{
    public class Customer
    {
        private int _customerId;
        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        private string _customerName;

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        private decimal _amount;

        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        
        
    }
}