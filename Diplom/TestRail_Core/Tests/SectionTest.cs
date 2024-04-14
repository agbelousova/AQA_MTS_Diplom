using TestRail_Core.Models;
using TestRail_Core.Pages.SectionPages;

namespace TestRail_Core.Tests;

public class SectionTest: BaseTest
{
    [Test]
    public void SuccessfulAddSectionTest()
    {
        _navigationSteps.SuccessfulLogin(Admin);

        Section section = new Section()
        {
            Name = "New Test Section" + new Random().Next(1, 100),
            Description = "Description 1"
        };

        var sectionBasePage = _sectionSteps.AddSectionButton(section);
        Assert.That(sectionBasePage.FindNewSection(section.Name), Is.EqualTo(true));
        
        Console.WriteLine(_sectionSteps.PopUpMessage()); 
    }

    [Test]
    public void PopUpMessageTest()
    {
        _navigationSteps.SuccessfulLogin(Admin);
        
        Assert.That(_sectionSteps.PopUpMessage(), Is.EqualTo("Opens a print view of this test case repository."));
    }

    [Test]
    public void DeleteSection()
    {
        _navigationSteps.SuccessfulLogin(Admin);

        Section section = new Section()
        {
            Name = "New Test Section" + new Random().Next(1, 100),
            Description = "Description 1"
        };

        var sectionBasePage = _sectionSteps.AddSectionButton(section);
        sectionBasePage.DeleteSection(section.Name);
    }
}