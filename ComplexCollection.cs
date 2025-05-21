using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace L12_OOP_12.Models
{
    public class ComplexCollection
    {
        private Stack nonGenericStack; // System.Collections
        private Stack<ComplexNumber> genericStack; // System.Collections.Generic

        public ComplexCollection()
        {
            nonGenericStack = new Stack();
            genericStack = new Stack<ComplexNumber>();
        }

        // Додавання в обидві колекції
        public void AddComplexNumber(ComplexNumber complex)
        {
            nonGenericStack.Push(complex);
            genericStack.Push(complex);
        }

        // Перебір неузагальненої колекції
        public List<string> TraverseNonGeneric()
        {
            List<string> result = new List<string>();
            foreach (object obj in nonGenericStack)
            {
                if (obj is ComplexNumber cn)
                {
                    result.Add(cn.Display());
                }
            }
            return result;
        }

        // Перебір узагальненої колекції
        public List<string> TraverseGeneric()
        {
            List<string> result = new List<string>();
            foreach (ComplexNumber cn in genericStack)
            {
                result.Add(cn.Display());
            }
            return result;
        }

        // Отримання елемента за індексом із узагальненої колекції (по суті копія в масив)
        public string GetGenericElementAt(int index)
        {
            if (index < 0 || index >= genericStack.Count)
                return "Index out of range";

            ComplexNumber[] array = genericStack.ToArray();
            return array[index].Display();
        }

        // Отримання елемента за індексом із неузагальненої колекції
        public string GetNonGenericElementAt(int index)
        {
            if (index < 0 || index >= nonGenericStack.Count)
                return "Index out of range";

            object[] array = nonGenericStack.ToArray();
            if (array[index] is ComplexNumber cn)
                return cn.Display();
            return "Not a ComplexNumber";
        }
    }
}
