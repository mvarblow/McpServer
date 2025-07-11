using System.ComponentModel;
using ModelContextProtocol.Server;

namespace McpServer.Tools;

[McpServerToolType]
public class JokeTool
{
    private readonly HttpClient httpClient = new()
    {
        BaseAddress = new Uri("https://v2.jokeapi.dev/joke/")
    };

    [McpServerTool, Description("Fetches jokes from a specified category.")]
    public async Task<string> GetJoke(
        [Description("Category of jokes (e.g., 'Programming', 'Misc', 'Christmas').")] string category,
        [Description("Number of jokes to retrieve, default is 10.")] int amountOfJokes = 10)
    {
        try
        {
            var response = await httpClient.GetAsync($"{category}?amount={amountOfJokes}");
            return await response.Content.ReadAsStringAsync();
        }
        catch
        {
            return "Error fetching jokes.";
        }
    }
}