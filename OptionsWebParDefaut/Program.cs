using System.Text.Json;

//Si vous voulez sérialiser avec les options par défaut
//utilisées par ASP.NET Core pour les applications web, 
//utilisez le nouveau singleton JsonSerializerOptions.Web.

string webJson = JsonSerializer.Serialize(
    new { SomeValue = 42 },
    JsonSerializerOptions.Web // Defaults to camelCase naming policy.
    );
Console.WriteLine(webJson);
// {"someValue":42}
