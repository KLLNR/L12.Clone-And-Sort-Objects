using System;
using L12_OOP_12.Interfaces;
namespace L12_OOP_12.Models
{
    public class StringClass : IStringOperations, IComparable, ICloneable
    {
        public string characters;
        protected byte length;

        protected void UpdateLength() => length = (byte)characters.Length;

        public StringClass() { characters = string.Empty; length = 0; }
        public StringClass(string str) { characters = str; UpdateLength(); }
        public StringClass(char character) { characters = character.ToString(); UpdateLength(); }

        public byte GetLength() => length;
        public void Clear() { characters = string.Empty; length = 0; }
        public virtual string Display() => $"String: {characters}, Length: {length}";

        public void ReverseString()
        {
            char[] charArray = characters.ToCharArray();
            Array.Reverse(charArray);
            characters = new string(charArray);
            UpdateLength();
        }

        public void AppendString(string str)
        {
            characters += str;
            UpdateLength();
        }

        public int CompareTo(object obj)
        {
            if (obj is StringClass other)
                return string.Compare(this.characters, other.characters, StringComparison.Ordinal);
            throw new ArgumentException("Object is not a StringClass");
        }

        public object Clone()
        {
            return new StringClass(this.characters);
        }

        public override string ToString()
        {
            return characters;
        }
    }
}


