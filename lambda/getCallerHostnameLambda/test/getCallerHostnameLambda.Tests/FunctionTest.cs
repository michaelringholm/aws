using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using getCallerHostnameLambda;
using System.Diagnostics;

namespace getCallerHostnameLambda.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {

            // Invoke the lambda function and confirm the string was upper cased.
            var function = new Function();
            var context = new TestLambdaContext();
            var response = function.FunctionHandler("hello world", context);
            Assert.Equal("Message from Skynet!", "aaa");
        }
    }
}
