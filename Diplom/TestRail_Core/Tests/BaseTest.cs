using NUnit.Allure.Core;
using OpenQA.Selenium;
using TestRail_Core.Core;
using TestRail_Core.Helpers.Configuration;
using TestRail_Core.Models;
using TestRail_Core.Steps;

namespace TestRail_Core.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
[AllureNUnit]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }

    protected NavigationSteps _navigationSteps;
    protected ProjectSteps _projectSteps;
    protected SectionSteps _sectionSteps;

    protected User? Admin { get; private set; }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;

        _navigationSteps = new NavigationSteps(Driver);
        _projectSteps = new ProjectSteps(Driver);
        _sectionSteps = new SectionSteps(Driver);

        Admin = Configurator.Admin;
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}