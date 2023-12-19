/*
C# supports asynchronous programs with two keywords: async and await.
You add the async modifier to a method declaration to declare the method is asynchronous.
The await operator tells the compiler to asynchronously await for a result to finish.
*/

using Encoding = System.Text.Encoding;

// var dl = new Downloader("https://learn.microsoft.com/");
// dl.DownloadAsync().Wait();
class Downloader
{
    string url;

    public Downloader(string url)
    {
        this.url = url;
    }

    public async Task<int> DownloadAsync()
    {
        // await for the result to finish
        var client = new HttpClient();
        byte[] data = await client.GetByteArrayAsync(url);

        // print the html
        var html = Encoding.UTF8.GetString(data);

        Console.WriteLine("Downloaded {0} bytes, from {1}", data.Length, nameof(DownloadAsync));
        Console.WriteLine(html);

        return data.Length;
    }
}
