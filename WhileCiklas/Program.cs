//int i = 1;
//while (i <= 5)
//{
//    Console.WriteLine(i);
//    i++;
//}

//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////

//While reading user input

//int i = 1;
//string result = "";

//while (i <= 5)
//{
//    Console.WriteLine("Iveskite teskta: ");
//    string input = Console.ReadLine();
//    result += " " + input;
//    i++;
//}
//Console.WriteLine(result);

//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////


//Console.WriteLine("Atspekite skaiciu");
//string userInput = "";
//string secretNumber = "15";
//int attemts = 0;

//while(userInput != secretNumber && attemts < 3)
//{
//    userInput = Console.ReadLine();
//    attemts++;
//}

//Console.WriteLine("Sveikiname, jus atpsejote skaiciu");

//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////

//Nested while

//int i = 1;
//int j = 1; 

//while (i <= 3)
//{
//    Console.WriteLine($"Outer loopl: {i}");
//    while(j <= 3)
//    {
//        Console.WriteLine($"Inner loop: {j}");
//        j++;
//    }
//    i++;
//    j = 1; 
//}

//int i = 5;
//while (i >= 1)
//{
//    Console.WriteLine(i);
//    i--;
//}

//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////

//int i = 2;
//while ( i <= 10)
//{
//    Console.WriteLine(i);
//    i += 2;
//}

// i = 1; 

//while (i <= 9)
//{
//    Console.WriteLine(i);
//    i = i + 2;
//}

//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////

//Console.WriteLine("Iveskite skaiciu: ");
//int userNumber = Convert.ToInt32(Console.ReadLine());

//while (userNumber > 100)
//{
//    Console.WriteLine(userNumber);
//    userNumber = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("Jus ivedete mazesni skaiciu uz 100");


//Console.WriteLine("Iveskite skaiciu: ");
//int number = 101;

//while (number > 100)
//{
//    string input = Console.ReadLine();
//    number = Convert.ToInt32(input);
//}
//Console.WriteLine("Jus ivedete mazesni skaiciu uz 100");


//Console.WriteLine("Iveskite skaiciu: ");
//int userNumber = Convert.ToInt32(Console.ReadLine());

//while (userNumber > 100)
//{
//     userNumber = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("Skaicius yra maziau negu 100");

//while (userNumber > 0)
//{
//    userNumber = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("Skaicius yra neigiamas ");

//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////
///////////////////FAKTORIALAS///////////////////////////////////////////

//Console.WriteLine("===== Uzduotis Nr. 2 =====");
//Console.WriteLine(" ");


//Console.WriteLine("Iveskit skaiciu: ");
//int number = int.Parse(Console.ReadLine());
//int factorial = number;

//while (number > 1)
//{
//    factorial *= --number;
//    Console.WriteLine(factorial);

//    if (factorial < 0)
//    {
//        Console.WriteLine("Faktorialas tapo neigiamu");
//        break;
//    }
//}
//Console.WriteLine("===== Uzduotis Nr. 2 END =====");
//Console.WriteLine(" ");

//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

//Console.WriteLine("===== Uzduotis Nr. 2 =====");
//Console.WriteLine(" ");


//Console.WriteLine("Iveskit teigiama skaiciu: ");
//string numbers = Console.ReadLine();
//char[] chars = numbers.ToCharArray();


//while (chars > numbers)
//{
//    Console.WriteLine(chars[0]);
//    Console.WriteLine(chars[1]);
//    Console.WriteLine(chars[2]);
//    Console.WriteLine(chars[3]);
//    Console.WriteLine(chars[4]);
//    Console.WriteLine(chars[5]);
//}

//Console.WriteLine("===== Uzduotis Nr. 2 END =====");
//Console.WriteLine(" ");

//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////

//Console.WriteLine("===== Uzduotis Nr. 2 =====");
//Console.WriteLine(" ");

//Console.WriteLine("Iveskit skaiciu: ");
//string numbers = Console.ReadLine();
//int numb = Convert.ToInt32(numbers);
//int i = 1;
//string star = "*";

//while (i <= numb)
//{
//    Console.WriteLine(star);
//    star += "*";
//    i++;
//}

//Console.WriteLine("===== Uzduotis Nr. 2 END =====");
//Console.WriteLine(" ");

