﻿using System;

namespace VirtualPay3dsAuth
{
    class VirtualPay3dsAuthRequestBuilder
    {
        static void Main(string[] args)
        {
            //Your API user provided by VirtualPay
            string merchantID = "Securcapsecurities";
            //[TradeNetworks].[Live].[CreditCardDepositCommunicationLogs].[CreditCardDepositRequestId]. The below is just a sample string formation. See the legacy sources for the exact algorhythm
            string requestID = DateTime.Now.ToString("HHmmddMMyy");
            string date = DateTime.Now.ToString("ddmmyy");
            string requestTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string customerName = "Tony Stoyanov";
            string customerPhoneNumber = "359888123456";
            //Live cards only! There is no 3DS1 sandbox for this API
            string cardNumber = "4000000000001091";
            string expiry = "022022";
            string amount = "100";
            //Replace with the 3DS Return URL of PROfit's Deposit Site, based on your environment (DEV2, QA2, ST, PROD)
            string redirectUrl = "https://tnstoyanov.wixsite.com/payment-response";
            //Replace with the callback handler URL of PROfit's Billing Server, based on your environment (DEV2, QA2, ST, PROD)
            string timeoutUrl = "https://db46a064326442f75c6172ae6772049a.m.pipedream.net";
            string currency = "USD";
            //As per ISO Alpha-3
            string country = "BGR";
            string city = "Nairobi";
            string cvv = "189";
            string postalCode = "1000";
            string stateCode = "";
            string email = "tony.stoyanov@tiebreak.solutions";
            string description = "Test Deposit";

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
            Console.WriteLine("</message>");

            //This keeps the console window open
            Console.ReadLine();
        }
    }
}