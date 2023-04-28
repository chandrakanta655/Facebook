using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFb.Pages
{
    internal class FaceBookPage
    {
        IWebDriver driver;
        public FaceBookPage(IWebDriver d)
        {
            this.driver = d;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath,Using = "//*[@id='reg_form_box']/div[12]/a")]
        IWebElement lnkAlredyHaveAccount;

        [FindsBy(How = How.XPath, Using = "//*[@id='email']")]
        IWebElement txtUserId;

        [FindsBy(How = How.XPath, Using = "//*[@id='pass']")]
        IWebElement txtPassward;


        [FindsBy(How = How.XPath, Using = "//*[@id='loginbutton']")]
        IWebElement btnLogin;
        public void ClickalredyHaveaccount()
        {
            lnkAlredyHaveAccount.Click();
        }
       
        public void EnterUserId(string text)
        {
            txtUserId.SendKeys(text);
        }
        public void EnterPassward(string text)
        {
            txtPassward.SendKeys(text);
        }
        public void ClickEnterButten()
        {
            btnLogin.Click();
        }
    }
}
