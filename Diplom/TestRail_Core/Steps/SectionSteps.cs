using OpenQA.Selenium;
using TestRail_Core.Models;
using TestRail_Core.Pages.SectionPages;
using System.Collections.ObjectModel;
using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestRail_Core.Steps;

public class SectionSteps(IWebDriver driver) : BaseStep(driver)
{
    public SectionBasePage AddSectionButton(Section _section)
    {
        SectionBasePage = new SectionBasePage(Driver, true);
        
        //создание новой секции для тестов
        SectionBasePage.AddSectionButton.Click();
        SectionBasePage.NameSection.SendKeys(_section.Name);
        SectionBasePage.DescriptionSection.SendKeys(_section.Description);
        
        //загрузка файла
        //SectionBasePage.AddFile();
        
        SectionBasePage.AddNewSectionButton.Click();
        
        return new SectionBasePage(Driver);
    }

    public string PopUpMessage()
    {
        SectionBasePage = new SectionBasePage(Driver, true);
        return SectionBasePage.PopUpMessage.GetAttribute("tooltip-text");
    }
    
    
    
}