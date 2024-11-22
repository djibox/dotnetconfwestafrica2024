using System.Text.Json;

/*
 1 - Dans System.Text.Json, .NET 9 a de nouvelles options pour sérialiser le JSON 
et un nouveau singleton qui facilite la sérialisation en utilisant des valeurs par défaut pour le web.
2 - JsonSerializerOptions inclut de nouvelles propriétés qui vous permettent 
de personnaliser le caractère de mise en retrait et la taille de la mise en retrait du JSON écrit.
 */

var options = new JsonSerializerOptions
{
    WriteIndented = true,
    IndentCharacter = '\t',
    IndentSize = 2,
};

string json = JsonSerializer.Serialize(
    new { Value = 1 },
    options
    );
Console.WriteLine(json);
//{
//                "Value": 1
//}