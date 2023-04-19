using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using MarsQA.Pages;

namespace MarsQA.Utilities
{
    public class CommonDriver 
    {
        public IWebDriver driver = new ChromeDriver(@"C:/Users/shwet/OneDrive/Desktop/February2023");
        [AfterScenario]
        public void CleanUp()
        {
            driver.Dispose();
        }
    }
}
