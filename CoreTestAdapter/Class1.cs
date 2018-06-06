using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;

namespace CoreTestAdapter
{
    [FileExtension(".dll")]
    [DefaultExecutorUri("executor://JavaScriptExecutor")]
    public class CoreTestDiscoverer : ITestDiscoverer
    {
        public void DiscoverTests(IEnumerable<string> sources, IDiscoveryContext discoveryContext, IMessageLogger logger, ITestCaseDiscoverySink discoverySink)
        {
            logger.SendMessage(TestMessageLevel.Error, "DiscoverTests");
        }
    }

    [ExtensionUri("executor://JavaScriptExecutor")]
    public class CoreTestExecutor : ITestExecutor
    {
        public void Cancel()
        {
        }

        public void RunTests(IEnumerable<TestCase> tests, IRunContext runContext, IFrameworkHandle frameworkHandle)
        {
            var settings = runContext.RunSettings.SettingsXml;
            frameworkHandle.SendMessage(TestMessageLevel.Error, "RunTests");
        }

        public void RunTests(IEnumerable<string> sources, IRunContext runContext, IFrameworkHandle frameworkHandle)
        {
            var settings = runContext.RunSettings.SettingsXml;
            frameworkHandle.SendMessage(TestMessageLevel.Error, "RunTests");
        }
    }
}
