using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EWay.Api.Model;

namespace EWay.Api.Test.Utils
{
    public static class TestUtils
    {
        public static Customer CreateTestCustomer()
        {
            var customer = new Customer
                               {
                                   Reference = "A12345",
                                   Title = "Mr.",
                                   FirstName = "John",
                                   LastName = "Smith",
                                   CompanyName = "Demo Shop 123", 
                                   JobDescription = "Developer",
                                   Street1 = "Level 5",
                                   Street2 = "369 Queen Street", 
                                   City = "Sydney", 
                                   State = "NSW", 
                                   PostalCode = "2000", 
                                   Country = "au",
                                   Phone = "09 889 0986", 
                                   Mobile = "09 889 6542",
                                   Fax = "09 889 6543",
                                   Email = "demo@example.org", 
                                   Url = "http://www.ewaypayments.com"
                               };

            customer.CardDetails = new CardDetails();
            customer.CardDetails.Name = "John Smith";
            customer.CardDetails.Number = "4444333322221111";
            customer.CardDetails.ExpiryMonth = 12;
            customer.CardDetails.ExpiryYear = 25;
            customer.CardDetails.CVN = 123;
            return customer;
        }

        public static Payment CreateTestPayment()
        {
            var payment = new Payment
                              {
                                  TotalAmount = 1000, 
                                  InvoiceNumber = "Inv 21540",
                                  InvoiceDescription = "Individual Invoice Description", 
                                  InvoiceReference = "513456", 
                                  CurrencyCode = "AUD"
                              };

            return payment;
        }

        public static ShippingAddress CreateTestShippingAddress()
        {
            var shippingAddress = new ShippingAddress
                                      {
                                          ShippingMethod = "NextDay",
                                          FirstName = "John",
                                          LastName = "Smith",
                                          Street1 = "Level 5",
                                          Street2 = "369 Queen Street",
                                          City = "Sydney",
                                          State = "NSW",
                                          Country = "au",
                                          PostalCode = "2000",
                                          Phone = "09 889 0986"
                                      };

            return shippingAddress;
        }

        public static Item CreateTestItem()
        {
            var item = new Item
                           {
                               SKU = "12345678901234567890", 
                               Description = "Item Description 1",
                               Quantity = 1, 
                               UnitCost = 400,
                               Tax = 100, 
                               Total = 500
                           };

            return item;
        }
    }
}
