using OpenQA.Selenium;
using TestRail_Core.Models;
using TestRail_Core.Pages.SectionPages;

namespace TestRail_Core.Steps;

public class SectionSteps(IWebDriver driver) : BaseStep(driver)
{
    public SectionBasePage AddSectionButton(Section _section)
    {
        SectionBasePage = new SectionBasePage(Driver, true);
        
        SectionBasePage.AddSectionButton.Click();
        SectionBasePage.NameSection.SendKeys(_section.Name);
        SectionBasePage.DescriptionSection.SendKeys(_section.Description);
        SectionBasePage.AddNewSectionButton.Click();
        
        return new SectionBasePage(Driver);
    }
}