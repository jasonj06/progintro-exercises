byte monthNum = 9;

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

