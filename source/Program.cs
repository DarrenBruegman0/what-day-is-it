//list all options
Console.WriteLine("1)      Monday");
Console.WriteLine("2)     Tuesday");
Console.WriteLine("3)   Wednesday");
Console.WriteLine("4)    Thursday");
Console.WriteLine("5)      Friday");
Console.WriteLine("6)    Saturday");
Console.WriteLine("7)      Sunday");
//input the specified option
string pnum = "";
int num = 0;
while (!int.TryParse(pnum, out num) || num < 1 || num > 7)
{
Console.Write("What day is it (Enter the Number)?   ");
 pnum = Console.ReadLine();
}
string display_text;

/*
If the user enters 1 → Output: "Aack! I hate Mondays!"
If the user enters 3 → Output: "Hump Daaaay!"
If the user enters 5 → Output: "TGIF!"
If the user enters 6 or 7 → Output: "It's the weekend!"
If the user enters 2 or 4 → Output: "It's Tuesday!" or "It's Thursday!" (respectively).
*/
switch (num)
{
    case 1:
        display_text = "Aack! I hate Mondays!";
        break;
    case 2:
        display_text = "It's Tuesday!";
        break;
    case 3:
        display_text = "Hump Daaaay!";
        break;
    case 4:
        display_text = "It's Thursday!";
        break;
    case 5:
        display_text = "TGIF!";
        break;
    case 6:
        display_text = "It's the weekend!";
        break;
    case 7:
        display_text = "It's the weekend!";
        break;
    default:
        display_text = "Integer not in Range";
        break;
}
//displays the correct text
Console.WriteLine(display_text);
