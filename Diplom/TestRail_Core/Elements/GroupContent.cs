﻿using OpenQA.Selenium;

namespace TestRail_Core.Elements;

public class GroupContent
{
    private UIElement _uiElement;
    private List<UIElement> _uiElements;
    private List<string> _texts;

    public GroupContent(IWebDriver driver, By by)
    {
        _uiElement = new UIElement(driver, by);
        _uiElements = new List<UIElement>();
        _texts = new List<string>();

        _uiElement.Click();
        foreach (var webElement in _uiElement.FindUIElements(By.XPath("//span[contains(@id,'sectionName-') and @class='title']")))
        {
            _uiElements.Add(webElement);
            _texts.Add(webElement.Text.Trim());
        }
        _uiElement.Click();
    }
    public List<string> GetText()
    {
            return _texts;
    }
}