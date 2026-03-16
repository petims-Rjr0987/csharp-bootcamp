var nom = "Fetra";
var age = 20;
var pays = "Madagascar";
var objectif1 = "Backend Developer";
var objectif2 = "Game Developer";

Console.WriteLine("======================================================");
Console.WriteLine("C# Bootcamp\n");

Console.WriteLine($"Nom : {nom}");
Console.WriteLine($"Age : {age} ans");
Console.WriteLine($"Pays : {pays}");
Console.WriteLine($"Objectif 1 : {objectif1}");
Console.WriteLine($"Objectif 2 : {objectif2}");

Console.WriteLine("======================================================");
Console.WriteLine("Mon profil personnel");
Console.WriteLine("======================================================");

Console.Write("Entrer votre nom : ");
string? name = Console.ReadLine();

Console.Write("Votre age ? : ");
string? ageText = Console.ReadLine();

int ageInput;

if (int.TryParse(ageText, out int ageValue))
{
    ageInput = ageValue;
}
else
{
    ageInput = 0;
}

Console.Write("Votre pays : ");
string? origin = Console.ReadLine();

Console.Write("Votre objectif 1 : ");
string? objectifUser1 = Console.ReadLine();

Console.Write("Votre objectif 2 : ");
string? objectifUser2 = Console.ReadLine();

Console.WriteLine("\n==============================");
Console.WriteLine("RÉSUMÉ DE VOTRE PROFIL");
Console.WriteLine("==============================");

Console.WriteLine($"Nom : {name}");
string status;
if(ageInput <16){
    status ="you need to study more";
}
else if(ageInput < 18){
   status ="you are a teenager";
}
else
{
    status ="you are an adult";
}
Console.WriteLine($"{ageInput} ans {status}");
//Console.WriteLine($"Age : {ageInput} ans");

Console.WriteLine($"Pays : {origin}");
Console.WriteLine($"Objectif 1 : {objectifUser1}");
Console.WriteLine($"Objectif 2 : {objectifUser2}");

Console.WriteLine("\nAppuyer sur Entrée pour quitter");
Console.ReadLine();
