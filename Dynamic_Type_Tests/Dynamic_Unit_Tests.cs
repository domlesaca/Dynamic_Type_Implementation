using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynamicTesting;

namespace Dynamic_Type_Tests
{
    [TestClass]
    public class Dynamic_Unit_Tests
    {
        [TestMethod]
        public void PlusOperationTestString()
        {
            DynamicType myString = "hello";
            DynamicType myInt = 5;
            DynamicType myDoub = 1.1;
            DynamicType myChar = 'a';
            DynamicType myBool = true;
            DynamicType myString2 = " world";

            Assert.AreEqual("hello" + 5, (myString + myInt).myValue);
            Assert.AreEqual("hello" + " world", (myString + myString2).myValue);
            Assert.AreEqual("hello" + 1.1, (myString + myDoub).myValue);
            Assert.AreEqual("hello" + 'a', (myString + myChar).myValue);
            Assert.AreEqual("hello" + true, (myString + myBool).myValue);
        }
        
        [TestMethod]
        public void PlusOperationTestInts()
        {
            DynamicType myInt1 = 10;
            DynamicType myInt2 = 11;
            Assert.AreEqual(21, (myInt1 + myInt2).myValue);
            Assert.AreEqual(21, (10 + myInt2).myValue);
            Assert.AreEqual(21, (myInt1 + 11).myValue);
        }

        [TestMethod]
        public void PlusOperationTestDoubs()
        {
            DynamicType myInt1 = 10.1;
            DynamicType myInt2 = 11.1;
            Assert.AreEqual(21.2, (myInt1 + myInt2).myValue);
            Assert.AreEqual(21.2, (10.1 + myInt2).myValue);
            Assert.AreEqual(21.2, (myInt1 + 11.1).myValue);
        }

        [TestMethod]
        public void PlusOperationTestChars()
        {
            DynamicType myChar1 = 'a';
            DynamicType myChar2 = 'b';
            Assert.AreEqual('a' + 'b', (myChar1 + myChar2).myValue);
            Assert.AreEqual('a' + 'b', ('a' + myChar2).myValue);
            Assert.AreEqual('a' + 'b', (myChar1 + 'b').myValue);
        }

        [TestMethod]
        public void PlusOperationTestIntDoub()
        {
            DynamicType myInt1 = 10;
            DynamicType myInt2 = 11.1;
            Assert.AreEqual(21.1, (myInt1 + myInt2).myValue);
            Assert.AreEqual(21.1, (10 + myInt2).myValue);
            Assert.AreEqual(21.1, (myInt1 + 11.1).myValue);
        }

        [TestMethod]
        public void PlusOperationTestCharInt()
        {
            DynamicType myChar1 = 'a';
            DynamicType myint = 5;
            Assert.AreEqual('a' + 5, (myChar1 + myint).myValue);
            Assert.AreEqual('a' + 5, ('a' + myint).myValue);
            Assert.AreEqual('a' + 5, (myChar1 + 5).myValue);
        }

        [TestMethod]
        public void PlusOperationTestCharDoub()
        {
            DynamicType myChar1 = 'a';
            DynamicType myDoub = 5.1;
            Assert.AreEqual('a' + 5.1, (myChar1 + myDoub).myValue);
            Assert.AreEqual('a' + 5.1, ('a' + myDoub).myValue);
            Assert.AreEqual('a' + 5.1, (myChar1 + 5.1).myValue);
        }

        [TestMethod]
        public void MinusOperationTestInts()
        {
            DynamicType myInt1 = 10;
            DynamicType myInt2 = 11;
            Assert.AreEqual(-1, (myInt1 - myInt2).myValue);
            Assert.AreEqual(-1, (10 - myInt2).myValue);
            Assert.AreEqual(-1, (myInt1 - 11).myValue);
        }

        [TestMethod]
        public void MinsOperationTestDoubs()
        {
            DynamicType myInt1 = 10.1;
            DynamicType myInt2 = 11.1;
            Assert.AreEqual(-1.0, (myInt1 - myInt2).myValue);
            Assert.AreEqual(-1.0, (10.1 - myInt2).myValue);
            Assert.AreEqual(-1.0, (myInt1 - 11.1).myValue);
        }

