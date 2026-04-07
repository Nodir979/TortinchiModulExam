using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;

public class ImageService
{
    private readonly HttpClient _http;

    public ImageService()
    {
        _http = new HttpClient();
    }

    
    public async Task<List<string>> GetImagesAsync(string query, int count)
    {
        var urls = new List<string>();
        for (int i = 0; i < count; i++)
        {
            urls.Add($"https://picsum.photos/seed/{query + i}/600/400");
        }
        return urls;
    }

   
    public async Task DownloadImageAsync(string url, string filePath)
    {
        var data = await _http.GetByteArrayAsync(url);
        await File.WriteAllBytesAsync(filePath, data);
    }
}
