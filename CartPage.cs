using NUnit.Framework;
using OpenQA.Selenium;

public class CartPage
{
    private readonly IWebDriver driver;

    public CartPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void NavigateToCart()
    {
        IWebElement cartIcon = driver.FindElement(By.Id("nav-cart"));
        cartIcon.Click();
    }

    public void ValidateCartItem(string expectedItemName, string expectedItemAmount)
    {
        IWebElement cartItemName = driver.FindElement(By.CssSelector(".sc-product-title"));
        IWebElement cartItemAmount = driver.FindElement(By.CssSelector(".sc-product-price"));

        Assert.AreEqual(expectedItemName, cartItemName.Text.Trim());
        Assert.AreEqual(expectedItemAmount, cartItemAmount.Text.Trim());
    }
}

