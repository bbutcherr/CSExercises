using CSExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercises
{
    public class LinqTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShowHowQueryWorksQ1()
        {
            var linq = new LinqMethods();
            var input = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            var output = linq.ShowHowQueryWorksQ1(input);
            var expected = new List<int> { 0, 2, 4, 6, 8 };
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void SquareTheArrayQ2()
        {
            var linq = new LinqMethods();
            var input = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var output = linq.SquareTheArrayLessThan20Q2(input);
            var expected = new List<int> { 0, 1, 2, 3, 4 };
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void FindFrequencyQ4()
        {
            var linq = new LinqMethods();
            var input = new List<int> { 5, 5, 9 ,5, 1, 9 };
            var output =  linq.FindFrequencyQ4(input);
            var expected = new List<Tuple<int, int>>();
            expected.Add(new Tuple<int, int>(5, 3));
            expected.Add(new Tuple<int, int>(9, 2));
            expected.Add(new Tuple<int, int>(1, 1));
            Assert.That(output, Is.EquivalentTo(expected));
        }

        [Test]
        public void GetMatchedWordsQ8()
        {
            var linq = new LinqMethods();

            var Words = new List<string>{
          "ROME"
          ,"LONDON"
          ,"NAIROBI"
          ,"CALIFORNIA"
          ,"ZURICH"
          ,"NEW DELHI"
          ,"AMSTERDAM"
          ,"ABU DHABI"
          ,"PARIS"
        };

            var matchedWords = linq.GetMatchedWordsQ8(Words, 'A', 'M');
            matchedWords.ForEach(x => { System.Console.WriteLine(x); });
        }

        [Test]
        public void GetMembersQ10()
        {
            var linq = new LinqMethods();
            var members = linq.GetMemebersQ10(30);
            members.ForEach(x => System.Console.WriteLine(x));

        }

        [Test]
        public void FindUppercaseWordsQ12()
        {
            var statement = "The UPPER CASE words are";
            var linq = new LinqMethods();
            var returned =  linq.FindUppercaseWordsQ12(statement);
            
        }

        [Test]
        public void GetGradePointQ14()
        {
            var linq = new LinqMethods();
            var nth = 2;
            var returnedList = linq.GetGradePointQ14(nth);
            returnedList.ForEach(x => {
                Console.WriteLine($"{x.Name}: {x.GP} ");
            });
        }

        [Test]
        public void RemoveInputQ16()
        {
            var linq = new LinqMethods();
            var charList = new List<char>();
            charList.Add('m');
            charList.Add('n');
            charList.Add('o');
            charList.Add('p');
            charList.Add('q');

            var cleanedList = linq.RemoveInputQ16(charList, 'n');
            cleanedList.ForEach(x => Console.WriteLine(x));

        }

        [Test]
        public void StringsOfMinimumLengthQ22() {

            var linq = new LinqMethods();
            var wordsList = new List<string>();
            wordsList.Add("this");
            wordsList.Add("is");
            wordsList.Add("a");
            wordsList.Add("string");

            var outStrings = linq.StringsOfMinimumLengthQ22(wordsList, 2);
            outStrings.ForEach(x => System.Console.WriteLine(x));
        }

        [Test]
        public void OrderByLengthAndNameQ28()
        {
            var linq = new LinqMethods();
            var cities = new List<string>
        {
            "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
        };

            var orderedList = linq.OrderByLengthAndNameQ28(cities);
            orderedList.ForEach(x => System.Console.WriteLine(x));

        }
    }
}
