using TechTalk.SpecFlow;

namespace SpecFlow_xUnit
{
  namespace MyNamespace
  {
    [Binding]
    public class StepDefinitions
    {
      private readonly ScenarioContext _scenarioContext;

      public StepDefinitions(ScenarioContext scenarioContext)
      {
        _scenarioContext = scenarioContext;
      }
      [Given(@"a parameter named (.*)")]
      public void GivenAParameterNamed(string name)
      {
        
      }
        
      [When(@"testrun is started with filter")]
      public void WhenTestrunIsStartedWithFilter()
      {
      }
        
      [Then(@"the correct tests are executed")]
      public void ThenTheCorrectTestsAreExecuted()
      {
      }
    }
  }
}