using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    internal class Calculator<T>
    {
        public T Add(T first, T second)
        {
            dynamic a = (dynamic)first; 
            dynamic b = (dynamic)second; 
            return a + b;
        }
        public T Sub(T first, T second)
        {
            dynamic a = (dynamic)first;
            dynamic b = (dynamic)second;
            return a - b;
        }
        public T Mult(T first, T second)
        {
            dynamic a = (dynamic)first;
            dynamic b = (dynamic)second;
            return a * b;
        }
        public T Div(T first, T second)
        {
            dynamic a = (dynamic)first;
            dynamic b = (dynamic)second;
            return a / b;
        }
    }
}