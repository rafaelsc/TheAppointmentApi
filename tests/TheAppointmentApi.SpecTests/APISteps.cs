using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;
using FluentAssertions;
using TechTalk.SpecFlow;
using TheAppointmentApi.Data;
using TheAppointmentApi.Service;
using TheAppointmentApi.WebApi.Controllers;
using TheAppointmentApi.WebApi.Models;

namespace TheAppointmentApi.SpecTests
{
    [Binding]
    public class APISteps
    {
        private const string Token = "token";

        public APISteps()
        {
            AppointmentsController = new AppointmentsController(new SlotService(new AppointmentRepository())); //TODO: DI
        }

        public AppointmentsController AppointmentsController { get; set; }

        public DateTime AppointmentDate { get; set; }
        public int NumOfFreeSlots { get; set; }
        public AppointmentGetResultModel ApiGetResult { get; set; }


        [Given(@"a future date, and the TheAppointmentApi have (.*) free slots that day\.")]
        public void GivenAFutureDateAndTheTheAppointmentApiHaveFreeSlotsThatDay_(int numOfFreeSlots)
        {
            AppointmentDate = DateTime.Now.AddDays(5);
            NumOfFreeSlots = numOfFreeSlots;
        }
        
        [Given(@"a past date, and the TheAppointmentApi have (.*) free slots that day\.")]
        public void GivenAPastDateAndTheTheAppointmentApiHaveFreeSlotsThatDay_(int numOfFreeSlots)
        {
            AppointmentDate = DateTime.Now.AddDays(-5);
            NumOfFreeSlots = numOfFreeSlots;
        }
        
        [When(@"restfull GET request is done to the API endpoint")]
        public void WhenRestfullGETRequestIsDoneToTheAPIEndpoint()
        {
            ApiGetResult = AppointmentsController.Get(Token, AppointmentDate);
        }


        [Then(@"a list of all (.*) free same slots should be return\.")]
        public void ThenAListOfAllFreeSameSlotsShouldBeReturn_(int p0)
        {
            ApiGetResult.Should().NotBeNull();
            ApiGetResult.Slots.Should().NotBeNull();
            ApiGetResult.Slots.Should().NotBeEmpty();
            ApiGetResult.Slots.Count().Should().Be(NumOfFreeSlots);
        }
        
        [Then(@"a Bad Request error should return")]
        public void ThenABadRequestErrorShouldReturn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
