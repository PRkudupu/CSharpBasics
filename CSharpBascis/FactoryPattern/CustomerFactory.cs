﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBascis.FactoryPattern
{
    interface ICustomer
    {
        string Calculate();
    }
    //Factory class
    class CustomerFactory
    {
        List<ICustomer> customerList = new List<ICustomer>();
        public CustomerFactory()
        {
            //Simple customer
            customerList.Add(new SimpleCustomer());
            //Discounted Customer
            customerList.Add(new DiscountedCustomer());

        }
        
        //Note return type is an interface.Reason is that of polymorphism
        //At run time an object of one type can point to object of another type is known as polymorphism.
        public ICustomer create(int i)
        {
            return customerList[i];
        }
    }
    //Concerete class for Simple customer
    class SimpleCustomer: ICustomer
    {
        public string Calculate()
        {
            return "Calculation for simple Customer.";
        }
    }
    //Concrete class for Discounted Customer
    class DiscountedCustomer: ICustomer
    {
        public string Calculate()
        {
            return "Calculation for Discounted Customer.";
        }
    }
}
