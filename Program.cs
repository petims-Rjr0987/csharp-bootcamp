var nom = "Fetra";
var age = 20;
var pays = "Madagascar";
var objectif1 = "Backend Developer";
var objectif2 = "Game Developer";
int? ageInput;

Console.WriteLine("======================================================");
Console.WriteLine("C# Bootcamp\n");

Console.WriteLine($"Nom : {nom}");
Console.WriteLine($"Age : {age}ans");
Console.WriteLine($"Pays : {pays}");
Console.WriteLine($"Objectif 1 : {objectif1}");
Console.WriteLine($"Objectif 2 : {objectif2}");

Console.WriteLine("======================================================");
Console.WriteLine("=======================================================");
Console.WriteLine(" Mon personelle profil");
Console.WriteLine("=======================================================");

Console.Write("Entrer votre nom : ");
string name = Console.ReadLine();


Console.Write("Votre age? : ");
string ageText =Console.ReadLine();
if(int.TryParse(ageText, out int ageValue)){
    ageInput = ageValue;
}
else
{
    ageInput =90;
}
Console.Write("Votre pays : ");
string Origin = Console.ReadLine();

Console.Write("Votre objectif 1 : ");
string objectif11 = Console.ReadLine();

Console.Write("votre Objectif 2 : ");
string objectif21 = Console.ReadLine();
Console.WriteLine("\n==================================================");
Console.WriteLine("\n RÉSUMÉ DU VOTRE PROFIL :");
Console.WriteLine("\n==================================================");
Console.WriteLine($"nom : {name}");
Console.WriteLine($"age : {ageInput}");
Console.WriteLine($"pays : {Origin}");
Console.WriteLine($"objectif 1 : {objectif11}");
Console.WriteLine($"objectif 1 : {objectif21}");
Console.WriteLine("\n==================================================");
Console.WriteLine("\nAppyer etré pour quiter");
/*Console.ReadLine();
        git add .
git commit -m "description"
git push
*/
