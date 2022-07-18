namespace Assessment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ Coding Assignment-1 :) ----------");
            var students = new List<Student> {
            new Student{FirstName="Amara",LastName="Sriram",Age=21, Gender="M", TeamName="A" },
            new Student{FirstName="Muskan",LastName="Muskan",Age=20, Gender="F", TeamName="A" },
            new Student{FirstName="Rahul",LastName="Yadav",Age=21, Gender="M", TeamName="A" },
            new Student{FirstName="Shraddha",LastName="Shraddha",Age=20, Gender="F", TeamName="A" },
            new Student{FirstName="Aishwarya",LastName="Verma",Age=19, Gender="F", TeamName="A" },

            new Student{FirstName="Shreya",LastName="",Age=20, Gender="F", TeamName="B" },
            new Student{FirstName="Nandhita",LastName="",Age=20, Gender="F", TeamName="B" },
            new Student{FirstName="Shashwat",LastName="",Age=20, Gender="M", TeamName="B" },
            new Student{FirstName="Siddarth",LastName="",Age=21, Gender="M", TeamName="B" },
            new Student{FirstName="Shriya",LastName="",Age=20, Gender="F", TeamName="B" },

            new Student{FirstName="Sriram",LastName="",Age=21, Gender="M", TeamName="C" },
            new Student{FirstName="Sneha",LastName="Sinha",Age=20, Gender="F", TeamName="C" },
            new Student{FirstName="Simran",LastName="Singh",Age=20, Gender="F", TeamName="C" },
            new Student{FirstName="Subhash",LastName="Gurjar",Age=21, Gender="M", TeamName="C" },
            new Student{FirstName="Umeed",LastName="Chandel",Age=19, Gender="F", TeamName="C" },

            new Student{FirstName="Vaibhav",LastName="Bhatnagar",Age=21, Gender="M", TeamName="D" },
            new Student{FirstName="Pujitha",LastName="Vavilapalli",Age=20, Gender="F", TeamName="D" },
            new Student{FirstName="Palak",LastName="Soni",Age=20, Gender="F", TeamName="D" },
            new Student{FirstName="Saurabh",LastName="Kumar",Age=21, Gender="M", TeamName="D" },
            new Student{FirstName="Tisha",LastName="Varshney",Age=20, Gender="F", TeamName="D" },
            new Student{FirstName="Aman",LastName="Asati",Age=21, Gender="M", TeamName="D" }
            };

            Console.WriteLine("------------ Problem-1 ----------");
            Console.WriteLine("Q1 => Get all the students count for each team");
            var StudentGroups = students.GroupBy(student => student.TeamName);
            /*The GroupBy operator returns a group of elements from the given collection based on some key value.*/
            foreach (var group in StudentGroups)
            {
                var MaleStudents = group.Where(student => student.Gender == "M");
                var FemaleStudents = group.Where(student => student.Gender == "F");
                var TotalCount = MaleStudents.Count() + FemaleStudents.Count();
                Console.Write("Group: " + group.Key + " Male Count: " + MaleStudents.Count());
                Console.WriteLine(" Female Count: " + FemaleStudents.Count() + " Total Count: " + TotalCount);
            }
            Console.WriteLine("---------------------------------");
            
            Console.WriteLine("------------ Problem-2 ----------");
            Console.WriteLine("Q2 => Get all the male students list");

            var GenMStudents = students
                .Where(student => student.Gender == "M")
                .OrderBy(student => student.FirstName);
            /*Returns values from the collection based on a predicate function.
            Sorts the elements in the collection based on specified fields in ascending or decending order.*/
            PrintClass.Print(GenMStudents);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("------------ Problem-3 ----------");
            Console.WriteLine("Q3 => Get all the Female students list");

            var GenFStudents = students
                .Where(student => student.Gender == "F")
                .OrderBy(student => student.FirstName);
            PrintClass.Print(GenFStudents);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("------------ Problem-4 ----------");
            Console.WriteLine("Q4 => Get all the male students with age 20");

            var GenMStudentsAge = students
                .Where(student => student.Gender == "M" && student.Age == 20)
                .OrderBy(student => student.FirstName);
            PrintClass.Print(GenMStudentsAge);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("------------ Problem-5 ----------");
            Console.WriteLine("Q5 => Get all the Female students with age 19");

            var GenFStudentsAge = students
                .Where(student => student.Gender == "F" && student.Age == 19)
                .OrderBy(student => student.FirstName);
            PrintClass.Print(GenFStudentsAge);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("------------ Problem-6 ----------");
            Console.WriteLine("Q6 => Get all the students starts with FirstName as A or a");

            var FirstNameA = students
                .Where(student => student.FirstName.ToUpper().StartsWith('A'));
            PrintClass.Print(FirstNameA);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("------------ Problem-7 ----------");
            Console.WriteLine("Q7 => Get all the students whose lastname is empty");

            var EmptyLastName = students
                .Where(student => student.LastName == "");
            PrintClass.Print(EmptyLastName);           
            Console.WriteLine("---------------------------------");

            Console.WriteLine("------------ Problem-8 ----------");
            Console.WriteLine("Q8 => Get top 2 students in each team");
            var Top2Students = students
                .GroupBy(student => student.TeamName)
                .SelectMany(student => student.Take(2));
            /*Select many is like cross join operation in SQL where it takes the cross product.*/
            PrintClass.Print(Top2Students);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("------------ Problem-9 ----------");
            Console.WriteLine("Q9 => get the students from 8th position to 17th position");
            var WithinRange = students
                .Take(new Range(7, 17));
            PrintClass.Print(WithinRange);
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------ Problem-10 ----------");
            Console.WriteLine("Q10 => Get all the students FirstName with Age: ");
            var FirstNameAge = students
                .Select(student => new { student.FirstName, student.Age });
            
            foreach (var student in FirstNameAge)
            {
                Console.WriteLine("FirstName: " + student.FirstName + " " + " Age: " + student.Age);
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------ Coding Assignment-2 :) ----------");

            var numbers = new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 8 };

            Console.WriteLine("------------ Problem-1 ----------");
            Console.WriteLine("Q1 => find the unique element in this list");

            var UniqueElement = numbers
                .GroupBy(num => num)
                .Where(num => num.Count() == 1)
                .Select(num => num.Key);
            
            foreach (var num in UniqueElement)
            {
                Console.WriteLine("The Unique Element is: " + num);
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------ Problem-2 ----------");
            Console.WriteLine("Q2 => find the distinct elements");

            var DistinctElements = numbers
                .Select(num => num).Distinct();
            Console.WriteLine("Distinct Elements present in the list are: ");
            foreach (var num in DistinctElements)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------ Problem-3 ----------");
            Console.WriteLine("Q3 => find the maximum occurred element");

            var MaxOccuredElement = numbers
                .GroupBy(num => num)
                .OrderBy(num => num.Count())
                .Last().Key;
            Console.WriteLine("The MaxOccuredElement in the list: " + MaxOccuredElement);
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------ Problem-4 ----------");
            Console.WriteLine("Q4 => find the mainimum occurred element");

            var MinOccuredElement = numbers
                .GroupBy(num => num)
                .OrderBy(num => num.Count())
                .First().Key;
            Console.WriteLine("The MinOccuredElement in the list: " + MinOccuredElement);
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------ Problem-5 ----------");
            Console.WriteLine("Q5 => find the even and odd numbers");

            var EvenNumber = numbers
                .Distinct()
                .Where(num => (num % 2) == 0);
                
            Console.Write("Even Numbers are: ");
            foreach (var num in EvenNumber)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            var OddNumber = numbers
                .Distinct()
                .Where(num => (num % 2) != 0);

            Console.Write("Odd Numbers are: ");
            foreach (var num in OddNumber)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            
            Console.WriteLine("-----------------The End, Thanks For Watching :)-------------------");
        }
        public static class PrintClass
        {
            public static void Print(IEnumerable<Student> students)
            {
                foreach (var student in students)
                {
                    Console.WriteLine("Name: " + student.FirstName + " " + student.LastName + " Age: "
                                   + student.Age + " Team: " + student.TeamName);
                }

            }
        }
    }
}