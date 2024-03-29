﻿using System.Security.Cryptography;
using System.Text;

namespace VirtualPay3dsAuth
{
    class VirtualPay3dsAuthRequestBuilder
    {
        static void Main(string[] args)
        {
            //Your API user provided by VirtualPay
            string merchantID = "Securcap3";
            //[TradeNetworks].[Live].[CreditCardDepositCommunicationLogs].[CreditCardDepositRequestId]. The below is just a sample string formation. See the legacy sources for the exact algorhythm
            string requestID = DateTime.Now.ToString("HH-mm-ms");
            string date = DateTime.Now.ToString("ddmmyy");
            string requestTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string customerName = "Tony Stoyanov";
            string customerPhoneNumber = "359888123456";
            string cardNumber = "4796874002989836";
            string expiry = "112026";
            string amount = "100";
            //Replace with PROfit's Deposit Site the 3DS Return URL, based on your environment (DEV2, QA2, ST, QAPROD, PROD)
            string redirectUrl = "https://tnstoyanov.wixsite.com/payment-response";
            //Replace with PROfit's Billing Server the callback handler URL, based on your environment (DEV2, QA2, ST, QAPROD, PROD)
            string timeoutUrl = "https://db46a064326442f75c6172ae6772049a.m.pipedream.net";
            string currency = "USD";
            //As per ISO Alpha-3
            string country = "BGR";
            string city = "Sofia";
            string cvv = "130";
            string postalCode = "1000";
            string stateCode = "";
            string email = "tony.stoyanov@tiebreak.solutions";
            string description = "Test Deposit";

            string rawConcat = requestID + merchantID + amount + currency;
            string checksum = GenerateSHA256(rawConcat);

            //This builds the request body in XML, no security checksum
            Console.WriteLine("<?xml version= \"1.0\" encoding= \"utf - 8\"?>");
            Console.WriteLine("<message>");
            Console.WriteLine("<merchantID>" + merchantID + "</merchantID>");
            Console.WriteLine("<requestID>" + requestID + "</requestID>");
            Console.WriteLine("<date>" + date + "</date>");
            Console.WriteLine("<requestTime>" + requestTime + "</requestTime>");
            Console.WriteLine("<customerName>" + customerName + "</customerName>");
            Console.WriteLine("<customerPhoneNumber>" + customerPhoneNumber + "</customerPhoneNumber>");
            Console.WriteLine("<cardNumber>" + cardNumber + "</cardNumber>");
            Console.WriteLine("<expiry>" + expiry + "</expiry>");
            Console.WriteLine("<amount>" + amount + "</amount>");
            Console.WriteLine("<redirectUrl>" + redirectUrl + "</redirectUrl>");
            Console.WriteLine("<timeoutUrl>" + timeoutUrl + "</timeoutUrl>");
            Console.WriteLine("<currency>" + currency + "</currency>");
            Console.WriteLine("<country>" + country + "</country>");
            Console.WriteLine("<city>" + city + "</city>");
            Console.WriteLine("<requestID>" + requestID + "</requestID>");
            Console.WriteLine("<cvv>" + cvv + "</cvv>");
            Console.WriteLine("<postalCode>" + postalCode + "</postalCode>");
            Console.WriteLine("<stateCode>" + stateCode + "</stateCode>");
            Console.WriteLine("<email>" + email + "</email>");
            Console.WriteLine("<description>" + description + "</description>");
            Console.WriteLine("<checksum>" + checksum + "</checksum>");
            Console.WriteLine("</message>");

            //This keeps the console window open
            Console.ReadLine();


            // SHA256 and Base64 hashing

            static string GenerateSHA256(string value)
            {
                SHA256 sh = SHA256.Create();
                byte[] hashValue = sh.ComputeHash(Encoding.UTF8.GetBytes(value));
                return Convert.ToBase64String(hashValue);
            }
        }
    }
}