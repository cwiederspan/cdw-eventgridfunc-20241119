using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MyFunctions
{
    public class FileProcessor
    {
        private readonly ILogger<FileProcessor> Logger;

        public FileProcessor(ILogger<FileProcessor> logger)
        {
            this.Logger = logger;
        }

        [Function(nameof(FileProcessor))]
        public async Task Run([BlobTrigger("samples-workitems/{name}", Source = BlobTriggerSource.EventGrid, Connection = "")] Stream stream, string name)
        {
            using var blobStreamReader = new StreamReader(stream);
            var content = await blobStreamReader.ReadToEndAsync();
            this.Logger.LogInformation($"C# Blob trigger function Processed blob\n Name: {name} \n Data: {content}");
        }
    }
}