//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////

//Console.WriteLine("===== Uzduotis Nr. 3 =====");
//Console.WriteLine(" ");

//Console.WriteLine("Iveskite sveikaji skaiciu: ");
//string numbers = Console.ReadLine();
//int numb = Convert.ToInt32(numbers);

//int result = numb % 2;

//while (result != 0)
//{
//    numbers = Console.ReadLine();
//    numb = Convert.ToInt32(numbers);
//    result = numb % 2;
//    Console.WriteLine("Ivestas blogas skaicius, prasome kartoti");
//    Console.WriteLine(result);
//}
//Console.WriteLine("Ivestas sveikas skaicius, programa baigta!!!");

//Console.WriteLine("===== Uzduotis Nr. 3 END =====");
//Console.WriteLine(" ");

//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////

//Console.WriteLine("===== Uzduotis Nr. 3 =====");
//Console.WriteLine(" ");

//Console.WriteLine("Iveskite skaiciu: ");
//double number = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("IVeskite laipsni kuriuo norite pakelti:  ");
//int laipsnis = Convert.ToInt32(Console.ReadLine());

//double result = Math.Pow(number, laipsnis);

//Console.WriteLine("Skaicius pakeltas laipsniu yra: " + result);

//Console.WriteLine("===== Uzduotis Nr. 3 END =====");
//Console.WriteLine(" ");

//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////



//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////

//Console.WriteLine("===== Uzduotis Nr. 4 =====");
//Console.WriteLine(" ");

//Console.WriteLine("Įveskite sveikąjį skaičių: ");

//if (int.TryParse(Console.ReadLine(), out int skaicius) && skaicius >= 0)
//{
//    int eilutes = 1;

//    while (eilutes <= skaicius)
//    {
//        int simboliai = 1;

//        while (simboliai <= eilutes)
//        {
//            Console.Write(eilutes);
//            simboliai++;
//        }

//        Console.WriteLine();
//        eilutes++;
//    }
//}
//else
//{
//    Console.WriteLine("Netinkamas įvestas skaičius. Įveskite sveikąjį neneigiamą skaičių.");
//}
//Console.WriteLine("===== Uzduotis Nr. 4 END =====");
//Console.WriteLine(" ");

//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////


//Console.WriteLine("===== Uzduotis Nr. 4 =====");
//Console.WriteLine(" ");

//Console.WriteLine("Iveskite pinigu suma kuria norite isgryninti: ");
//int suma = Convert.ToInt32(Console.ReadLine());

//if (suma > 0)
//{
//    int likutis = suma;

//    while (likutis > 0)

//        if (likutis >= 50)
//        {
//            Console.WriteLine("Isduodama 50eur banknotas");
//            likutis -= 50;
//        }

//        else if (likutis >= 20)
//        {
//            Console.WriteLine("Isduodama 20eur banknotas");
//            likutis -= 20;
//        }

//        else if (likutis >= 10)
//        {
//            Console.WriteLine("Isduodama 10eur banknotas");
//            likutis -= 10;
//        }

//        else if (likutis >= 10)
//        {
//            Console.WriteLine("Isduodama 5eur banknotas");
//            likutis -= 5;
//        }

//        else if (likutis >= 10)
//        {
//            Console.WriteLine("Isduodama 1eur banknotas");
//            likutis -= 1;
//        }
//        else
//        {
//            Console.WriteLine("Netinkama suma. Iveskite teigiamas skaiciu");
//        }
//}

//    Console.WriteLine("===== Uzduotis Nr. 4 END =====");
//    Console.WriteLine(" ");

//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////


//Console.WriteLine("===== Uzduotis Nr. 5 =====");
//Console.WriteLine(" ");
//int skaicius = 0;
//int ivestasSkaicius;

//do
//{
//    Console.WriteLine("Iveskite skaiciu arba 'baigtas' norint baigti: ");
//    ivestasSkaicius = int.Parse(Console.ReadLine());
//    skaicius += ivestasSkaicius;
//    if (ivestasSkaicius.Equals("baigtas"));
    
//}while (ivestasSkaicius != 0);
//Console.WriteLine("Suma: " + skaicius);




//Console.WriteLine("===== Uzduotis Nr. 5 END =====");
//Console.WriteLine(" ");