using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarsQA.Pages
{
    public class LoginPage
    {
        public void LoginAction(IWebDriver driver)
        {
            //Open chrome browser
            
            driver.Manage().Window.Maximize();

            //Launch local host :5000
            driver.Navigate().GoToUrl("http://localhost:5000");
            Thread.Sleep(1000);

            //Identify the signin button and click on it 
            IWebElement SigninLink = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SigninLink.Click();

            //Identify the email address textbox and enter valid registered emailid 
            IWebElement emailidTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailidTextbox.SendKeys("shwethanirmala88@gmail.com");
            Thread.Sleep(1000);

            //Identify the password textbox and enter the valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("Invictus@88");
            Thread.Sleep(1000);

            //Identify the remember me check box and click on it 
            IWebElement remembermeCheckbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input"));
            remembermeCheckbox.Click();
            Thread.Sleep(1000);

            //Identify the login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(3000);

        }

    }
}
