using OpenQA.Selenium;
using TestRail_Core.Pages;
using TestRail_Core.Pages.ProjectPages;
using TestRail_Core.Pages.SectionPages;

namespace TestRail_Core.Steps;

public class BaseStep(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
    protected SectionBasePage? SectionBasePage { get; set; }
}