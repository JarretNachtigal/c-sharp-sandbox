class AsyncNotes
{

  public async Task<int> RetrieveDocsHomePage() // async in method name
  {
    var client = new HttpClient();
    byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/"); // wait asynchronously for result

    Console.WriteLine($"{nameof(RetrieveDocsHomePage)}: Finished downloading.");
    return content.Length;
  }
}