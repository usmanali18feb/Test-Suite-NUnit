using OpenQA.Selenium;

public class AmazonHomePage
{
    private readonly IWebDriver driver;

    public AmazonHomePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void NavigateToHomePage(string url)
    {
        driver.Navigate().GoToUrl(url);
    }

    public void SearchForItem(string searchText)
    {
        IWebElement searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));
        searchBox.SendKeys(searchText);
        searchBox.SendKeys(Keys.Return);
    }
       public void ClickOnFirstSearchResult(string itemName)
    {
        // Constructing the XPath with dynamic item name
        string xpath = $"//a[contains(., '{itemName}')]";
        IWebElement firstSearchResult = driver.FindElement(By.XPath(xpath));
        firstSearchResult.Click();
    }
}

