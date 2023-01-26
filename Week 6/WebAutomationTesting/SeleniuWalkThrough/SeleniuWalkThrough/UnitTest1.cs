
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniuWalkThrough;

public class Tests
{
    [Category("Happy")]
    [Test]
    public void GivenIAmOnHomepage_WhenIEnterValidEmailAndPassword_ThenIShouldLandOnInventoryPage()
    {
        var options = new ChromeOptions();
        options.AddArgument("headless");
        //use the web driver
        using (IWebDriver driver = new ChromeDriver(options))
        {

            //navigate to saucedemo.com
            driver.Navigate().GoToUrl("http://saucedemo.com");

            //grab username field
            var userNameField = driver.FindElement(By.Id("user-name"));

            //enter username into it
            userNameField.SendKeys("standard_user");

            //grab password field
            var passwordField = driver.FindElement(By.Id("password"));

            //enter password into it
            passwordField.SendKeys("secret_sauce");

            //press submit
            driver.FindElement(By.Id("login-button")).Click();

            Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }
    }

    [Category("Sad")]
    [Test]
    public void GivenIAmOnHomepage_WhenIEnterInvalidEmail_ThenIShouldStayOnHomepage()
    {
        var options = new ChromeOptions();
        options.AddArgument("headless");
        using (IWebDriver driver = new ChromeDriver(options))
        {

            driver.Navigate().GoToUrl("http://saucedemo.com");

            var userNameField = driver.FindElement(By.Id("user-name"));
            var passwordField = driver.FindElement(By.Id("password"));
            var submitButton = driver.FindElement(By.Id("login-button"));
            
            userNameField.SendKeys("invalid_user");
            passwordField.SendKeys("secret_sauce");
            submitButton.Click();

            Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/"));
        }
    }
    
    [Category("Sad")]
    [Test]
    public void GivenIAmOnHomepage_WhenIEnterInvalidEmail_ThenErrorMessageAppears()
    {
        var options = new ChromeOptions();
        options.AddArgument("headless");
        using (IWebDriver driver = new ChromeDriver(options))
        {

            driver.Navigate().GoToUrl("http://saucedemo.com");

            var userNameField = driver.FindElement(By.Id("user-name"));
            var passwordField = driver.FindElement(By.Id("password"));
            var submitButton = driver.FindElement(By.Id("login-button"));
            var errorMessage = driver.FindElement(By.XPath("//*[@id=\"login_button_container\"]/div/form/div[3]"));

            userNameField.SendKeys("invalid_user");
            passwordField.SendKeys("secret_sauce");
            submitButton.Click();

            Assert.That(errorMessage.Text, Does.Contain("Username and password do not match"));
        }
    }
}