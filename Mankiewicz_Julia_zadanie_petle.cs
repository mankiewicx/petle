using System;

//Za pomocą pętli while wyświetlić liczby z zakresu 10 do 35.
var number = 10;


while (number <= 35)
{
    Console.WriteLine(number);
    number += 1;
};
//Pobiera od użytkownika liczbę całkowitą n i oblicza wartość n!
int number1 = 0;
bool right;
int silnia = 1;
do
{
    Console.WriteLine("Wpisz liczbę całkowitą dodatnią:");
    right = int.TryParse(Console.ReadLine(), out number1);

}
while ((!right) || (number1 < 0));

for (int i = 2; i <= number1; i++)
{
    silnia = silnia * i;
}
Console.WriteLine($" ! {silnia}");


//Drukuje na ekranie kwadrat. Długość boku kwadratu wczytujemy z klawiatury. Poniższy kwadrat ma bok długości 4. 
int number2 = 0;
bool success;


do
{
    Console.Write("Wpisz liczbę całkowitą dodatnią: ");
    success = int.TryParse(Console.ReadLine(), out number2);
}
while ((!success) || (number2 < 0));

for (int linia = 1; linia <= number2; linia++)
{
    for (int i = 1; i <= number2; i++)
    {
        Console.Write("Y");
    }
    Console.Write("\n");
}
Console.ReadKey();