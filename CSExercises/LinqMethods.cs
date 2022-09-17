namespace CSExercises
{
    public class LinqMethods
    {
        public List<int> ShowHowQueryWorksQ1(List<int> inputList)
        {//Write a program in C# Sharp to shows how the three parts of a query operation execute.

            //Original
            //int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Console.Write("\nBasic structure of LINQ : ");
            //Console.Write("\n---------------------------");

            //// The second part is Query creation.
            //// nQuery is an IEnumerable<int>
            //var nQuery =
            //    from VrNum in n1
            //    where (VrNum % 2) == 0
            //    select VrNum;

            //// The third part is Query execution.
            return inputList.FindAll(x => x % 2 == 0);

        }

        public List<int> SquareTheArrayLessThan20Q2(List<int> inputArray)
        {
            //Write a program in C# Sharp to find the number of an array and the square of each number which is more than 20.
            //for an integer array return any element less than 5. Because 4 is the max square that is less than 20
            return inputArray.FindAll(x => x <= 4);

        }

        public List<Tuple<int, int>> FindFrequencyQ4(List<int> inputArray)
        {
            //Write a program in C# Sharp to display the number and frequency of number from giving array. Go to the editor
            var results = new List<Tuple<int, int>>();
            var tracker = new List<int>();
            inputArray.ForEach(x =>
            {
                if (!tracker.Contains(x))
                {
                    tracker.Add(x);
                    var frequency = inputArray.FindAll(y => y == x).Count();
                    results.Add(new Tuple<int, int>(x, frequency));
                }
            });
            return results;
        }

        public List<string> PrintDaysOfWeekQ6()
        {
            //Print days of the week
            return new List<string>{
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };
        }

        public List<string> GetMatchedWordsQ8(List<string> Words, char startCharacter, char endCharacter)
        {
            //Rerturn the word that matches characters
            return Words.FindAll(x => x.StartsWith(startCharacter)
            && x.EndsWith(endCharacter));

        }

        public List<Tuple<string, int>> GetMemebersQ10(int memberValue)
        {
            //Write a program in C# Sharp to accept the members of a list through the keyboard and display the members more than a specific value
            var members = new List<Tuple<string, int>>();
            members.Add(new Tuple<string, int>("member0", 10));
            members.Add(new Tuple<string, int>("member1", 48));
            members.Add(new Tuple<string, int>("member2", 52));
            members.Add(new Tuple<string, int>("member3", 94));
            members.Add(new Tuple<string, int>("member4", 63));

            return members.FindAll(x =>
              x.Item2 >= memberValue
            );

        }

        public List<string> FindUppercaseWordsQ12(string statement)
        {
            var words = statement.Split(' ').ToList();
            return words.FindAll(x =>
            {
                return string.Equals(x, x.ToUpper());
            });
        }

        public List<GradePoints> GetGradePointQ14(int nthGPMax)
        {
            var grades = new List<GradePoints>();
            grades.Add(new GradePoints(7, "David", 750));
            grades.Add(new GradePoints(8, "Billy", 820));
            grades.Add(new GradePoints(9, "Tony", 910));
            grades.Add(new GradePoints(10, "Harry", 350));
            grades.Add(new GradePoints(10, "Charlie", 220));

            var sortedGrades = grades.OrderBy(x => x.GP).Reverse();
            return sortedGrades.Take(nthGPMax).ToList();

        }

        public List<char> RemoveInputQ16(List<char> inputList, char removeChar)
        {
            inputList.RemoveAll(x => x == removeChar);
            return inputList;
        }

        public List<string> RemoveByTheIndexQ20(List<string> inputString, int index)
        {
            if (index > inputString.Count()) { throw new Exception("Index is higher than the count"); }

            inputString.RemoveAt(index);
            return inputString;
        }

        public List<string> StringsOfMinimumLengthQ22(List<string> inputStrings, int minLength)
        {
            var filtered = inputStrings.FindAll(x => x.Length >= minLength);
            return filtered;
        }

        public List<string> OrderByLengthAndNameQ28(List<string> nameList)
        {
            var ordered = nameList.OrderBy(x => x.Length)
                                 .ThenBy(n => n);
            return ordered.ToList();
        }


    }

    public class GradePoints
    {

        public GradePoints(int id, string name, int gp)
        {
            this.Id = id;
            this.Name = name;
            this.GP = gp;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int GP { get; set; }
    }
}