        [TestMethod]
        public void MinusOperationTestChars()
        {
            DynamicType myChar1 = 'a';
            DynamicType myChar2 = 'b';
            Assert.AreEqual('a' - 'b', (myChar1 - myChar2).myValue);
            Assert.AreEqual('a' - 'b', ('a' - myChar2).myValue);
            Assert.AreEqual('a' - 'b', (myChar1 - 'b').myValue);
        }

        [TestMethod]
        public void MinusOperationTestIntDoub()
        {
            DynamicType myInt1 = 10;
            DynamicType myInt2 = 5.1;
            Assert.AreEqual(4.9, (myInt1 - myInt2).myValue);
            Assert.AreEqual(4.9, (10 - myInt2).myValue);
            Assert.AreEqual(4.9, (myInt1 - 5.1).myValue);
        }

        [TestMethod]
        public void MinusOperationTestCharInt()
        {
            DynamicType myChar1 = 'a';
            DynamicType myint = 5;
            Assert.AreEqual('a' - 5, (myChar1 - myint).myValue);
            Assert.AreEqual('a' - 5, ('a' - myint).myValue);
            Assert.AreEqual('a' - 5, (myChar1 - 5).myValue);
        }

        [TestMethod]
        public void MinusOperationTestCharDoub()
        {
            DynamicType myChar1 = 'a';
            DynamicType myDoub = 5.1;
            Assert.AreEqual('a' - 5.1, (myChar1 - myDoub).myValue);
            Assert.AreEqual('a' - 5.1, ('a' - myDoub).myValue);
            Assert.AreEqual('a' - 5.1, (myChar1 - 5.1).myValue);
        }

        [TestMethod]
        public void MultOperationTestInts()
        {
            DynamicType myInt1 = 10;
            DynamicType myInt2 = 11;
            Assert.AreEqual(110, (myInt1 * myInt2).myValue);
            Assert.AreEqual(110, (10 * myInt2).myValue);
            Assert.AreEqual(110, (myInt1 * 11).myValue);
        }

        [TestMethod]
        public void MultOperationTestDoubs()
        {
            DynamicType myInt1 = 10.0;
            DynamicType myInt2 = 11.1;
            Assert.AreEqual(111.0, (myInt1 * myInt2).myValue);
            Assert.AreEqual(111.0, (10.0 * myInt2).myValue);
            Assert.AreEqual(111.0, (myInt1 * 11.1).myValue);
        }

        [TestMethod]
        public void MultOperationTestChars()
        {
            DynamicType myChar1 = 'a';
            DynamicType myChar2 = 'b';
            Assert.AreEqual('a' * 'b', (myChar1 * myChar2).myValue);
            Assert.AreEqual('a' * 'b', ('a' * myChar2).myValue);
            Assert.AreEqual('a' * 'b', (myChar1 * 'b').myValue);
        }

        [TestMethod]
        public void MultOperationTestIntDoub()
        {
            DynamicType myInt1 = 10;
            DynamicType myInt2 = 11.1;
            Assert.AreEqual(111.0, (myInt1 * myInt2).myValue);
            Assert.AreEqual(111.0, (10 * myInt2).myValue);
            Assert.AreEqual(111.0, (myInt1 * 11.1).myValue);
        }

        [TestMethod]
        public void MultOperationTestCharInt()
        {
            DynamicType myChar1 = 'a';
            DynamicType myint = 5;
            Assert.AreEqual('a' * 5, (myChar1 * myint).myValue);
            Assert.AreEqual('a' * 5, ('a' * myint).myValue);
            Assert.AreEqual('a' * 5, (myChar1 * 5).myValue);
        }

        [TestMethod]
        public void MultOperationTestCharDoub()
        {
            DynamicType myChar1 = 'a';
            DynamicType myDoub = 5.1;
            Assert.AreEqual('a' * 5.1, (myChar1 * myDoub).myValue);
            Assert.AreEqual('a' * 5.1, ('a' * myDoub).myValue);
            Assert.AreEqual('a' * 5.1, (myChar1 * 5.1).myValue);
        }

