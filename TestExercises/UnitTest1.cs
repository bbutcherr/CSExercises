using CSExercises;

namespace TestExercises
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestLastCharAdd()
        {
            string input = "red";
            var bascAlgo = new BasicAlgo();
            var returned = bascAlgo.LastCharAdd(input);
            Assert.AreEqual(returned, "dredd");


        }
        [Test]
        public void AreInRange()
        {
            var basicAlgo = new BasicAlgo();
            int inputX = 41;
            int inputY = 45;

           var areInRange =  basicAlgo.AreInRange(inputX, inputY);
            Assert.IsTrue(areInRange);
        }

        [Test]
        public void CreateStringLike()
        {
            var basicAlgo = new BasicAlgo();
            var inputString = "abcd";
            var returnedString = basicAlgo.CreateStringLikeaababcabcd(inputString);
            Assert.AreEqual(returnedString, "aababcabcd");
        }

        [Test]
        public void SumOfTwoBasicAlgoQ40()
        {
            var basicAlgo = new BasicAlgo();
            var result =  basicAlgo.SumOfTwoQ40(2, 17);
            Assert.That(result, Is.EqualTo(30)); 
        }

        [Test]
        public void ISRightMostSameQ50()
        {
            var basicAlgo = new BasicAlgo();
            var numberList = new List<int> { 11, 2121, 31, 4011 };
            var result = basicAlgo.IsRightMostSameQ50(numberList);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test] 
        public void CreateAStringQ60()
        {
            var basicAlgo = new BasicAlgo();
            var result = basicAlgo.CreateANewStringQ60("Hi", "Hello");
            Assert.That(result, Is.EqualTo("HiHelloHelloHi"));
        }

        [Test]
        public void CreateNewStringWOFirstAndLastQ70()
        {
            var basicAlgo = new BasicAlgo();
            var result = basicAlgo.CreateNewStringWOFirstAndLastQ70("Hello");
            Assert.That(result, Is.EqualTo("ell"));
        }

        [Test]
        public void IsStringStartsWithAbcOrXyzQ80()
        {
            var basicAlgo = new BasicAlgo();
            var result = basicAlgo.IsStringStartsWithAbcOrXyzQ80("xyzsder");
            Assert.That(result, Is.EqualTo("xyz"));
        }

        [Test]
        public void IsTwoArraysHaveSameFirstOrLastQ90()
        {
            var basicAlgo = new BasicAlgo();
            var array1 = new List<int> { 10, 20, 40, 50 };
            var array2 = new List<int> { 10, 20, 40, 5 };
            var result = basicAlgo.IsTwoArraysHaveSameFirstOrLastQ90(array1, array2);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void IsArrayHas10Or20TwiceQ100()
        {
            var basicAlgo = new BasicAlgo();
            var numberList = new List<int> { 10, 10 };
            var result = basicAlgo.IsArrayHas10Or20TwiceQ100(numberList);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void SumIfNot17Q110()
        {
            var basicAlgo = new BasicAlgo();
            var numberList = new List<int> { 1, 5, 7, 9, 10, 17 };
            var result = basicAlgo.SumIfNot17Q110(numberList);
            Assert.That(result, Is.EqualTo(32));
        }

        [Test]
        public void CheckIf5NextToEachOther()
        {
            var basicAlgo = new BasicAlgo();
            var numberList = new List<int> { 1, 5, 5, 7, 8, 10 };

            var result = basicAlgo.CheckIf5NextToEachOther120(numberList);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ShiftAllZerosToLeft()
        {
            var basicAlgo = new BasicAlgo();
            var numberList = new List<int> { 1, 2, 0, 3, 5, 7, 0, 9, 11 };

            var result = basicAlgo.ShiftAllZerosToLeftQ130(numberList);
            var expected = new List<int> { 0, 0, 1, 2, 3, 5, 7, 9, 11 };
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CreateNewOddArrayQ140()
        {
            var basicAlgo = new BasicAlgo();
            var numberList = new List<int> { 1, 2, 3, 5, 7, 9, 10 };
            var length = 3;
            var result = basicAlgo.CreateNewOddArrayQ140(numberList, length);
            Assert.That(result, Is.EqualTo(new List<int> { 1, 3, 5 }));
        }

        [Test]
        public void CreateListExceptEndWith7Q150()
        {
            var basicAlgo = new BasicAlgo();
            var numberList = new List<int> { 10, 22, 35, 47, 53, 67 };
            var expected = new List<int> { 10, 22, 35, 53 };
            var output = basicAlgo.CreateListExceptEndWith7Q150(numberList);
            Assert.That(output, Is.EqualTo(expected));
        }
    }
}