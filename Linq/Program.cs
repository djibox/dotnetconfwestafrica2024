/*
1 - De nouvelles méthodes CountBy et AggregateBy ont été introduites. 
Ces méthodes permettent d’agréger l’état par clé sans avoir besoin 
d’allouer des regroupements intermédiaires via GroupBy.

2 - CountBy vous permet de calculer rapidement la fréquence de chaque clé.
L’exemple suivant recherche le mot qui est présent le plus fréquemment dans une chaîne de texte.
 */

string sourceText = """
    Lorem ipsum dolor sit amet, consectetur adipiscing elit.
    Sed non risus. Suspendisse lectus tortor, dignissim sit amet, 
    adipiscing nec, ultricies sed, dolor. Cras elementum ultrices amet diam.
""";

// Find the most frequent word in the text.
KeyValuePair<string, int> mostFrequentWord = sourceText
    .Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(word => word.ToLowerInvariant())
    .CountBy(word => word)
    .MaxBy(pair => pair.Value);

Console.WriteLine(mostFrequentWord.Key); // amet

/*
AggregateBy vous permet d’implémenter des workflows à usage général. 
L’exemple suivant montre comment calculer les scores associés à une clé donnée.
 */

//(string id, int score)[] data =
//    [
//        ("0", 42),
//        ("1", 5),
//        ("2", 4),
//        ("1", 10),
//        ("0", 25),
//    ];

//var aggregatedData =
//    data.AggregateBy(
//        keySelector: entry => entry.id,
//        seed: 0,
//        (totalScore, curr) => totalScore + curr.score
//        );

//foreach (var item in aggregatedData)
//{
//    Console.WriteLine(item);
//}
//(0, 67)
//(1, 15)
//(2, 4)

/*
 Index<TSource>(IEnumerable<TSource>) permet d’extraire rapidement l’index implicite d’un énumérable. 
Vous pouvez maintenant écrire du code comme l’extrait de code suivant 
pour indexer automatiquement les éléments d’une collection.
 */

string source = @"C:\\Users\\sarrk\\source\\repos\\DotnetConfWestAfrica2024\\Linq\\TextFile1.txt";
IEnumerable<string> lines2 = File.ReadAllLines(source);
foreach ((int index, string line) in lines2.Index())
{
    Console.WriteLine($"Line number: {index + 1}, Line: {line}");
}