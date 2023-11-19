using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System.Diagnostics;

namespace SampleAppWinUITest
{
    public class MainPageTest : IDisposable
    {
        private WindowsDriver<WindowsElement> session;

        public MainPageTest()
        {
            //need to locate to project path
            var projectPath = @"C:\Users\ericc\Documents\GitHub\MAUITech\src\UITest\Win\SampleApp\SampleApp";
            var projectPublishPath = Path.Combine(projectPath, "bin/Debug/net8.0-windows10.0.19041.0/win10-x64/publish");
            var exePath = Path.Combine(projectPublishPath, "SampleApp.exe");

            var publishProcess = new Process();
            publishProcess.StartInfo.WorkingDirectory = projectPath;
            publishProcess.StartInfo.FileName = "dotnet";
            publishProcess.StartInfo.Arguments = "publish -f net8.0-windows10.0.19041.0 -c Debug -p:RuntimeIdentifierOverride=win10-x64 -p:WindowsPackageType=None -p:WindowsAppSDKSelfContained=true";
            publishProcess.Start();
            publishProcess.WaitForExit();

            var options = new AppiumOptions();
            options.AddAdditionalCapability("app", exePath);
            session =
                new WindowsDriver<WindowsElement>
                (new Uri("http://127.0.0.1:4723/"), options);
        }

        public void Dispose()
        {
            session?.Dispose();
        }

        [Fact]
        public void FindHelloWorldText()
        {
            var ele = session.FindElementByAccessibilityId("HelloWorldLabel");

            Assert.NotNull(ele);

            Assert.Equal("Hello, World!", ele.Text);
        }

        [Fact]
        public void TapCountButton()
        {
            var ele = session.FindElementByAccessibilityId("CountBtn");
            Assert.NotNull(ele);
            ele.Click();
            Assert.Equal("Clicked 1 time", ele.Text);
        }
    }
}