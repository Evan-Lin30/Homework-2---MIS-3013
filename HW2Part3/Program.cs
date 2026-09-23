//Homework 2 part 1
Console.WriteLine("---Smart Checkout System---");
Console.WriteLine("Please enter the item price (enter 0 to finish transaction)."); 

double totalprice = 0;
string managerPin = "1234";
double itemprice = 1;
string enterpin = "";

while (itemprice != 0)
{
    Console.WriteLine("Scan Item Price");
    itemprice = Convert.ToDouble(Console.ReadLine());

    if (itemprice >= 100)
    {
        Console.WriteLine("Manager approval is required for the high value item ($100+)");
        Console.WriteLine("Manager enter your override PIN");
        enterpin = Console.ReadLine();

        if (enterpin == managerPin)
        {
            Console.WriteLine("Correct PIN. item is approved and added");
            totalprice = totalprice + itemprice;
        }
        else
        {
            Console.WriteLine("Incorrect PIN. Item is not added");
        }
    }
    else
    {
        totalprice = totalprice + itemprice;
    }
}
Console.WriteLine("Your receipt total: " + totalprice);

string correctPassword = "mis3013isgreat!";
int maxAttempts = 3;
int attemptsUsed = 0;
bool isAccessGranted = false;
string enteredPassword = "";

//Homework part 2
do
{
    Console.WriteLine("Please enter the security password:");
    enteredPassword = Console.ReadLine();

    if (enteredPassword == correctPassword)
    {
        Console.WriteLine("Access Granted");
        isAccessGranted = true;
        attemptsUsed++;
    }
    else
    {
        attemptsUsed++;
        Console.WriteLine($"You have {maxAttempts - attemptsUsed} attempts left");
    }
} while (!isAccessGranted&& attemptsUsed < maxAttempts);

if (isAccessGranted == false)
{
    Console.WriteLine("Security Lockdown Initiated");
}

//Homework part 3
for (int countdown = 10; countdown >= 1; countdown--)
{
    Console.WriteLine(countdown + "...");

    if (countdown == 7)
    {
        Console.WriteLine("[SYSTEM]: checking fuel levels... OK.");
    }

    if (countdown == 4)
    {
        Console.WriteLine("[SYSTEM]: Oxygen pressure... Stabilized");
    }

    if (countdown == 1)
    {
        Console.WriteLine("[SYSTEM]: Ignition Sequence... Start.");
    }
    System.Threading.Thread.Sleep(1000);
}
Console.WriteLine(" | ");
Console.WriteLine(" / \\ ");
Console.WriteLine(" / _ \\");
Console.WriteLine(" | |");
Console.WriteLine(" | (R) |");
Console.WriteLine(" |_____|");
Console.WriteLine(" V V V ");

for (int time = 1; time <= 20; time++)
{
    Console.WriteLine("");
    System.Threading.Thread.Sleep(100);
}

Console.WriteLine("Mission Success!");