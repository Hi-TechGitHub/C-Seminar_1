// Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число больше, а какое меньшее
Console.WriteLine("Впишите 2 числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int max;
if(number1 > number2){
    max = number1;

}
else {
    max = number2;
}
Console.WriteLine("число " + max);