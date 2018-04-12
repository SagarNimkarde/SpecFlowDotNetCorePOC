using System;
using TechTalk.SpecFlow;

namespace SpecFlowDotNetCoreNunitPOC
{
    [Binding]
    public class CalcAddSteps:Cal
    {
        [Given(@"I have entered (.*) into the calculator Nunit")]
        public void GivenIHaveEnteredIntoTheCalculatorNunit(int p0)
        {
            Calc.SetFirstNumber(firstNumber).GetAwaiter().GetResult();
        }
        
        [Given(@"I have also entered (.*) into the calculator Nunit")]
        public void GivenIHaveAlsoEnteredIntoTheCalculatorNunit(int p0)
        {
            Calc.SetSecondNumber(secondNumber).GetAwaiter().GetResult();
        }
        
        [When(@"I press add Nunit")]
        public void WhenIPressAddNunit()
        {
            Calc.Add().GetAwaiter().GetResult();
            Output.WriteLine("Add Complete");
        }
        
        [Then(@"the result should be (.*) on the screen Nunit")]
        public void ThenTheResultShouldBeOnTheScreenNunit(int p0)
        {
            
        }
    }
}
