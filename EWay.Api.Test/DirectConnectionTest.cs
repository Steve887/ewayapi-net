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
    public class DirectConnectionTest
    {
        private DirectConnectionClient client;

        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {
            client = new DirectConnectionClient(CredentialUtils.GetTestCredentials(), true);
        }

        [Test]
        public void ProcessPaymentTest()
        {
            var request = new DirectConnectionRequest(TransactionType.MOTO);
            request = SetupRequest(request);

            var response = client.ProcessPayment<DirectConnectionResponse>(request);

            //Assert.IsNull(response.Errors);
            //Assert.IsTrue((bool)response.TransactionStatus);
        }
       
        private DirectConnectionRequest SetupRequest(DirectConnectionRequest request)
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
