byte circle1 = 1;   
byte circle2 = 3;   // 3 circles with assigned radius   
byte circle3 = 5;    

static double area(byte radius)
{
    return 3.14*(radius*radius); // Returns calculation of area of circle with given radius (pi*r^2)
}

Console.WriteLine("Circle1 has area of: " + area(circle1));
Console.WriteLine("Circle2 has area of: " + area(circle2));
Console.WriteLine("Circle3 has area of: " + area(circle3));
