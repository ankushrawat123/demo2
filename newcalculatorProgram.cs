// See https://aka.ms/new-console-template for more information
Console.WriteLine("Here you can do Operation like Addition,Substraction,Multiplication,Division");
Console.WriteLine(" Press 1 for Addition \n Press 2 for Substraction\n Press 3 for Multiplication \n Press 4 for Division");
int num = Convert.ToInt32(Console.ReadLine());
switch (num) {
    case 1:
        Console.WriteLine("Enter first number");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int num2=Convert.ToInt32(Console.ReadLine());
        int add = num1 + num2;
        Console.WriteLine("Addition of {0} & {1} is: {2}",num1,num2,add);
        break;
    case 2:
        Console.WriteLine("Enter first number");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int num4 = Convert.ToInt32(Console.ReadLine());
        int sub = num3 - num4;
        Console.WriteLine("Substraction of {0} & {1} is: {2}",num3,num4,sub);
        break;
    case 3:
        Console.WriteLine("Enter first number");
        int num5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int num6 = Convert.ToInt32(Console.ReadLine());
        int mul = num5*num6;
        Console.WriteLine("Multiplication of {0} & {1} is: {2}",num5,num6,mul);
        break;
    case 4:
        Console.WriteLine("Enter first number");
        int num7 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int num8 = Convert.ToInt32(Console.ReadLine());
        int div = num7/num8;
        Console.WriteLine("Division of {0} & {1} is: {2}",num7,num8,div);
        break;
    Default:
        Console.WriteLine("Choosen invalid option");
}