        [TestMethod]
        public void DivOperationTestInts()
        {
            DynamicType myInt1 = 10;
            DynamicType myInt2 = 5;
            Assert.AreEqual(2, (myInt1 / myInt2).myValue);
            Assert.AreEqual(2, (10 / myInt2).myValue);
            Assert.AreEqual(2, (myInt1 / 5).myValue);
        }

        [TestMethod]
        public void DivOperationTestDoubs()
        {
            DynamicType myInt1 = 10.0;
            DynamicType myInt2 = 5.0;
            Assert.AreEqual(2.0, (myInt1 / myInt2).myValue);
            Assert.AreEqual(2.0, (10.0 / myInt2).myValue);
            Assert.AreEqual(2.0, (myInt1 / 5.0).myValue);
        }

        [TestMethod]
        public void DivOperationTestChars()
        {
            DynamicType myChar1 = 'a';
            DynamicType myChar2 = 'b';
            Assert.AreEqual('a' / 'b', (myChar1 / myChar2).myValue);
            Assert.AreEqual('a' / 'b', ('a' / myChar2).myValue);
            Assert.AreEqual('a' / 'b', (myChar1 / 'b').myValue);
        }

        [TestMethod]
        public void DivOperationTestIntDoub()
        {
            DynamicType myInt1 = 10;
            DynamicType myInt2 = 5.0;
            Assert.AreEqual(2.0, (myInt1 / myInt2).myValue);
            Assert.AreEqual(2.0, (10 / myInt2).myValue);
            Assert.AreEqual(2.0, (myInt1 / 5.0).myValue);
        }

        [TestMethod]
        public void DivOperationTestCharInt()
        {
            DynamicType myChar1 = 'a';
            DynamicType myint = 5;
            Assert.AreEqual('a' / 5, (myChar1 / myint).myValue);
            Assert.AreEqual('a' / 5, ('a' / myint).myValue);
            Assert.AreEqual('a' / 5, (myChar1 / 5).myValue);
        }

        [TestMethod]
        public void DivOperationTestCharDoub()
        {
            DynamicType myChar1 = 'a';
            DynamicType myDoub = 5.1;
            Assert.AreEqual('a' / 5.1, (myChar1 / myDoub).myValue);
            Assert.AreEqual('a' / 5.1, ('a' / myDoub).myValue);
            Assert.AreEqual('a' / 5.1, (myChar1 / 5.1).myValue);
        }

        [TestMethod]
        public void ModOperationTestInts()
        {
            DynamicType myInt1 = 10;
            DynamicType myInt2 = 5;
            Assert.AreEqual(0, (myInt1 % myInt2).myValue);
            Assert.AreEqual(0, (10 % myInt2).myValue);
            Assert.AreEqual(0, (myInt1 % 5).myValue);
        }

        [TestMethod]
        public void ModOperationTestDoubs()
        {
            DynamicType myInt1 = 10.0;
            DynamicType myInt2 = 5.0;
            Assert.AreEqual(0.0, (myInt1 % myInt2).myValue);
            Assert.AreEqual(0.0, (10.0 % myInt2).myValue);
            Assert.AreEqual(0.0, (myInt1 % 5.0).myValue);
        }

        [TestMethod]
        public void ModOperationTestChars()
        {
            DynamicType myChar1 = 'a';
            DynamicType myChar2 = 'b';
            Assert.AreEqual('a' % 'b', (myChar1 % myChar2).myValue);
            Assert.AreEqual('a' % 'b', ('a' % myChar2).myValue);
            Assert.AreEqual('a' % 'b', (myChar1 % 'b').myValue);
        }

        [TestMethod]
        public void ModOperationTestIntDoub()
        {
            DynamicType myInt1 = 10;
            DynamicType myInt2 = 5.0;
            Assert.AreEqual(0.0, (myInt1 % myInt2).myValue);
            Assert.AreEqual(0.0, (10 % myInt2).myValue);
            Assert.AreEqual(0.0, (myInt1 % 5.0).myValue);
        }

        [TestMethod]
        public void ModOperationTestCharInt()
        {
            DynamicType myChar1 = 'a';
            DynamicType myint = 5;
            Assert.AreEqual('a' % 5, (myChar1 % myint).myValue);
            Assert.AreEqual('a' % 5, ('a' % myint).myValue);
            Assert.AreEqual('a' % 5, (myChar1 % 5).myValue);
        }

