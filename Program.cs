using System;
using System.IO;
using CarnetClasses;



Console.WriteLine("MR7ba bik fl Carnet Dialk!");

bool eawd = true;

while(eawd){

Console.WriteLine("1. Ettdaya  2. Chddada 3. Khroj");
Console.Write("Khtar chi Option:");

var Choix =  Convert.ToInt32(Console.ReadLine());

if(Choix == 1){

    var path ="Ettdaya.txt";

    Console.WriteLine("Khtar l operation li bghiti dir");
    Console.WriteLine("1. Zid ettday");
    Console.WriteLine("2. N9ass ettday");
    Console.WriteLine("3. Afficher l ettdaya");
    Console.WriteLine("4. Qallab 3la ettday");
    Console.WriteLine("5.Khroj");
    Console.Write("Choose an option:");

    Choix = Convert.ToInt32(Console.ReadLine());

    switch( Choix){
        case 1:
        Ettday.Zid(path, "Ettday");
        break;
        case 2: 
        Console.Write("ara smito: "); var smia = Convert.ToString(Console.ReadLine());
#pragma warning disable CS8604 // Possible null reference argument.
        Ettday.Nqass(path, smia);
#pragma warning restore CS8604 // Possible null reference argument.
        break;
        case 3:
        Ettday.Afficher(path);
        break;
        case 4:
        Console.Write("ara smito: ");
        var smito = Convert.ToString(Console.ReadLine());
#pragma warning disable CS8604 // Possible null reference argument.
        Ettday.Qallab(smito);
#pragma warning restore CS8604 // Possible null reference argument.
        break;
        case 5:
        eawd = false;
        break;
    }
}
else if(Choix == 3){
    eawd = false;
}
else
{
    Console.WriteLine("makayn walo ajmi");
}
}

