//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections;
using System.Collections.Generic;

namespace DynamicTesting
{

    public class DynamicType
    {
        public Type myType { get; private set; }
        public object myValue { get; private set; }

        public DynamicType(object _value)
        {
            myValue = _value;
            myType = _value.GetType();
        }

        public DynamicType getField(string fieldName)
        {
            return new DynamicType(myType.GetField(fieldName).GetValue(myValue));
        }

        public void setField(string fieldName, object value)
        {
            myType.GetField(fieldName).SetValue(myValue, value);
        }

        public DynamicType runMethod(string methodName, object?[]? parameters = null)
        {
            return new DynamicType(myType.GetMethod(methodName).Invoke(myValue, parameters));
        }

        public static DynamicType operator +(DynamicType a, DynamicType b)
        {
            if (a.myType.Equals(typeof(string)) || b.myType.Equals(typeof(string)))
            {
                if (a.myType.Equals(typeof(bool)))
                    return new DynamicType((bool)a.myValue + b.myValue.ToString());
                else if (b.myType.Equals(typeof(bool)))
                    return new DynamicType(a.myValue.ToString() + (bool)b.myValue);
                else
                    return new DynamicType(a.myValue.ToString() + b.myValue.ToString());
            }
            else if (a.myType.Equals(typeof(double)) && (b.myType.Equals(typeof(int)) || b.myType.Equals(typeof(char))))
            {
                return new DynamicType((double)a.myValue + Convert.ToInt32(b.myValue));
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) + (double)b.myValue);
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && (b.myType.Equals(typeof(int)) || b.myType.Equals(typeof(char))))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) + Convert.ToInt32(b.myValue));
            }
            else if (a.myType.Equals(typeof(double)) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType((double)a.myValue + (double)b.myValue);
            }
            else
            {
                throw new InvalidOperationException($"Operator + not valid on Types {a.myType} and {b.myType}");
            }
        }

        public static DynamicType operator +(DynamicType a, object b)
        {
            return a + new DynamicType(b);
        }

        public static DynamicType operator +(object a, DynamicType b)
        {
            return new DynamicType(a) + b;
        }

        public static DynamicType operator -(DynamicType a, DynamicType b)
        {
            if (a.myType.Equals(typeof(double)) && (b.myType.Equals(typeof(int)) || b.myType.Equals(typeof(char))))
            {
                return new DynamicType((double)a.myValue - Convert.ToInt32(b.myValue));
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) - (double)b.myValue);
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && (b.myType.Equals(typeof(int)) || b.myType.Equals(typeof(char))))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) - Convert.ToInt32(b.myValue));
            }
            else if (a.myType.Equals(typeof(double)) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType((double)a.myValue - (double)b.myValue);
            }
            else
            {
                throw new InvalidOperationException($"Operator - not valid on Types {a.myType} and {b.myType}");
            }
        }

        public static DynamicType operator -(DynamicType a, object b)
        {
            return a - new DynamicType(b);
        }

        public static DynamicType operator -(object a, DynamicType b)
        {
            return new DynamicType(a) - b;
        }

        public static DynamicType operator *(DynamicType a, DynamicType b)
        {
            if (a.myType.Equals(typeof(double)) && (b.myType.Equals(typeof(int)) || b.myType.Equals(typeof(char))))
            {
                return new DynamicType((double)a.myValue * Convert.ToInt32(b.myValue));
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) * (double)b.myValue);
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && (b.myType.Equals(typeof(int)) || b.myType.Equals(typeof(char))))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) * Convert.ToInt32(b.myValue));
            }
            else if (a.myType.Equals(typeof(double)) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType((double)a.myValue * (double)b.myValue);
            }
            else
            {
                throw new InvalidOperationException($"Operator * not valid on Types {a.myType} and {b.myType}");
            }
        }

        public static DynamicType operator *(DynamicType a, object b)
        {
            return a * new DynamicType(b);
        }

        public static DynamicType operator *(object a, DynamicType b)
        {
            return new DynamicType(a) * b;
        }

        public static DynamicType operator /(DynamicType a, DynamicType b)
        {
            if (a.myType.Equals(typeof(double)) && (b.myType.Equals(typeof(int)) || b.myType.Equals(typeof(char))))
            {
                return new DynamicType((double)a.myValue / Convert.ToInt32(b.myValue));
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) / (double)b.myValue);
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && (b.myType.Equals(typeof(int)) || b.myType.Equals(typeof(char))))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) / Convert.ToInt32(b.myValue));
            }
            else if (a.myType.Equals(typeof(double)) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType((double)a.myValue / (double)b.myValue);
            }
            else
            {
                throw new InvalidOperationException($"Operator / not valid on Types {a.myType} and {b.myType}");
            }
        }

        public static DynamicType operator /(DynamicType a, object b)
        {
            return a / new DynamicType(b);
        }

        public static DynamicType operator /(object a, DynamicType b)
        {
            return new DynamicType(a) / b;
        }

        public static DynamicType operator %(DynamicType a, DynamicType b)
        {
            if (a.myType.Equals(typeof(double)) && (b.myType.Equals(typeof(int)) || b.myType.Equals(typeof(char))))
            {
                return new DynamicType((double)a.myValue % Convert.ToInt32(b.myValue));
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) % (double)b.myValue);
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && (b.myType.Equals(typeof(int)) || b.myType.Equals(typeof(char))))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) % Convert.ToInt32(b.myValue));
            }

            else if (a.myType.Equals(typeof(double)) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType((double)a.myValue % (double)b.myValue);
            }
            else
            {
                throw new InvalidOperationException($"Operator * not valid on Types {a.myType} and {b.myType}");
            }
        }

        public static DynamicType operator %(DynamicType a, object b)
        {
            return a % new DynamicType(b);
        }

        public static DynamicType operator %(object a, DynamicType b)
        {
            return new DynamicType(a) % b;
        }

        public static DynamicType operator &(DynamicType a, DynamicType b)
        {
            if (a.myType.Equals(typeof(bool)) && a.myType.Equals(typeof(bool)))
            {
                return new DynamicType((bool)a.myValue & (bool)b.myValue);
            }
            else
            {
                throw new InvalidOperationException($"Operator && not valid on Types {a.myType} and {b.myType}");
            }
        }

        public static bool operator true(DynamicType a)
        {
            if (a.myType.Equals(typeof(bool)))
            {
                if ((bool)a.myValue == true)
                    return true;
                else
                    return false;
            }
            else
                throw new InvalidOperationException($"Type {a.myType} cannot be resolved to Boolean");
        }

        public static bool operator false(DynamicType a)
        {
            if (a.myType.Equals(typeof(bool)))
            {
                if ((bool)a.myValue == true)
                    return true;
                else
                    return false;
            }
            else
                throw new InvalidOperationException($"Type {a.myType} cannot be resolved to Boolean");
        }

        public static DynamicType operator &(DynamicType a, object b)
        {
            return a & new DynamicType(b);
        }

        public static DynamicType operator &(object a, DynamicType b)
        {
            return new DynamicType(a) & b;
        }

        public static DynamicType operator |(DynamicType a, DynamicType b)
        {
            if (a.myType.Equals(typeof(bool)) && a.myType.Equals(typeof(bool)))
            {
                return new DynamicType((bool)a.myValue | (bool)b.myValue);
            }
            else
            {
                throw new InvalidOperationException($"Operator && not valid on Types {a.myType} and {b.myType}");
            }
        }

        public static DynamicType operator |(DynamicType a, object b)
        {
            return a | new DynamicType(b);
        }

        public static DynamicType operator |(object a, DynamicType b)
        {
            return new DynamicType(a) | b;
        }

        public static DynamicType operator >(DynamicType a, DynamicType b)
        {
            if (a.myType.Equals(typeof(double)) && (a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))))
            {
                return new DynamicType((double)a.myValue > Convert.ToInt32(b.myValue));
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && a.myType.Equals(typeof(double)))
            {
                return new DynamicType((double)a.myValue > Convert.ToInt32(b.myValue));
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && (a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) > Convert.ToInt32(b.myValue));
            }
            else if (a.myType.Equals(typeof(double)) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType((double)a.myValue > (double)b.myValue);
            }
            else
            {
                throw new InvalidOperationException($"Operator && not valid on Types {a.myType} and {b.myType}");
            }
        }

        public static DynamicType operator >(DynamicType a, object b)
        {
            return a > new DynamicType(b);
        }

        public static DynamicType operator >(object a, DynamicType b)
        {
            return new DynamicType(a) > b;
        }

        public static DynamicType operator <(DynamicType a, DynamicType b)
        {
            if (a.myType.Equals(typeof(double)) && (a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))))
            {
                return new DynamicType((double)a.myValue < Convert.ToInt32(b.myValue));
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && a.myType.Equals(typeof(double)))
            {
                return new DynamicType((double)a.myValue < Convert.ToInt32(b.myValue));
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && (a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) < Convert.ToInt32(b.myValue));
            }
            else if (a.myType.Equals(typeof(double)) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType((double)a.myValue < (double)b.myValue);
            }
            else
            {
                throw new InvalidOperationException($"Operator && not valid on Types {a.myType} and {b.myType}");
            }
        }

        public static DynamicType operator <(DynamicType a, object b)
        {
            return a < new DynamicType(b);
        }

        public static DynamicType operator <(object a, DynamicType b)
        {
            return new DynamicType(a) < b;
        }

        public static DynamicType operator >=(DynamicType a, DynamicType b)
        {
            if (a.myType.Equals(typeof(double)) && (a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))))
            {
                return new DynamicType((double)a.myValue >= Convert.ToInt32(b.myValue));
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && a.myType.Equals(typeof(double)))
            {
                return new DynamicType((double)a.myValue >= Convert.ToInt32(b.myValue));
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && (a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) >= Convert.ToInt32(b.myValue));
            }
            else if (a.myType.Equals(typeof(double)) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType((double)a.myValue >= (double)b.myValue);
            }
            else
            {
                throw new InvalidOperationException($"Operator && not valid on Types {a.myType} and {b.myType}");
            }
        }

        public static DynamicType operator >=(DynamicType a, object b)
        {
            return a >= new DynamicType(b);
        }

        public static DynamicType operator >=(object a, DynamicType b)
        {
            return new DynamicType(a) >= b;
        }

        public static DynamicType operator <=(DynamicType a, DynamicType b)
        {
            if (a.myType.Equals(typeof(double)) && (b.myType.Equals(typeof(int)) || b.myType.Equals(typeof(char))))
            {
                return new DynamicType((double)a.myValue <= Convert.ToInt32(b.myValue));
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType((double)a.myValue <= Convert.ToInt32(b.myValue));
            }
            else if ((a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char))) && (b.myType.Equals(typeof(int)) || b.myType.Equals(typeof(char))))
            {
                return new DynamicType(Convert.ToInt32(a.myValue) <= Convert.ToInt32(b.myValue));
            }
            else if (a.myType.Equals(typeof(double)) && b.myType.Equals(typeof(double)))
            {
                return new DynamicType((double)a.myValue <= (double)b.myValue);
            }
            else
            {
                throw new InvalidOperationException($"Operator <= not valid on Types {a.myType} and {b.myType}");
            }
        }

        public static DynamicType operator <=(DynamicType a, object b)
        {
            return a <= new DynamicType(b);
        }

        public static DynamicType operator <=(object a, DynamicType b)
        {
            return new DynamicType(a) <= b;
        }

        public static DynamicType operator !(DynamicType a)
        {
            if (a.myType.Equals(typeof(bool)) && a.myType.Equals(typeof(bool)))
            {
                return new DynamicType(!(bool)a.myValue);
            }
            else
            {
                throw new InvalidOperationException($"Operator ! not valid on Type {a.myType}");
            }
        }

        public static DynamicType operator ==(DynamicType a, DynamicType b)
        {
            return new DynamicType(a.myValue == b.myValue);
        }

        public static DynamicType operator ==(DynamicType a, object b)
        {
            return a == new DynamicType(b);
        }

        public static DynamicType operator ==(object a, DynamicType b)
        {
            return new DynamicType(a) == b;
        }

        public static DynamicType operator !=(DynamicType a, DynamicType b)
        {
            return new DynamicType(a.myValue != b.myValue);
        }

        public static DynamicType operator !=(DynamicType a, object b)
        {
            return a != new DynamicType(b);
        }

        public static DynamicType operator !=(object a, DynamicType b)
        {
            return new DynamicType(a) == b;
        }

        public DynamicType this[int index]
        {
            get { return new DynamicType(((Array)myValue).GetValue(index)); }
            set { ((Array)myValue).SetValue(value.myValue,index); }
        }

        /*
         * The following methods implement casting from DynamicType to other types
         */

        public static explicit operator int(DynamicType a)
        {
            if (a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char)))
                return Convert.ToInt32(a.myValue);
            else
                throw new InvalidOperationException($"Type {a.myType} cannot convert to type int.");
        }

        public static explicit operator char(DynamicType a)
        {
            if (a.myType.Equals(typeof(int)) || a.myType.Equals(typeof(char)))
                return (char)a.myValue;
            else
                throw new InvalidOperationException($"Type {a.myType} cannot convert to type char.");
        }

        public static explicit operator double(DynamicType a)
        {
            if (a.myType.Equals(typeof(double)))
                return (double)a.myValue;
            else
                throw new InvalidOperationException($"Type {a.myType} cannot convert to type double.");
        }

        public static explicit operator bool(DynamicType a)
        {
            if (a.myType.Equals(typeof(bool)))
                return (bool)a.myValue;
            else
                throw new InvalidOperationException($"Type {a.myType} cannot convert to type bool.");
        }

        public static explicit operator int[](DynamicType a)
        {
            if (a.myType.Equals(typeof(int[])))
                return (int[])a.myValue;
            else
                throw new InvalidOperationException($"Type {a.myType} cannot convert to type int[].");
        }

        public static explicit operator char[](DynamicType a)
        {
            if (a.myType.Equals(typeof(char[])))
                return (char[])a.myValue;
            else
                throw new InvalidOperationException($"Type {a.myType} cannot convert to type char[].");
        }

        public static explicit operator double[](DynamicType a)
        {
            if (a.myType.Equals(typeof(double[])))
                return (double[])a.myValue;
            else
                throw new InvalidOperationException($"Type {a.myType} cannot convert to type double[].");
        }

        public static explicit operator bool[](DynamicType a)
        {
            if (a.myType.Equals(typeof(bool[])))
                return (bool[])a.myValue;
            else
                throw new InvalidOperationException($"Type {a.myType} cannot convert to type bool[].");
        }

        public static explicit operator string[](DynamicType a)
        {
            if (a.myType.Equals(typeof(string[])))
                return (string[])a.myValue;
            else
                throw new InvalidOperationException($"Type {a.myType} cannot convert to type string[].");
        }

        /*
         * The following methods convert from base types to DynamicType.
         * This does not inlcude conversions from user defined classes to Dynamic Type.
         */

        public static implicit operator DynamicType(int a) => new DynamicType(a);
        public static implicit operator DynamicType(bool a) => new DynamicType(a);
        public static implicit operator DynamicType(char a) => new DynamicType(a);
        public static implicit operator DynamicType(string a) => new DynamicType(a);
        public static implicit operator DynamicType(double a) => new DynamicType(a);
        public static implicit operator DynamicType(int[] a) => new DynamicType(a);
        public static implicit operator DynamicType(bool[] a) => new DynamicType(a);
        public static implicit operator DynamicType(char[] a) => new DynamicType(a);
        public static implicit operator DynamicType(string[] a) => new DynamicType(a);
        public static implicit operator DynamicType(double[] a) => new DynamicType(a);

        /*
         * The following methods override base methods for the object class.
         */

        public override string ToString()
        {
            return myValue.ToString();
        }

        public bool Equals(DynamicType a)
        {
            return myValue.Equals(a.myValue);
        }

        public override bool Equals(object obj)
        {
            return myValue.Equals(obj);
        }

        public override int GetHashCode()
        {
            return myValue.GetHashCode();
        }
    }

    public class woop
    {
        public string word;

        public woop(string input)
        {
            word = input;
        }

        public override string ToString()
        {
            return word;
        }

        public int fizz(int input)
        {
            word += input;
            return input;
        }
    }

    public class Dynamic
    {
        public static void Main(string[] args) {  }
    }
}