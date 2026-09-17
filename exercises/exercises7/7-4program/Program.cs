int[] numbers = [2, 5, 10, 14, 2, 91, 9, 8, 21, 64];

int num = 0;
for (int i=0; i<numbers.Length; i++) {
    if (numbers[i]>num) {
        num = numbers[i];
    }
}
Console.WriteLine(num);