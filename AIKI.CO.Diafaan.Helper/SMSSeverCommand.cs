using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AIKI.CO.Diafaan.Helper
{
    public class SMSSeverCommand
    {
        private CancellationTokenSource cancellationTokenSource;
        private RestClient client;
        private RestRequest request;
        public SMSSeverCommand()
        {

        }

        /// <summary>
        /// Send Message
        /// </summary>
        /// <param name="phoneNumbers">Phone Number for send message like +989163085306 or +989163085306,+939307647195 for multiple send</param>
        /// <param name="message"></param>
        /// <returns>OK: message-id or ERROR:error-code error-message</returns>
        public async Task<IRestResponse> SendMessage(string phoneNumbers,string message)
        {
            cancellationTokenSource = new CancellationTokenSource();
            client = new RestClient(SMSServerSettings.RestURL + DiafaanRestCommand.SendMessage);
            client.Timeout = -1;
            request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("to", phoneNumbers);
            request.AddParameter("message-type", DiafaanRestCommand.MessageTypeSMSAutomatic);
            request.AddParameter("message", message);
            request.AddParameter("username", SMSServerSettings.UserName);
            request.AddParameter("password", SMSServerSettings.Password);

            ServicePointManager.ServerCertificateValidationCallback = new
            RemoteCertificateValidationCallback
            (
               delegate { return true; }
            );
            return await client.ExecuteAsync(request, cancellationTokenSource.Token);
        }
    }
}