        [TestMethod]
        public void ModOperationTestCharDoub()
        {
            DynamicType myChar1 = 'a';
            DynamicType myDoub = 5.1;
            Assert.AreEqual('a' % 5.1, (myChar1 % myDoub).myValue);
            Assert.AreEqual('a' % 5.1, ('a' % myDoub).myValue);
            Assert.AreEqual('a' % 5.1, (myChar1 % 5.1).myValue);
        }

        [TestMethod]
        public void BooleanTest()
        {
            DynamicType myTrue = true;
            DynamicType myFalse = false;

            if (myTrue) { }
            else { Assert.Fail("DynamicType true overload failed"); }

            if (myFalse) { Assert.Fail("DynamicType false overload failed"); }
        }

        [TestMethod]
        public void NotOperatorTest()
        {
            DynamicType myTrue = true;

            if (!myTrue) { Assert.Fail("DynamicType ! overload failed"); }
        }

        [TestMethod]
        public void AndOperatorTest()
        {
            DynamicType myTrue = true;
            DynamicType myFalse = false;

            if (myTrue & myTrue) { }
            else { Assert.Fail("DynamicType & overload failed on True, True"); }

            if (myTrue & myFalse) { Assert.Fail("DynamicType & overload failed on True, False"); }

            if (myFalse & myTrue) { Assert.Fail("DynamicType & overload failed on False, True"); }

            if (myFalse & myFalse) { Assert.Fail("DynamicType & overload failed on False, False"); }
        }

        [TestMethod]
        public void OrOperatorTest()
        {
            DynamicType myTrue = true;
            DynamicType myFalse = false;

            if (myTrue | myTrue) { }
            else { Assert.Fail("DynamicType & overload failed on True, True"); }

            if (myTrue | myFalse) { }
            else { Assert.Fail("DynamicType & overload failed on True, False"); }

            if (myFalse | myTrue) { }
            else { Assert.Fail("DynamicType & overload failed on False, True"); }

            if (myFalse | myFalse) { Assert.Fail("DynamicType & overload failed on False, False"); }
        }

        [TestMethod]
        public void EqualNotEqualOperatorTestInt()
        {
            DynamicType myInt1 = 7;
            DynamicType myInt2 = 6;

            Assert.IsTrue((bool)(myInt1 == myInt1));
            Assert.IsTrue((bool)(myInt1 != myInt2));
            Assert.IsTrue((bool)(myInt1 == myInt1.myValue));
            Assert.IsTrue((bool)(myInt1 != 2));
        }

        [TestMethod]
        public void EqualNotEqualOperatorTestDoub()
        {
            DynamicType myInt1 = 7.1;
            DynamicType myInt2 = 6.2;

            Assert.IsTrue((bool)(myInt1 == myInt1));
            Assert.IsTrue((bool)(myInt1 != myInt2));
            Assert.IsTrue((bool)(myInt1 == myInt1.myValue));
            Assert.IsTrue((bool)(myInt1 != 2));
        }

        [TestMethod]
        public void EqualNotEqualOperatorTestChar()
        {
            DynamicType myInt1 = 'a';
            DynamicType myInt2 = 'b';

            Assert.IsTrue((bool)(myInt1 == myInt1));
            Assert.IsTrue((bool)(myInt1 != myInt2));
            Assert.IsTrue((bool)(myInt1 == myInt1.myValue));
            Assert.IsTrue((bool)(myInt1 != 'c'));
        }

        [TestMethod]
        public void EqualNotEqualOperatorTestIntChar()
        {
            DynamicType myInt1 = (int)'a';
            DynamicType myInt2 = 'a';
            Assert.IsTrue((bool)(myInt1 != myInt2));
            Assert.IsTrue((bool)(myInt1 == myInt1.myValue));
        }

        [TestMethod]
        public void EqualNotEqualOperatorTestIntDoub()
        {
            DynamicType myInt1 = (double)'a';
            DynamicType myInt2 = 'a';

            Assert.IsTrue((bool)(myInt1 != myInt2));
            Assert.IsTrue((bool)(myInt1 == myInt1.myValue));
        }

