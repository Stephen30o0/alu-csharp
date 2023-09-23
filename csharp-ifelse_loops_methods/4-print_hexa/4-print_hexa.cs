using System;

class Program{
    static void Main(String[] args){
         for(int hexa = 0; hexa < 99 ; hexa++){
            Console.WriteLine($"{hexa} = 0x{hexa:x}");
         }
    }
}