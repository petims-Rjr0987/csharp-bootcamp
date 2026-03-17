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
string? reponse1;
do
{
    Console.Write("voulez-vous faire l'insription (oui/non) : ");
    reponse1 = Console.ReadLine();
} while ((reponse1 ?? "").ToLower().Trim() != "oui" && (reponse1 ?? "").ToLower().Trim() != "non");
//ToLower = methode pour tranforment tout ce que l'utilisateur taper mais même coherence que oui
// for instance : ouI , OUI ,Oui , etc ....;
//Suppreation des espaces Trim()
if (reponse1 == "non")
{
    Console.WriteLine("Au reveoir");
    return;
}
string? name = "";
while(string.IsNullOrEmpty(name)){
    Console.Write("nom obligatoire : ");
    name = Console.ReadLine();
}
string? ageText = "";
string? reponse2;
do
{
    Console.WriteLine("ÂGE forcement vide 0 si on tapez une input vide accepté/refusier la mesur à prendre : ");
    reponse2 = Console.ReadLine();
} while (reponse2 != "accepté" && reponse2 != "réfuser");
    int ageInput = 0;
while (true)
{
    Console.Write("âge obligatoire et acceptable : ");
    ageText = Console.ReadLine();
    if(int.TryParse(ageText, out int val)){
        ageInput = val;
        break;
    }else
    {
        Console.WriteLine("Âge invalide");

    }
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
for(int i =0;i<3;i++){
    Console.WriteLine("c'est fini pour le moment");
}
Console.WriteLine("\nAppuyer sur Entrée pour quitter");
Console.ReadLine();
