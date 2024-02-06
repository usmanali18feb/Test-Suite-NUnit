using OpenQA.Selenium;

public class ProductDetailsPage
{
    private readonly IWebDriver driver;

    public ProductDetailsPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void ClickOnAddToCart()
    {
        IWebElement addToCartButton = driver.FindElement(By.Id("add-to-cart-button"));
        addToCartButton.Click();
    }
}

