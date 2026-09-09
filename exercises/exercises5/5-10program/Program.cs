sbyte celsius; // Signed byte because temperature can be negative (Only accepts whole numbers)
celsius = 15;

static double celToFahr(sbyte c)
{
    return ( c * (9/5) ) + 32; // Formula for C to F: F = 32 + (9/5) * C
}

Console.WriteLine("15 degrees celsius is equal to " + celToFahr(celsius) + " degrees fahrenheit");