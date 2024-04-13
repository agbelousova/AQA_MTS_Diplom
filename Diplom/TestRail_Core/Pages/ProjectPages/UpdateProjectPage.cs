﻿using OpenQA.Selenium;

namespace TestRail_Core.Pages.ProjectPages;

public class UpdateProjectPage : ProjectBasePage
{
    private const string END_POINT = "index.php?/admin/projects/add";

    // Описание элементов
    private static readonly By SaveButtonBy = By.Id("name");

    public UpdateProjectPage(IWebDriver driver) : base(driver)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }
    public override bool IsPageOpened()
    {
        throw new NotImplementedException();
    }
    
    // Атомарные Методы
    public IWebElement SaveButton => WaitsHelper.WaitForExists(SaveButtonBy);
}