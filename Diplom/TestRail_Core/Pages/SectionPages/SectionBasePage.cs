using OpenQA.Selenium;
using TestRail_Core.Elements;

namespace TestRail_Core.Pages.SectionPages;

public class SectionBasePage : BasePage
{
    private static string END_POINT = "index.php?/suites/view/1";

    //описание элементов
    private static readonly By AddSectionButtonBy = By.Id("addSection");
    private static readonly By TitleLabelBy = By.ClassName("page_title");
    private static readonly By NameSectionBy = By.Id("editSectionName");
    private static readonly By DescriptionSectionBy = By.Id("editSectionDescription_display");
    private static readonly By AddNewSectionButtonBy = By.Id("editSectionSubmit");
    private static readonly By SectionNewTitleBy = By.XPath("//span[contains(@id,'sectionName-') and @class='title']");
    public SectionBasePage(IWebDriver driver) : base(driver)
    {
    }
    public SectionBasePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    protected override string GetEndpoint() => END_POINT;
    public override bool IsPageOpened() => TitleLabel.Text.Trim().Equals("Test Cases");

    public UIElement TitleLabel => new(Driver, TitleLabelBy);
    public Button AddSectionButton => new(Driver, AddSectionButtonBy);
    public UIElement NameSection => new(Driver, NameSectionBy);
    public UIElement DescriptionSection => new(Driver, DescriptionSectionBy);
    public Button AddNewSectionButton => new(Driver, AddNewSectionButtonBy);
    public GroupContent SectionNewTitle => new(Driver, SectionNewTitleBy);

    //методы
    public bool FindNewSection(string nameSection)
    {
        bool flag = false;
        foreach (var text in SectionNewTitle.GetText())
        {
            if (text == nameSection)
            {
                flag = true;
                Console.WriteLine(text);
            }
        }

        return flag;
    }
}