using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            var e = driver.FindElement(By.XPath("(//*[@class='card-body'])[1]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", e);
            e.Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[text()='Text Box']")).Click();
            driver.FindElement(By.XPath("//*[@placeholder='Full Name']")).SendKeys("Antony Mac");
            driver.FindElement(By.XPath("//*[@placeholder='name@example.com']")).SendKeys("immacantony@gmail.com");
            driver.FindElement(By.XPath("//*[@placeholder='Current Address']")).SendKeys("Santa Ana, USA");
            driver.FindElement(By.XPath("//*[@id='permanentAddress']")).SendKeys("Santa Ana, USA");
            var click = driver.FindElement(By.XPath("//button[@id=\"submit\"]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", click);
            click.Click();
            Thread.Sleep(2000);
            driver.Quit();

        }
    }
}