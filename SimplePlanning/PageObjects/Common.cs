using Core.Helpers;
using Core.WebElements;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace SimplePlanning.PageObjects
{
	public class Common
	{
		public TextElement PageHeader = new TextElement(By.XPath("//h1[contains(@class,'page-header')]"));
		public TextElement PageHeaderWithBackLink = new TextElement(By.XPath("//h1[contains(@class,'page-header')]//span[not(@class)]"));
		public TextElement ModalTitle= new TextElement(By.XPath("//h4[@id='modal-title']"));
		public TextElement PopoverTitle = new TextElement(By.XPath("//h3[@class='popover-title']"));
		public TextElement Table = new TextElement(By.XPath("//table[@class='table']"));
		public ClickElement DoneButtonOnModal = new ClickElement(By.XPath("//div[@class='modal-footer']//button[text()='Done']"));
		public ClickElement CloseIconOnModal = new ClickElement(By.XPath("//div[@class='modal-dialog']//span[contains(@class,'ei-close')]"));
		public ClickElement CancelButtonOnPopover = new ClickElement(By.XPath("//*[@class='popover-footer']//button[text()='Cancel']"));
		public ClickElement SaveButtonOnPopover = new ClickElement(By.XPath("//*[@class='popover-footer']//button[text()='Save']"));
		public ClickElement CloseIconOnPopover = new ClickElement(By.XPath("//div[@class='popover-container']//span[contains(@class,'ei-close')]"));

		public List<string> GetTableColumns => Table.Items(By.XPath("./thead//th"));

		public void VerifyPageHeader(string expectedHeader)
		{
			Assert.That(PageHeader.GetText.Equals(expectedHeader));
		}
		public void VerifyPageWithBackLinkHeader(string expectedHeader)
		{
			PageHeaderWithBackLink.WaitForDisplayed(Timeouts.Default);
			Assert.That(PageHeaderWithBackLink.GetText.Equals(expectedHeader));
		}
		public void VerifyModalTitle(string expectedTitle)
		{
			ModalTitle.WaitForDisplayed(Timeouts.Default);
			Assert.That(ModalTitle.GetText.Equals(expectedTitle));
		}

		public void ClickDoneOnModal()
		{
			ModalTitle.WaitForDisplayed(Timeouts.Default);
			DoneButtonOnModal.Click();
			ModalTitle.WaitForNotDisplayed(Timeouts.Default);
		}
		public void ClickCloseModal()
		{
			ModalTitle.WaitForDisplayed(Timeouts.Default);
			CloseIconOnModal.Click();
			ModalTitle.WaitForNotDisplayed(Timeouts.Default);
		}
		public void VerifyPopoverTitle(string expectedTitle)
		{
			PopoverTitle.WaitForDisplayed(Timeouts.Default);
			Assert.That(PopoverTitle.GetText.Equals(expectedTitle));
		}
		public void ClickSaveOnPopover()
		{
			PopoverTitle.WaitForDisplayed(Timeouts.Default);
			SaveButtonOnPopover.Click();
			PopoverTitle.WaitForNotDisplayed(Timeouts.Default);
		}
		public void ClickCancelOnPopover()
		{
			PopoverTitle.WaitForDisplayed(Timeouts.Default);
			CancelButtonOnPopover.Click();
			PopoverTitle.WaitForNotDisplayed(Timeouts.Default);
		}
		public void ClickClosePopover()
		{
			PopoverTitle.WaitForDisplayed(Timeouts.Default);
			CloseIconOnPopover.Click();
			PopoverTitle.WaitForNotDisplayed(Timeouts.Default);
		}
	}
}
