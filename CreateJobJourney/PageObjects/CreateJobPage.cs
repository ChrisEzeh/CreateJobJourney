using CreateJobJourney.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CreateJobJourney.PageObjects
{
    class CreateJobPage
    {
        IWebDriver driver;


        public CreateJobPage()
        {
            driver = BaseTest.driver;
        }
        
        public By letsGo = By.CssSelector(".btn-green");
        public By password = By.CssSelector("input[name='password'");
        public By email = By.CssSelector("input[name='email']");
        public By jobTitle = By.CssSelector("input[name='title']");
        public By jobCategory = By.CssSelector("[name='categoryId']");
        public By description = By.CssSelector("[name='description']");
        public By workingPattern = By.XPath("//*[@id='app']/div/div[2]/div/div/div[1]/div/div[2]/div/div[1]/div[1]/div[2]/div[2]/div/div[2]/div/div[1]");
        public By dressCode = By.CssSelector("[name='dressCode']");
        public By experienceLevel = By.CssSelector("[name='experience']");
        public By skillsNeeded = By.XPath("//*[@id='app']/div/div[2]/div/div/div[1]/div/div[2]/div/div[1]/div[1]/div[4]/div/div/div/ul/li[1]");
        public By contactName = By.CssSelector("div.col-xs-8 > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div > input");
        public By contactPhone = By.CssSelector(" div:nth-child(2) > div:nth-child(2) > div:nth-child(2) > div > div > input");
        public By arrivalInstrution = By.CssSelector(" div.col-xs-8 > div:nth-child(2) > div:nth-child(2) > div:nth-child(2) > div > div > input");
        public By next = By.CssSelector("span.wizard-btn__name");
        
        public By addShift = By.XPath("//*[@id='app']/div/div[2]/div/div/div[1]/div/div[2]/div/div/div[1]/div[2]/button");
        public By selectDate = By.CssSelector("div > div.react-datepicker > div:nth-child(3) > div.react-datepicker__month > div:nth-child(4) > div:nth-child(7)");
        public By next2= By.CssSelector("btn-next");
        public By start = By.CssSelector("startTime");
        public By finish = By.CssSelector("endTime");
        public By workers = By.CssSelector("workersRequired");
        public By next3 = By.CssSelector("btn-next");
        public By addMore = By.CssSelector("btn wizard-btn__add ");
        public By anotherDate = By.CssSelector("#modal-root > div > div > div > div > div > div.react-datepicker > div:nth-child(4) > div.react-datepicker__month > div:nth-child(6) > div:nth-child(1)");
        public By next4 = By.CssSelector("btn-next");
        public By anotherStartTime = By.CssSelector("startTime");
        public By anotherFinishTime = By.CssSelector("endTime");
        public By workers2 = By.CssSelector("workersRequired");
        public By next5 = By.CssSelector("btn-next");
        public By edit = By.CssSelector("icon flaticon-create-new-pencil-button");
        public By changeFinishTime = By.CssSelector("endTime");
        public By changeWorkers = By.CssSelector("workersRequired");
        public By next6 = By.CssSelector("btn-next");
        public By delete = By.CssSelector("schedule__cell schedule__cell_del");
        public By doneAddingShift = By.CssSelector("#app > div > div.wrapper > div > div > div.view > div > div.container.container_mbn > div > div > div.wizard-btn__grp.wizard-btn__grp_thb > button.btn.wizard-btn__next > span.wizard-btn__name");
        

        public void Naviggate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void Email(string emailtxt)
        {
            
            driver.FindElement(email).SendKeys(emailtxt);
        }
        public void Password(string passwordtxt)
        {
            driver.FindElement(password).SendKeys(passwordtxt);
        }
        public void LetSGo()
        {
            driver.FindElement(letsGo).Click();
        }

        public void JobTitle(string title)
        {
            Thread.Sleep(5000);
            driver.FindElement(jobTitle).SendKeys(title);
        }
        public void JobCaterory()
        {
            
            SelectElement select = new SelectElement(driver.FindElement(jobCategory));
            select.SelectByValue("cd725ecc-0b40-11e8-bb63-f3708876e4c1");
        }

        public void Description(string descriptiontxt)
        {
            driver.FindElement(description).SendKeys(descriptiontxt);
        }

        public void WorkingPattern(string patterntxt)
        {
            driver.FindElement(workingPattern).SendKeys(patterntxt);
        }

        public void DressCode(string dresstxt)
        {
            driver.FindElement(dressCode).SendKeys(dresstxt);
        }

        public void ExperienceLevel()
        {
            SelectElement select = new SelectElement(driver.FindElement(experienceLevel));
            select.SelectByValue("None");
        }

        public void SkillsNeeded()
        {
            Thread.Sleep(5000);
            driver.FindElement(skillsNeeded).Click();
        }

        public void ContactName(string nametxt)
        {
            driver.FindElement(contactName).SendKeys(nametxt);
        }

        public void ContactPhone(string phonetxt)
        {
            driver.FindElement(contactPhone).SendKeys(phonetxt);
        }

        public void ArrivalInstruction(string arrivaltxt)
        {
            driver.FindElement(arrivalInstrution).SendKeys(arrivaltxt);
        }

        public void Next()
        {
            driver.FindElement(next).Click();
        }

        public void AddedShift()
        {
            driver.FindElement(addShift).Click();
        }

        public void SelectDate()
        {
            IWebElement txtBxDatePicker = driver.FindElement(selectDate);
            txtBxDatePicker.SendKeys("20/12/2021");
            
        }

        public void Next2()
        {
           driver.FindElement(next2).Click();
        }

        public void Start(string starttxt)
        {
            driver.FindElement(start).SendKeys(starttxt);
        }

        public void Finish(string finishtxt)
        {
            driver.FindElement(finish).SendKeys(finishtxt);
        }

        public void Workers(string workerstxt)
        {
            driver.FindElement(workers).SendKeys(workerstxt);
        }

        public void Next3()
        {
            driver.FindElement(next3).Click();
        }

        public void AddMore()
        {
            driver.FindElement(addMore).Click();
        }

        public void AnotherDate(string datetxt)
        {
            IWebElement txtBxDatePicker = driver.FindElement(anotherDate);
            txtBxDatePicker.SendKeys("30/12/2021");
            
        }

        public void Next4()
        {
            driver.FindElement(next4).Click();
        }

        public void AnotherStartTime(string startTimetxt)
        {
            driver.FindElement(anotherStartTime).SendKeys(startTimetxt);
        }

        public void AnotherFinishTime(string finishTimetxt)
        {
            driver.FindElement(anotherFinishTime).SendKeys(finishTimetxt);
        }

        public void Workers2(string workers2txt)
        {
            driver.FindElement(workers2).SendKeys(workers2txt);
        }

        public void Next5()
        {
            driver.FindElement(next5).Click();
        }

        public void Edit()
        {
            driver.FindElement(edit);
        }

        public void ChangeFinishTime(string changetxt)
        {
            driver.FindElement(changeFinishTime).SendKeys(changetxt);
        }

        public void ChangeWorkers(string changeWorkertxt)
        {
            driver.FindElement(next).SendKeys(changeWorkertxt);
        }

        public void Next6()
        {
           driver.FindElement(next6).Click();
        }

        public void Delete()
        {
            driver.FindElement(delete).Click();
        }

        public void DoneAddingShift()
        {
            driver.FindElement(doneAddingShift).Click();
        }

        public bool WherePageIsDisplayed()
        {
            Thread.Sleep(5000);
            return driver.Url.Contains("/where");
        }

        public bool SubmitPageIsDisplayed()
        {
            return driver.Url.Contains("/submit");
        }




























    }
}
