using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

[Binding]
public class AmazonShoppingSteps
{
    private readonly IWebDriver driver;
    private readonly AmazonHomePage amazonHomePage;
    private readonly ProductDetailsPage productDetailsPage;
    private readonly CartPage cartPage;

    public AmazonShoppingSteps()
    {
        string chromeDriverPath = "/home/qa/Pictures/MyTestProject/";
        ChromeOptions options = new ChromeOptions();
        driver = new ChromeDriver(chromeDriverPath, options);

        amazonHomePage = new AmazonHomePage(driver);
        productDetailsPage = new ProductDetailsPage(driver);
        cartPage = new CartPage(driver);
    }

    [Given(@"I am on the Amazon website")]
    public void GivenIAmOnTheAmazonWebsite()
    {
        amazonHomePage.NavigateToHomePage("https://www.amazon.com/");
    }

    [When(@"I search for ""(.*)""")]
    public void WhenISearchFor(string searchText)
    {
        amazonHomePage.SearchForItem(searchText);
         // Replace "TP-Link AC1200 Gigabit WiFi Router (Archer A6)" with the actual item name
    string itemName = "TP-Link AC1200 Gigabit WiFi Router (Archer A6)";
    amazonHomePage.ClickOnFirstSearchResult(itemName);
    }

    [When(@"I add the corresponding item to the cart")]
    public void WhenIAddTheCorrespondingItemToTheCart()
    {
        productDetailsPage.ClickOnAddToCart();
    }

    [Then(@"I navigate to the cart")]
    public void ThenINavigateToTheCart()
    {
        cartPage.NavigateToCart();
    }

    [Then(@"validate the correct item and amount is displayed")]
    public void ThenValidateTheCorrectItemAndAmountIsDisplayed()
    {
        cartPage.ValidateCartItem("TP-Link AC1200 Gigabit WiFi Router (Archer A6) - Dual Band…", "$44.99");
    }

    [AfterScenario]
    public void CloseBrowser()
    {
        driver.Quit();
    }
}
