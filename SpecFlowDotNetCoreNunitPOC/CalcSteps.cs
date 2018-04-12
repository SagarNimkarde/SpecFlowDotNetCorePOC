using Xunit.Abstractions;

namespace SpecFlowDotNetCoreNunitPOC
{
    public class CalcSteps
    {
        protected Calc Calc;
        protected ITestOutputHelper Output;

        public CalcSteps(CalcContext calcContext)
        {
            Calc = calcContext.Calc;
            Output = calcContext.Output;
        }
    }
}