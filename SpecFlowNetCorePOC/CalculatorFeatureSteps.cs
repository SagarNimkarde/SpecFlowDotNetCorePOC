using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit.Abstractions;

namespace SpecFlowNetCorePOC
{
    [Binding]
    public class CalculatorFeatureSteps
    {
        public CalculatorFeatureSteps(ScenarioContext scenarioContext)
        {
            ITestOutputHelper output =  scenarioContext.ScenarioContainer.Resolve<ITestOutputHelper>();
            
            logger = new Logger(output);
        }
        Logger logger;
        int result = 0;
        int nextNumber = 0;
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            nextNumber = p0;
            logger.LogMessage("Number Entered:" + p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = result + nextNumber;
            Thread.Sleep(1000);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            
        }

        
      
        

    }
}
