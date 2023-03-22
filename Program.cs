using SLVP_Week5_DiesAndDiecupsExtra;

DieCup dCup = new DieCup();
Console.WriteLine("The total value of the dies are: " + dCup.GetValue());
Console.WriteLine("Shaking the diecup....");
dCup.Roll();
Console.WriteLine("The value of the dies are: " + dCup.ToString());