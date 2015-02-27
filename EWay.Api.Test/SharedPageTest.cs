using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using EWay.Api.Clients;
using EWay.Api.Model;
using EWay.Api.Model.Request;
using EWay.Api.Model.Response;
using EWay.Api.Test.Utils;
using NUnit.Framework;

namespace EWay.Api.Test
{
    [TestFixture]
    public class SharedPageTest
    {
        private ResponsiveSharedClient client;

        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {
            client = new ResponsiveSharedClient(CredentialUtils.GetTestCredentials(), true);
        }

        [Test]
        public void ProcessPaymentTest()
        {
            var request = new SharedPageRequest("http://www.eway.com.au", "http://www.eway.com.au", TransactionType.Purchase);
            request = SetupRequest(request);

            var response = client.ProcessPayment<SharedPageResponse>(request);

            Assert.IsNotNull(response.AccessCode);
            Assert.IsNotNull(response.SharedPaymentUrl);
            Assert.IsNull(response.Errors);
        }

        private SharedPageRequest SetupRequest(SharedPageRequest request)
        {
            request.CustomerIP = "127.0.0.1";
            request.DeviceID = "123";
            request.PartnerID = "456";
            request.Customer = TestUtils.CreateTestCustomer();
            request.Payment = TestUtils.CreateTestPayment();
            request.ShippingAddress = TestUtils.CreateTestShippingAddress();
            request.Items.Add(TestUtils.CreateTestItem());
            
            return request;
        }
    }
}
