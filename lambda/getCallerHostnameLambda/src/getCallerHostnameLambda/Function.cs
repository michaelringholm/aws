using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace getCallerHostnameLambda
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        /// https://stackoverflow.com/questions/43990385/aws-lambda-c-sharp-accessing-custom-context
        //public string FunctionHandler(string input, ILambdaContext context, APIGatewayProxyRequest request)
        public APIGatewayProxyResponse FunctionHandler(Object input, ILambdaContext context)
        {            
            //var forwardedHost = request.Headers["X-Forwarded-Host"];
            //Console.WriteLine($"forwardedHost:{forwardedHost}");
            context.Logger.LogLine($"input:{input.ToString()}");
            string ipAddressString = null; //"www.amazon.de";
            var httpRequest = JsonConvert.DeserializeObject<HttpRequest>(input.ToString());
            if(httpRequest != null && httpRequest.Headers != null) {
                
                context.Logger.LogLine($"X-Forwarded-For:{httpRequest.Headers["X-Forwarded-For"]}");
                ipAddressString = httpRequest.Headers["X-Forwarded-For"];
                context.Logger.LogLine($"HttpMethod:{httpRequest.HttpMethod}");
            }

            var callerHostName = "Unresolved";
            var callerIP = "Unresolved";
            try {
                if(ipAddressString != null) {
                    IPAddress ipAddress = IPAddress.Parse(ipAddressString);                
                    IPHostEntry hostEntry = Dns.GetHostEntry(ipAddress);
                    callerHostName = hostEntry.HostName;
                    callerIP = hostEntry.AddressList[0].ToString();
                    context.Logger.LogLine($"host:{hostEntry.HostName}");
                }
            }
            catch(Exception ex) {
                context.Logger.LogLine(ex.Message);
                context.Logger.LogLine(ex.StackTrace);
            }
            var response = new APIGatewayProxyResponse();
            response.StatusCode = 200;
            response.Body = JsonConvert.SerializeObject(new { callerHostName = callerHostName, callerIP = callerIP, xForwardedFor = ipAddressString });
            return response;
        }
    }
}
