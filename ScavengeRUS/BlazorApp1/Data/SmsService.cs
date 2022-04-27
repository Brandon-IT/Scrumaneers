using BlazorApp1.Model;
using Microsoft.Extensions.Configuration;
using System;
using Vonage;
using Vonage.Messaging;
using Vonage.Request;
namespace BlazorApp1.Data
{
    public class SmsService
    {
        public IConfiguration Configuration { get; set; }  

        public SmsService(IConfiguration config) {  Configuration = config; }

        /// <summary>
        /// Uses Vonage to send SMS to a US based number. A 1 is added to the beginning of each number.
        /// Vonage is not US based so the country code of 1 is required. 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public SendSmsResponse SendSms(PlayerModel obj)
        {

            var credentials = Credentials.FromApiKeyAndSecret(
                "VONAGE API KEY HERE",
                "VONAGE SECRET KEY HERE"
                );
            var client = new SmsClient(credentials);
            var request = new SendSmsRequest
            {
                To = "1" + obj.Phone_Number,
                From = "VONAGE SENDER PHONE NUMBER HERE",
                Text = "Thank you for joining ScavengeRUs! " +
                "Here is your access code: " + obj.Access_Code +
                " A link to the game has been emailed to you. " + ""
            };
            return client.SendAnSms(request);
        }
    }
}
