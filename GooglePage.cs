using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFb.Pages
{
    internal class GooglePage
    {
        IWebDriver driver;
        public GooglePage(IWebDriver d)
        { 
            this.driver = d;
            PageFactory.InitElements(driver,this);
        }
        [FindsBy(How=How.XPath,Using = "//*[@id='APjFqb']")]
        IWebElement txtSearch;

        [FindsBy(How = How.XPath, Using = "(//input[@name='btnK'])[1]")]
        IWebElement btnGoogleSearch;

        public void Enter_Text_in_Searchbox(string text)
        {
            txtSearch.SendKeys(text);
        }
      
        public void ClickSearchButten()
        {
            Thread.Sleep(10000);
            btnGoogleSearch.Click();
        }
    }
}
