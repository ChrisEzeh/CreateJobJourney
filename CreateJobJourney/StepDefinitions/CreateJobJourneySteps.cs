using CreateJobJourney.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CreateJobJourney.StepDefinitions
{
    [Binding]
    public class CreateJobJourneySteps
    {



        CreateJobPage createJobPage = new CreateJobPage();


        [Given(@"user navigates to ""(.*)""")]
        public void GivenUserNavigatesTo(string url)
        {
            createJobPage.Naviggate(url);
        }
        [When(@"user enters email ""(.*)""")]
        public void WhenUserEntersEmail(string emailtxt)
        {
            createJobPage.Email(emailtxt);
        }


        [When(@"user enters password ""(.*)""")]
        public void WhenUserEntersPassword(string passwordtxt)
        {
            createJobPage.Password(passwordtxt);
        }
        [When(@"user clicks on let'sGo")]
        public void WhenUserClicksOnLetSGo()
        {
            createJobPage.LetSGo();
        }



        [When(@"user enters job title ""(.*)""")]
        public void WhenUserEntersJobTitle(string titletxt)                                 
        {
            createJobPage.JobTitle(titletxt);
        }
        
        [When(@"user selects job category")]
        public void WhenUserSelectsJobCategory()
        {
            createJobPage.JobCaterory();
        }
        
        [When(@"user enters description ""(.*)""")]
        public void WhenUserEntersDescription(string descriptiontxt)
        {
            createJobPage.Description(descriptiontxt);
        }
        
        [When(@"user enters dress code ""(.*)""")]
        public void WhenUserEntersDressCode(string dresstext)
        {
            createJobPage.DressCode(dresstext);
        }


        [When(@"user selects experience level")]
        public void WhenUserSelectsExperienceLevel()
        {
            createJobPage.ExperienceLevel();
        }
        
        [When(@"user selects skills needed for the job")]
        public void WhenUserSelectsSkillsNeededForTheJob()
        {
            createJobPage.SkillsNeeded();
        }
        
        [When(@"user enters contact name ""(.*)""")]
        public void WhenUserEntersContactName(string nametxt)
        {
            createJobPage.ContactName(nametxt);
         
        }
        [When(@"user enter contact phone number ""(.*)""")]
        public void WhenUserEnterContactPhoneNumber(string phonetxt)
        {
            createJobPage.ContactPhone(phonetxt);
        }

        [When(@"user enters arrival instruction ""(.*)""")]
        public void WhenUserEntersArrivalInstruction(string instructiontxt)
        {
            createJobPage.ArrivalInstruction(instructiontxt);
        }
        
        [When(@"user clicks next")]
        public void WhenUserClicksNext()
        {
            createJobPage.Next();
        }
        
        [When(@"user clicks on add shift")]
        public void WhenUserClicksOnAddShift()
        {
            createJobPage.AddedShift();
        }
        
        [When(@"user selects date")]
        public void WhenUserSelectsDate()
        {
            createJobPage.SelectDate();
        }
        
        [When(@"user clicks on next")]
        public void WhenUserClicksOnNext()
        {
            createJobPage.Next2();
        }
        
        [When(@"user enters start time ""(.*)""")]
        public void WhenUserEntersStartTime(string timetxt)
        {
            createJobPage.Start(timetxt);
        }
        
        [When(@"user enters finish time ""(.*)""")]
        public void WhenUserEntersFinishTime(string finishtimetxt)
        {
            createJobPage.Finish(finishtimetxt);
        }
        
        [When(@"user enters number of workers ""(.*)""")]
        public void WhenUserEntersNumberOfWorkers(string workertxt)
        {
            createJobPage.Workers(workertxt);
        }
        
        [When(@"user click next")]
        public void WhenUserClickNext()
        {
            createJobPage.Next3();
        }
        
        [When(@"user clicks on add more shift")]
        public void WhenUserClicksOnAddMoreShift()
        {
            createJobPage.AddMore();
        }
        
        [When(@"user selects another date")]
        public void WhenUserSelectsAnotherDate(string txt)
        {
            createJobPage.AnotherDate(txt);
        }
        
        [When(@"user enter second start time ""(.*)""")]
        public void WhenUserEnterSecondStartTime(string timetxt)
        {
            createJobPage.AnotherStartTime(timetxt);
        }
        
        [When(@"user enters second finish time ""(.*)""")]
        public void WhenUserEntersSecondFinishTime(string timetxt)
        {
            createJobPage.AnotherFinishTime(timetxt);

        }
        
        [When(@"user clicks on edit")]
        public void WhenUserClicksOnEdit()
        {
            createJobPage.Edit();
        }
        
        [When(@"user change finish time to ""(.*)""")]
        public void WhenUserChangeFinishTimeTo(string timetxt)
        {
            createJobPage.ChangeFinishTime(timetxt);
        }
        
        [When(@"user change workers to ""(.*)""")]
        public void WhenUserChangeWorkersTo(string txt)
        {
            createJobPage.ChangeWorkers(txt);
        }
        
        [When(@"user clicks on delete")]
        public void WhenUserClicksOnDelete()
        {
            createJobPage.Delete();
        }
        
        [When(@"user clicks done adding shift")]
        public void WhenUserClicksDoneAddingShift()
        {
            createJobPage.DoneAddingShift();
        }
        
        [Then(@"where page is displayed")]
        public void ThenWherePageIsDisplayed()
        {
            Assert.IsTrue(createJobPage.WherePageIsDisplayed());
        }
        
        [Then(@"subnit page is displayed")]
        public void ThenSubnitPageIsDisplayed()
        {
            Assert.IsTrue(createJobPage.SubmitPageIsDisplayed());
        }
    }
}
