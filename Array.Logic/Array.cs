using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Logic
{
    public class ArrayNew
    {
        private int[] _array;
        private int[] _array1;
        private int[] _aux;
        private int _top;
        private int _max;
        
        public ArrayNew(int num)
        {
            _array = new int[num];
            _array1 = new int[num];
            _aux = new int[num];
            N = num;
        }

        public int N { get; }

        public bool IsFull => _top == N;
        public bool IsEmpty => _top == 0;

        public bool IsPrime(int number)
        {
            // Casos especiales
            if (number == 0 || number == 1 || number == 4)
                return false;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                    return false;
            }
            // Si no se pudo dividir por ninguno de los de arriba, el número es primo
            return true;
        }

        // Método para llenar el arreglo
        public void Fill(int minimo, int maximo)
        {
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                _array[i] = random.Next(minimo, maximo);
            }
            _top = N;
        }

        // Método para encontrar los números primos en el arreglo
        public void Prime()
        {
            int j = 0;
            for (int i = 0; i < _top; i++)
            {
                int _prime = _array[i];
                if (IsPrime(_prime))
                {
                    _array1[j] = _prime;
                    j++;
                }
            }
            if(j == 0)
            {
                Console.WriteLine("No existen números primos en este arreglo\t");
            }
            else
            {
                int count = 0; 
                for (int i = 0; i < j; i++)
                {
                    if (count == 10)
                    {
                        Console.Write("\n");
                        count = 0;
                    }
                    count++;
                    Console.Write($"{_array1[i]}\t");
                }
            }
            Console.Write("\n-------------\n");
        }

        // Método para encontrar los números que nose repiten dentro del arreglo
        public void NoRepeated()
        {
            int count = 0;
            int count1 = 0;
            for (int i = 0; i < _top; i++)
            {
                count = 0;
                if (count1 == 10)
                {
                    Console.Write("\n");
                    count1 = 0;
                }
                
                for (int j = 0; j < _top; j++)
                {
                    if (_array[i] == _array[j])
                    {
                        count++;
                    }
                }
                count1++;
                if (count == 1)
                {
                    Console.Write($"{_array[i]}\t");
                }
                
            }
            Console.Write("\n-------------\n");
        }
        
        public int CountElement(int[] _array, int e)
        {
            int c =0;
            for (int i = 0; i < _top; i++) 
            {
                if (_array[i] == e)
                { 
                    c++; 
                }
            }
            return c;
        }

        // Métodos que permiten encontrar las veces que se repiten los números del arreglo
        public bool FindElement(int[] _array, int e)
        {
            for (int i = 0; i < _top; i++)
            {
                if ((_array[i] == e))
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddElement(int[] _array, int e)
        {
            if (_max < _array.Length)
            {
                _array[_max++] = e;
                return true;
            }
            return false;
        }
                
        public void Repeated()
        { 
            /*int e = 0;*/
            for (int i = 0; i < _top; i++) 
            {
                int e = _array[i];
                if (!FindElement(_aux, e))
                {
                    Console.WriteLine("El número " + e + " se encuentra " + CountElement(_array, e) + " veces");
                    AddElement(_aux, e);
                }
            }
        }
                
        public override string ToString()
        {
            var output = "";

            if (IsEmpty) { return "Array Empty"; }

            var count = 0;
            for (int i = 0; i < N; i++)
            {
                if (count == 10)
                {
                    output += "\n";
                    count = 0;
                }
                output += $"{_array[i]}\t";
                count++;
            }
            return output;
        }
    }
}
