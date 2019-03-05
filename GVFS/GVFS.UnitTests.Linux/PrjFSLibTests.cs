using GVFS.Tests.Should;
using NUnit.Framework;
using PrjFSLib.Linux;

namespace GVFS.UnitTests.Linux
{
    [TestFixture]
    public class PrjFSLibTests
    {
        [TestCase]
        public void GetProcCmdlineWorks()
        {
            VirtualizationInstance.GetProcCmdline(System.Diagnostics.Process.GetCurrentProcess().Id).ShouldEqual("dotnet");
        }
    }
}
