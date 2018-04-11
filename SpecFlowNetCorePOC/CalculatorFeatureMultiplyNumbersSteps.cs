using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowNetCorePOC
{
    [Binding]
    public class CalculatorFeatureMultiplyNumbersSteps
    {
        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            Thread.Sleep(3000);
        }
    }
}
