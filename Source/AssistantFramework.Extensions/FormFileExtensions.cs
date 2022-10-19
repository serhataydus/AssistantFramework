using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AssistantFramework.Extensions;

public static class FormFileExtensions
{
    public static async Task<byte[]> GetBytes(this IFormFile formFile, CancellationToken cancellationToken = default)
    {
        await using MemoryStream memoryStream = new();
        await formFile.CopyToAsync(memoryStream, cancellationToken);

        return memoryStream.ToArray();
    }
}