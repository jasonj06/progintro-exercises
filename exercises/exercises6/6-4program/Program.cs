byte monthNum = 11;

switch ((monthNum%2, monthNum<8, monthNum==2)) {
    case (1, true, false):
        Console.WriteLine("31 days");
        break;

    case (0, true, false):
        Console.WriteLine("30 days");
        break;
        
    case (1, false, false):
        Console.WriteLine("30 days");
        break;

    case (0, false, false):
        Console.WriteLine("31 days");
        break;

    case (0, true, true):
        Console.WriteLine("28 days");
        break;
}

/*
if (monthNum%2 != 0 && monthNum<8) {    // Checks if month is odd or even, alternates at month 8,
    Console.WriteLine("31 days");       // does not take care of february, and can go beyond 12.
}
else if (monthNum%2 == 0 && monthNum<8) {
    Console.WriteLine("30 days");
}
else if (monthNum%2 != 0 && monthNum>=8) {
    Console.WriteLine("30 days");
}
else if (monthNum%2 == 0 && monthNum>=8) {
    Console.WriteLine("31 days");
}
*/
