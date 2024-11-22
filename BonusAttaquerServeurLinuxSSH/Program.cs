// Installez d'abord le Nuget SSH.NET by drieseng, olegkap, putty-sshnet
using System;
using Renci.SshNet;

try
{
    // Définir les informations de connexion
    string host = "Mettre l'Ip du sertveur ssh"; // Remplacez par l'adresse IP de votre serveur
    string username = "mettre le login d'un utilisateur sudo de preference"; // Remplacez par votre nom d'utilisateur
    string password = "Mettre votre mot de passe"; // Remplacez par votre mot de passe

    // Définir la commande à exécuter
    string command = "ls -la"; // Commande Linux

    // Configurer la connexion SSH
    using (var client = new SshClient(host, username, password))
    {
        client.Connect();

        // Exécuter la commande
        var cmd = client.CreateCommand(command);
        var result = cmd.Execute();

        // Afficher les résultats
        Console.WriteLine("Output:\n" + result);
        if (!string.IsNullOrEmpty(cmd.Error))
        {
            Console.WriteLine("Errors:\n" + cmd.Error);
        }

        client.Disconnect();
        var x = Console.ReadLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}
