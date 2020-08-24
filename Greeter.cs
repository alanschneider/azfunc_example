
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Newtonsoft.Json;

/// <inheritdoc/>
public class Greeter : IGreeter
{
    const string CANNED_MESSAGE =
        "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response.";

    const string SAY_HELLO_TEMPLATE =
        "Hello, {0}. This HTTP triggered function executed successfully.";

    private string CreateGreetingFor(string name) => string.Format(SAY_HELLO_TEMPLATE, name);

    /// <inheritdoc/>
    public IActionResult ReturnCannedResponse() => new OkObjectResult(CANNED_MESSAGE);

    /// <inheritdoc/>
    public async Task<IActionResult> SayHello(HttpRequest req, ICollector<string> msg)
    {
        string name = req.Query["name"];

        string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        dynamic data = JsonConvert.DeserializeObject(requestBody);
        name = name ?? data?.name;
        name = !string.IsNullOrWhiteSpace(name) ? name : "noname";

        var greeting = CreateGreetingFor(name);

        msg.Add(greeting);
        return new OkObjectResult(greeting);
    }
}