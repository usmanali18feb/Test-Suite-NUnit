 **# Amazon Shopping Automation**

**This repository contains a simple automation script for performing a shopping scenario on the Amazon website using Selenium WebDriver and NUnit Framework.**

## Prerequisites

- .NET Core SDK
- ChromeDriver (Ensure the executable is in your system's PATH)

## Setup

1. Clone the repository:

   ```bash
   git clone https://github.com/usmanali18feb/Test-Suite-NUnit
   cd AmazonShoppingAutomation
   ```

2. Build the solution:

   ```bash
   dotnet build
   ```

## Running the Tests

```bash
dotnet test
```

This will execute the automated test script located in the `AmazonShoppingSteps.cs` file.

## Test Scenario

The automation script performs the following steps:

1. **Given I am on the Amazon website**
   - Opens the Chrome browser and navigates to [https://www.amazon.com/](https://www.amazon.com/).
2. **When I search for "searchText"**
   - Searches for the specified text using the Amazon search bar.
3. **When I add the corresponding item to the cart**
   - Locates the specified item on the search results page and adds it to the shopping cart.
4. **Then I navigate to the cart**
   - Clicks on the cart icon to navigate to the shopping cart.
5. **Then validate the correct item and amount is displayed**
   - Validates that the correct item and amount are displayed on the shopping cart page.

## Test Environment Configuration

The test environment is configured in the `AmazonShoppingSteps.cs` file. The ChromeDriver path is set, and the necessary WebDriver is initialized for the script to run successfully.

## Dependencies

- NUnit Framework
- Selenium WebDriver

## Cleanup

The browser is closed automatically after each test scenario execution using the `AfterScenario` attribute in the `CloseBrowser` method.
