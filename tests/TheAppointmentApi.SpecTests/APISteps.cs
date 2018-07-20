using System;
using TechTalk.SpecFlow;

namespace TheAppointmentApi.SpecTests
{
    [Binding]
    public class APISteps
    {
        [Given(@"a future date, and the TheAppointmentApi have (.*) free slots that day\.")]
        public void GivenAFutureDateAndTheTheAppointmentApiHaveFreeSlotsThatDay_(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a past date, and the TheAppointmentApi have (.*) free slots that day\.")]
        public void GivenAPastDateAndTheTheAppointmentApiHaveFreeSlotsThatDay_(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"restfull GET request is done to the API endpoint")]
        public void WhenRestfullGETRequestIsDoneToTheAPIEndpoint()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a list of all (.*) free same slots should be return\.")]
        public void ThenAListOfAllFreeSameSlotsShouldBeReturn_(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a Bad Request error should return")]
        public void ThenABadRequestErrorShouldReturn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
