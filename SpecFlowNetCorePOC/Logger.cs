using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace SpecFlowNetCorePOC
{
    class Logger
    {
        private readonly ITestOutputHelper _output;

        public Logger(ITestOutputHelper output)
        {
            _output = output;
        }

        public void LogMessage(string message)
        {
            _output.WriteLine(message);
        }
    }
}
