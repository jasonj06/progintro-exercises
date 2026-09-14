int secondsPassed = 21816000; // Not in december
//int secondsPassed = 28512001; // In december
double price = 599.95;

// Determining if it is christmas (the month of december)
bool isChristmas = secondsPassed >= 28512000;

double newPrice = (isChristmas ? (price*0.7) : price);

Console.WriteLine("Is december: " + isChristmas + " Price is: " + newPrice);