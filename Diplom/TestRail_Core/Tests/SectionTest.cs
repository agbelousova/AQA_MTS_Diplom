using TestRail_Core.Models;

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
    }
}