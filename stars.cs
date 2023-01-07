string[] stars = {"Vega", "Procyon", "Sirius", "Alpha Centauri"};
Random dice = new Random();
int roll = dice.Next(0, 3);
if(roll == 0)
{
    Console.Write($"{stars[0]} is the brightest star in the northern constellation of Lyra.");
}
else if(roll == 1)
{
    Console.Write($"{stars[1]} is the brightest star in the constellation of Canis Minor.");
}
else if(roll == 2)
{
    Console.Write($"{stars[2]} is the brightest star in the night sky.");
}
else if(roll == 3)
{
    Console.Write($"{stars[3]} is a triple star system in the constellation of Centaurus.");
}