        [TestMethod]
        public void LessThanOperatorTestInt()
        {
            DynamicType myInt1 = 1;
            DynamicType myInt2 = 7;

            Assert.IsTrue((bool)(myInt1 < myInt2));
            Assert.IsFalse((bool)(myInt2 < myInt1));
            Assert.IsTrue((bool)(myInt1 < 2));
            Assert.IsFalse((bool)(myInt2 < 1));
            Assert.IsTrue((bool)(myInt1 <= myInt1));
            Assert.IsTrue((bool)(myInt1 <= 1));
        }

        [TestMethod]
        public void GreaterThanOperatorTestInt()
        {
            DynamicType myInt1 = 7;
            DynamicType myInt2 = 1;

            Assert.IsTrue((bool)(myInt1 > myInt2));
            Assert.IsFalse((bool)(myInt2 > myInt1));
            Assert.IsTrue((bool)(myInt1 > 2));
            Assert.IsFalse((bool)(myInt2 > 1));
            Assert.IsTrue((bool)(myInt1 >= myInt1));
            Assert.IsTrue((bool)(myInt1 >= 1));
        }

        [TestMethod]
        public void ArrayTest()
        {
            DynamicType myArr = new int[] { 5, 7 };
            Assert.AreEqual(5, myArr[0].myValue);
        }

        [TestMethod]
        public void TypeChangeTest()
        {
            DynamicType temp = 6;
            var type1 = temp.myType;
            temp = "fgdsf";
            var type2 = temp.myType;
            Assert.AreNotEqual(type1, type2);
        }

        [TestMethod]
        public void TypeCastTest()
        {
            DynamicType temp = 6;
            int temp1 = (int)temp;
            temp = 3.0;
            double temp2 = (double)temp;
            temp = 'c';
            char temp3 = (char)temp;
            temp = "hello";
            string temp4 = temp.ToString();
            temp = true;
            bool temp5 = (bool)temp;
        }

        [TestMethod]
        public void TypeCastArrayTest()
        {
            DynamicType temp = new int[] { 6 };
            int[] temp1 = (int[])temp;
            temp = new double[] { 3.0 };
            double[] temp2 = (double[])temp;
            temp = new char[] { 'c' };
            char[] temp3 = (char[])temp;
            temp = new string[] { "hello" };
            string[] temp4 = (string[])temp;
            temp = new bool[] { true };
            bool[] temp5 = (bool[])temp;
        }

        [TestMethod]
        public void ArrayModifyAtIndexTest()
        {
            DynamicType temp = new int[] { 6, 10 };
            Assert.AreEqual(10, (int)temp[1]);
            temp[1] = 11;
            Assert.AreEqual(11, (int)temp[1]);

        }

        [TestMethod]
        public void ObjectInstantiateTest()
        {
            DynamicType obj = new DynamicType(new woop("hello"));
        }

        [TestMethod]
        public void ObjectFieldTest()
        {
            string word = "hello";
            string word1 = "bye";
            DynamicType obj = new DynamicType(new woop(word));

            Assert.AreEqual(word, obj.getField("word").myValue);
            obj.setField("word", word1);
            Assert.AreEqual(word1, obj.getField("word").myValue);
        }

        [TestMethod]
        public void ObjectMethodTest()
        {
            string word = "hello";
            int num = 5;
            DynamicType obj = new DynamicType(new woop(word));

            Assert.AreEqual(num, obj.runMethod("fizz", new object[] { num }).myValue);
            Assert.AreEqual(word + num, obj.getField("word").myValue);
        }

        [TestMethod]
        public void EqualsTest()
        {
            Assert.IsTrue((new DynamicType(5)).Equals(new DynamicType(5)));
            Assert.IsTrue((new DynamicType(5)).Equals(5));
            Assert.IsFalse((new DynamicType(5)).Equals(new DynamicType(4)));
            Assert.IsFalse((new DynamicType(5)).Equals(4));
        }

        [TestMethod]
        public void HashCodeTest()
        {
            var temp = new DynamicType(5);
            Assert.AreEqual(temp.GetHashCode(), temp.GetHashCode());
        }
    }
}
