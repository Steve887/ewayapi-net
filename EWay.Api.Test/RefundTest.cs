﻿using System;
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
    public class RefundTest
    {
        private TransparentRedirectClient client;

        [TestFixtureSetUp]
        public void TestFixtureSetup()
        {
            client = new TransparentRedirectClient(CredentialUtils.GetTestCredentials(), true);
        }

        [Test]
        public void RefundPaymentTest()
        {
            var request = new TransparentRedirectRequest("http://www.eway.com.au", TransactionType.Purchase);
            request = SetupRequest(request) as TransparentRedirectRequest;

            var response = client.ProcessPayment<TransparentRedirectResponse>(request);

            Assert.IsNotNull(response.AccessCode);
            Assert.IsNotNull(response.FormActionURL);
            Assert.IsNull(response.Errors);

            SubmitPaymentForm(response.FormActionURL, response.AccessCode);

            var accessResponse = client.GetAccessCodeResult(response.AccessCode);
            Assert.IsNull(accessResponse.Errors);
            Assert.IsTrue((bool)accessResponse.TransactionStatus);

            var refundClient = new TransactionClient(CredentialUtils.GetTestCredentials(), true);

            var refundRequest = new RefundRequest();
            refundRequest = SetupRequest(refundRequest) as RefundRequest;

            var refundResponse = refundClient.RefundTransaction(refundRequest, accessResponse.TransactionID.ToString());
            Assert.IsNull(refundResponse.Errors);

            var queryResponse = refundClient.QueryTransaction(accessResponse.TransactionID.ToString());

            Assert.AreEqual(1, queryResponse.Transactions.Count);
            Assert.AreEqual(string.Empty, queryResponse.Errors);
        }
        
        private BaseRequest SetupRequest(BaseRequest request)
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

        private string SubmitPaymentForm(string url, string accessCode)
        {
            string paymentType = "Credit Card";
            string cardName = "Test";
            string cardNumber = "4444333322221111";
            string cardExpiryMonth = "12";
            string cardExpiryYear = (DateTime.Now.Year + 1).ToString();
            string cardCvn = "123";

            string result = "";
            string strPost =
                "EWAY_ACCESSCODE=" + accessCode +
                "&EWAY_PAYMENTTYPE=" + paymentType +
                "&EWAY_CARDNAME=" + cardName +
                "&EWAY_CARDNUMBER=" + cardNumber +
                "&EWAY_CARDEXPIRYMONTH=" + cardExpiryMonth +
                "&EWAY_CARDEXPIRYYEAR=" + cardExpiryYear +
                "&EWAY_CARDCVN=" + cardCvn;

            StreamWriter myWriter = null;

            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            objRequest.Method = "POST";
            objRequest.ContentLength = strPost.Length;
            objRequest.ContentType = "application/x-www-form-urlencoded";

            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(strPost);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }
    }
}
