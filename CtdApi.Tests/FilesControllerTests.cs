using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions; 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CtdApi.Tests
    {
        [Fact]
        public async Task GetParameterFilesTest()
        {
            // Arrange
            var controller = new FilesController();

            // Act
            var result = await controller.GetParameterFiles();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTypeOf(<ActionResult><LoginResponse>>(result.Value), "Result is not of type ActionResult<Object>");
        }

        [Fact]
        public async Task DownloadParameterFilesTest()
        {
            // Arrange
            var controller = new FilesController();

            // Act
            var result = await controller.DownloadParameterFiles();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTypeOf<ActionResult><IasynchronousEnable<Byte>>>(result.Value), "Result is not of type ActionResult<IAsynchronousEnable<Byte>>");
        }

        [Fact]
        public async Task UploadLogsFilesTest()
        {
            // Arrange
            var controller = new FilesController();

            // Act
            var result = await controller.UploadLogsFiles(null);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTypeOf<ActionResult><IasynchronousEnable<Byte>>>(result.Value), "Result is not of type ActionResult<IAsynchronousEnable<Byte>>");
        }
    }
}