//  Prints celsius and corresponding fahrenheit from -5 to 40 degrees celsius

for (double i = -5; i<=40; i=i+0.5) {
    double fahr = (i*(9.0/5.0))+32;
    double cel = i;
    Console.WriteLine("celsius " + cel + " fahrenheit " + fahr);
}