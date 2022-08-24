
// Console.WriteLine("Ingrese el primer numero");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el segundo numero");
// int num2 = int.Parse(Console.ReadLine());

// if (num1>num2){
//     Environment.Exit(0);
// }
// while(num1<num2){
//     if(num1%2 ==0){
//         Console.WriteLine(num1);
//     }
//     num1++;

// }
//----------------------------------------------------------------------

// int i=1;
// int count =0;
// while(i<=100){
//     if(i%7 ==0){
//         Console.WriteLine(i);
//         count++;
//     }
//     i++;
// }
// Console.WriteLine($"Hay {count} multiplos en total");

//--------------------------------------------------------------------

int num = 0;
string num1="0";

do{
    Console.WriteLine("Ingrese un numero de 0 a 999");
    num1 = Console.ReadLine();
    num = int.Parse(num1);
    if(num==0){
          Environment.Exit(0);
    }
    Console.WriteLine($"El numero tiene {num1.Length} digitos");
}while(num!=0);
























