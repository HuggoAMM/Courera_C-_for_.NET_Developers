using System;

//Declarando el delegado
delegate int CalculateDelegate(int num);

namespace properties_indexer_exceptions
{
    internal class DelegateExample
    {
        static int number = 10;
        public static int addition(int num ){
            number = number + num;
            return number;
        }

        public static int multiplication(int num) {
            number = number * num;
            return number;
        }

        public static int getNumber()
        {
            return number;
        }
    }
}
