using OpenQA.Selenium;
using TestRail_Core.Elements;

namespace TestRail_Core.Pages.ProjectPages;

public class ProjectTestSuitePage : BasePage
{
    private static readonly By SuccessMessageBy = By.ClassName("message-success");
    private static readonly By _addTestCaseButtonBy = By.Id("sidebar-cases-add");
    public ProjectTestSuitePage(IWebDriver driver) : base(driver) { }

    public override bool IsPageOpened() => throw new NotImplementedException();
    protected override string GetEndpoint() => throw new NotImplementedException();
    
    public IWebElement SuccessMessage => WaitsHelper.WaitForExists(SuccessMessageBy);
    public Button AddTestCaseButton => new(Driver, _addTestCaseButtonBy);
    
    public AddTestCasePage ClickAddTestCaseButton()
    {
        AddTestCaseButton.Click();
        return new AddTestCasePage(Driver);
    }
}