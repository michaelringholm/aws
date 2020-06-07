using System;
using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace OpusMagus
{
    public class URLAmbassador
    {
        public string shortenURL(string originalUrl) {
            return "shortUrl";
        }
    }
}
