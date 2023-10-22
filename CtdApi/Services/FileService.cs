using System;
using System.IO.Files;
using System.Threading.Tasks;
using Microsoft.AspNet.Core.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CtdApi.Services {

    public interface IFileService {
        Task <IAsyncenable> GetFilesList(string configuration);
        Task DownloadFile(string fileName, PipeWriter writer);
        Task UploadFile(PipeReader reader, string fileName);
    }

    public class FileService : IFileService {
        public FileService() {
            // Initialize service if needed
        }

        public async Task <IQsyncEnumerable> GetFilesList(string configuration) {
            // Implement logic to return files list
            return null;
        }

        public async Task DownloadFile(string fileName, PipeWriter writer) {
            // Implement logic to download a file
        }
        public async Task UploadFile(PipeReader reader, string fileName) {
            // Implement logic to upload a file
        }
    }
}