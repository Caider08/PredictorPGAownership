using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PredictorPGAownership.Controllers
{
    public class ScraperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ScrapeFanShare()
        {
            string Test = "";
            string Table = "";
            List<string> Rows = new List<string>();
            List<string> Names = new List<string>();

            using (var driver = new ChromeDriver(@"c:\Users\caide\Code\PersonalC#Projects\PredictorPGAownership\PredictorPGAownership\bin\Debug\netcoreapp2.0")) 
       
            {
                driver.Navigate().GoToUrl("https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends");

                var userName = driver.FindElementById("email");
                var passWord = driver.FindElementById("password");
                var logIn = driver.FindElementById("submit");

                userName.SendKeys("caiderwaider@hotmail.com");
                passWord.SendKeys("DKscrape");
                logIn.Click();

                System.Threading.Thread.Sleep(25);

                //var contentWrap = driver.FindElementById("content-wrap");

                driver.Navigate().GoToUrl("https://www.fansharesports.com/golf/analytics/tags");

                //var main = driver.FindElementById("main");
                // Test = main.Text;

                var select100 = driver.FindElementByXPath("//*[@id='DataTables_Table_0_length']/label/select/option[4]");
                //*[@id="DataTables_Table_0_next"]
                select100.Click();

                System.Threading.Thread.Sleep(50);

                var tableGrab = driver.FindElementByXPath("//*[@id='DataTables_Table_0']/tbody");

                Table = tableGrab.TagName;

                System.Threading.Thread.Sleep(15);



                var tableRows = tableGrab.FindElements(By.TagName("tr"));

                foreach (IWebElement row in tableRows)
                {
                    //List<string> names = new List<string>();
                    List<IWebElement> tds = new List<IWebElement>();
                    tds = row.FindElements(By.TagName("td")).ToList();
                    Names.Add(tds[1].Text);


                }



                System.Threading.Thread.Sleep(15);

            }


            ViewBag.PlayerNames = Names;
            return View();
        }
    }
}