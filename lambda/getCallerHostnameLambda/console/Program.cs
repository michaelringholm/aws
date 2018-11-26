using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Started...");
            //System.Web.HttpContext context = System.Web.HttpContext.Current; 
            //string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            var someIp = "83.221.154.157";
            
            //string visitorIPAddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            IPAddress myIP = IPAddress.Parse(someIp);
            var hostEntry = Dns.GetHostEntry(myIP);
            //var compName = GetIPHost.HostName.ToString().Split('.');
            var hostName = hostEntry.HostName;
            //var first = compName.First();
            Debug.WriteLine("Ended!");
        }
    }
}
