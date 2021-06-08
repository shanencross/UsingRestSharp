using System;
using System.Threading.Tasks;
using RestSharp;

namespace UsingRestSharp
{
  public class Program
  {
    static void Main()
    {
      var apiCallTask = ApiHelper.ApiCall("[INSERT-API-KEY]");
      var result = apiCallTask.Result;
      Console.WriteLine(result);
    }

    class ApiHelper
    {
      public static async Task<string> ApiCall(string apiKey)
      {
        RestClient client = new RestClient("https://api.nytimes.com/svc/topstories/v2");
        RestRequest request = new RestRequest($"home.json?api-key={apiKey}", Method.GET);
        var response = await client.ExecuteTaskAsync(request);
        return response.Content;
      }
    }
  }
}