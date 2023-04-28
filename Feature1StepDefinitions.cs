using AutoFb.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AutoFb.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {

        IWebDriver driver;
        GooglePage googlePage;
        FaceBookPage faceBookPage;
        [Given(@"I open chrome browser")]
        public void GivenIOpenChromeBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\chand\\Desktop\\Pratice\\AutoFb\\AutoFb\\Drivers");
            googlePage = new GooglePage(driver);
            faceBookPage = new FaceBookPage(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
           
        }
        public void Teardown()
        {
            driver.Close();
        }
        [When(@"I put url as \(http//www\.facebook\.com\)")]
        public void WhenIPutUrlAsHttpWww_Facebook_Com()
        {
            googlePage.Enter_Text_in_Searchbox("facebook login");
        }


        [Then(@"I click search butten")]
        public void ThenIClickSearchButten()
        {
            googlePage.ClickSearchButten();
        }
        [Then(@"I click alredy have account")]
        public void ThenIClickAlredyHaveAccount()
        {
            faceBookPage.ClickalredyHaveaccount();
        }

        [Then(@"I click search result")]
        public void ThenIClickSearchResult()
        {
            IWebElement lnkFbSearchresult = driver.FindElement(By.XPath("//*[@id=\"tads\"]/div/div/div/div/div[1]/a/div[1]/span"));
            lnkFbSearchresult.Click();
        }


        [Then(@"I put user Id")]
        public void ThenIPutUserId()
        {
            faceBookPage.EnterUserId("chandrakanta655@gmail.com");
        }

        [Then(@"I put passward")]
        public void ThenIPutPassward()
        {
            faceBookPage.EnterPassward("");
        }

        [Then(@"I click enter butten")]
        public void ThenIClickEnterButten()
        {
            faceBookPage.ClickEnterButten();
        }
        
        
    }
}
