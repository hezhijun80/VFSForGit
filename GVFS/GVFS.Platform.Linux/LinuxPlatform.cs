using GVFS.Common;
using GVFS.Common.FileSystem;

namespace GVFS.Platform.Linux
{
    public partial class LinuxPlatform : POSIX.POSIXPlatform
    {
        public LinuxPlatform()
            : base(
                installerExtension: string.Empty)
        {
        }

        public override IKernelDriver KernelDriver { get; } = new ProjFSLib();

        public override string GetOSVersionInformation()
        {
            ProcessResult result = ProcessHelper.Run("uname", args: "-a", redirectOutput: true);
            return string.IsNullOrWhiteSpace(result.Output) ? result.Errors : result.Output;
        }
    }
}
