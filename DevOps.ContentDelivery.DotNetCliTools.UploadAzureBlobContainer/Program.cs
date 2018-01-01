using System.Threading.Tasks;
using static Common.Functions.BuildCommandLineArgConfiguration.CommandLineConfigurationBuilder;
using static DevOps.ContentDelivery.Functions.UploadDirectoryToAzureBlobContainer.DirectoryUploader;

namespace DevOps.ContentDelivery.DotNetCliTools.UploadAzureBlobContainer
{
    public static class Program
    {
        private const string Container = nameof(Container);
        private const string Content = nameof(Content);

        public static async Task Main(string[] args)
            => await UploadFiles(
                ContainerName(args),
                path: Content);

        private static string ContainerName(string[] args)
            => Configuration(args)[Container];
    }
}
