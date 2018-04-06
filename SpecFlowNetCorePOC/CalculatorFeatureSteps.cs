﻿using System;
using TechTalk.SpecFlow;

namespace SpecFlowNetCorePOC
{
    [Binding]
    public class CalculatorFeatureSteps
    {
        int result = 0;
        int nextNumber = 0;
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            nextNumber = p0;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = result + nextNumber;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            
        }
    }
}
