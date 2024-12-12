// While Loop - paneb käima tsükli kuni mingi tingimus on täidetud.

// loome mängu kus arvame ära arvuti genereeritava numbri
// - numbri vahemik on 1-3(k.a.)
// Arvuti õnnitleb kui arvatud number on õige.

Random rnd = new Random();
int cpuRandom;

bool loopActive = true; // boolid võivad olla "true" or "false" st "1" või "0"

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"ADMIN - CPU on genereerinud numbri: {cpuRandom}");
    Console.WriteLine("Arva ära arvuti genereeritud number - Kirjuta üks number ühest kuni kolmeni (1-3)");
    
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Arvasid õige numbri ära, palju õnne!");
        //loopActive = false;
        break; // toimib samamoodi kui "loopActive = false;"
    }
    else
    {
        Console.WriteLine("Arvasid valesti - arva uuesti! :)");
    }
}
Console.WriteLine("Tule ja mängi teine kord uuesti!");