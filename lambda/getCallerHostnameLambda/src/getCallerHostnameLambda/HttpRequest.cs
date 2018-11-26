using System;
using System.Collections.Generic;

namespace getCallerHostnameLambda
{
    public class HttpRequest
    {
        public String Resource { get; set; }
        public String Path { get; set; }
        public String HttpMethod { get; set; }
        public Dictionary<String,String> Headers { get; set; }
        public String Body { get; set; }
        public Boolean IsBase64Encoded { get; set; }
    }
}

/*{
    "resource": "/getCallerHostname",
    "path": "/getCallerHostname",
    "httpMethod": "POST",
    "headers": {
        "Accept": "application/json",
        "accept-encoding": "gzip, deflate",
        "cache-control": "no-cache",
        "Content-Type": "application/json",
        "Host": "u4s36jazvi.execute-api.eu-central-1.amazonaws.com",
        "Postman-Token": "9e900c0b-050f-4efa-871e-435345c6a871",
        "User-Agent": "PostmanRuntime/7.4.0",
        "X-Amzn-Trace-Id": "Root=1-5bfbe49a-119fbe74568f3cd2489875ba",
        "X-Forwarded-For": "83.221.154.157",
        "X-Forwarded-Port": "443",
        "X-Forwarded-Proto": "https"
    },
    "multiValueHeaders": {
        "Accept": [
            "application/json"
        ],
        "accept-encoding": [
            "gzip, deflate"
        ],
        "cache-control": [
            "no-cache"
        ],
        "Content-Type": [
            "application/json"
        ],
        "Host": [
            "u4s36jazvi.execute-api.eu-central-1.amazonaws.com"
        ],
        "Postman-Token": [
            "9e900c0b-050f-4efa-871e-435345c6a871"
        ],
        "User-Agent": [
            "PostmanRuntime/7.4.0"
        ],
        "X-Amzn-Trace-Id": [
            "Root=1-5bfbe49a-119fbe74568f3cd2489875ba"
        ],
        "X-Forwarded-For": [
            "83.221.154.157"
        ],
        "X-Forwarded-Port": [
            "443"
        ],
        "X-Forwarded-Proto": [
            "https"
        ]
    },
    "queryStringParameters": null,
    "multiValueQueryStringParameters": null,
    "pathParameters": null,
    "stageVariables": null,
    "requestContext": {
        "resourceId": "3ailhe",
        "resourcePath": "/getCallerHostname",
        "httpMethod": "POST",
        "extendedRequestId": "Q-CoNE3_FiAFabQ=",
        "requestTime": "26/Nov/2018:12:18:34 +0000",
        "path": "/default/getCallerHostname",
        "accountId": "220196164496",
        "protocol": "HTTP/1.1",
        "stage": "default",
        "domainPrefix": "u4s36jazvi",
        "requestTimeEpoch": 1543234714901,
        "requestId": "655f44ef-f175-11e8-b7ea-41233f0a65aa",
        "identity": {
            "cognitoIdentityPoolId": null,
            "accountId": null,
            "cognitoIdentityId": null,
            "caller": null,
            "sourceIp": "83.221.154.157",
            "accessKey": null,
            "cognitoAuthenticationType": null,
            "cognitoAuthenticationProvider": null,
            "userArn": null,
            "userAgent": "PostmanRuntime/7.4.0",
            "user": null
        },
        "domainName": "u4s36jazvi.execute-api.eu-central-1.amazonaws.com",
        "apiId": "u4s36jazvi"
    },
    "body": "{ \"name\":\"Mike\" }",
    "isBase64Encoded": false
}
*/