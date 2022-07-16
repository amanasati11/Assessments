namespace Assessment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student{FirstName="Amara", LastName="Sriram", Age=21, Gender="M", TeamName="A" },
                new Student{FirstName="Muskan",LastName="Muskan", Age=20, Gender="F", TeamName="A" },
                new Student{FirstName="Rahul",LastName="Yadav", Age=21, Gender="M", TeamName="A" },
                new Student{FirstName="Shraddha",LastName="Shraddha", Age=20, Gender="F", TeamName="A" },
                new Student{FirstName="Aishwarya",LastName="Verma", Age=20, Gender="F", TeamName="A" },

                new Student{FirstName="Shreya",LastName="", Age=20, Gender="F", TeamName="B" },
                new Student{FirstName="Nandhita",LastName="", Age=20, Gender="F", TeamName="B" },
                new Student{FirstName="Shashwat",LastName="", Age=20, Gender="M", TeamName="B" },
                new Student{FirstName="Siddarth",LastName="", Age=21, Gender="M", TeamName="B" },
                new Student{FirstName="Shriya",LastName="", Age=20, Gender="F", TeamName="B" },

                new Student{FirstName="Sriram",LastName="", Age=21, Gender="M", TeamName="C" },
                new Student{FirstName="Sneha",LastName="Sinha", Age=20, Gender="F", TeamName="C" },
                new Student{FirstName="Simran",LastName="Singh", Age=20, Gender="F", TeamName="C" },
                new Student{FirstName="Subhash",LastName="Gurjar", Age=21, Gender="M", TeamName="C" },
                new Student{FirstName="Umeed",LastName="Chandel", Age=19, Gender="F", TeamName="C" },

                new Student{FirstName="Vaibhav",LastName="Bhatnagar", Age=21, Gender="M", TeamName="D" },
                new Student{FirstName="Pujitha",LastName="Vavilapalli", Age=20, Gender="F", TeamName="D" },
                new Student{FirstName="Palak",LastName="Soni", Age=20, Gender="F", TeamName="D" },
                new Student{FirstName="Saurabh",LastName="Kumar", Age=21, Gender="M", TeamName="D" },
                new Student{FirstName="Tisha",LastName="Varshney", Age=20, Gender="F", TeamName="D" },
                new Student{FirstName="Aman",LastName="Asati", Age=21, Gender="M", TeamName="D" },
            };

            //Where, OrderBy, OrderByDescending, ThenBy, GroupBy, Join, Select

            // Where Keyword is used for giving condition
            Console.WriteLine("------------Where KeyWord-----------");
            var SelectedBatchStudents = students.Where(student => student.TeamName == "A" || student.TeamName == "D");
            Console.WriteLine("Students of Batch A and D only: ");
            foreach (var student in SelectedBatchStudents)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");
            
            var BandCOnlyFemaleStudents = students.Where(student => ((student.TeamName == "B" || student.TeamName == "C") 
                                                                      && student.Gender == "F"));
            Console.WriteLine("Female Students of Batch B and C only: ");
            foreach (var student in BandCOnlyFemaleStudents)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------OrderBy KeyWord-----------");

            var StudentsOrderByFirstName = students.OrderBy(student => student.FirstName);
            Console.WriteLine("Students Sorted by their First Name in Asc Order: ");
            foreach (var student in StudentsOrderByFirstName)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");
            
            Console.WriteLine("------------OrderByDescending KeyWord-----------");

            var StudentsOrderByDesc = students.OrderByDescending(student => student.LastName);
            Console.WriteLine("Students Sorted by their Last Name in Desc Order: ");
            foreach (var student in StudentsOrderByDesc)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------ThenBy KeyWord-----------");

            var DBatchStudentsOnly = students.Where(student => student.TeamName == "D")
                .OrderBy(student => student.FirstName)
                .ThenBy(student => student.Age);
            Console.WriteLine("OrderBy Student of (D Batch only) FirstName and then by age: ");
            foreach(var student in DBatchStudentsOnly)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------GroupBy KeyWord-----------");
            var MakingGroups = students.GroupBy(student => student.TeamName);
            foreach (var group in MakingGroups)
            {
                Console.WriteLine("Group: " + group.Key +" Count of Students: "+ group.Count());
            }
            Console.WriteLine("------------------------------------");
            
            foreach(var group in MakingGroups)
            {
                var maleStudents = group.Where(student => student.Gender == "M");
                var femaleStudents = group.Where(student => student.Gender == "F");
                Console.Write("Group: " + group.Key + " Male Count: " + maleStudents.Count());
                Console.WriteLine(" Female Count: " + femaleStudents.Count());
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------Select Query-----------");
            var StudentFirstNameAndTeam = students
                .Select(student => new { student.FirstName, student.TeamName })
                .OrderBy(student => student.FirstName);
            foreach(var student in StudentFirstNameAndTeam)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");

            // Take, TakeLast, TakeWhile

            Console.WriteLine("------------Take Keyword-----------");
            Console.WriteLine("Selecting First Two Students: ");
            var Select2Students = students.Take(2);
            foreach( var student in Select2Students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------Take within range-----------");
            var RangeOf5Students = students.Take(new Range(5, 10));
            Console.WriteLine("Selecting within a Range: ");
            foreach (var student in RangeOf5Students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------TakeLast Keyword-----------");
            Console.WriteLine("Selecting the last 5 Students: ");
            var Last5Students = students.TakeLast(5);
            foreach (var student in Last5Students)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------TakeWhile Keyword-----------");
            Console.WriteLine("Selecting Batch A Students: ");
            var Batch3Students = students.TakeWhile(student => student.TeamName == "A");
            foreach (var student in Batch3Students)
            {
                Console.WriteLine(student.FirstName);
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------Skip Keyword-----------");
            Console.WriteLine("Skipping First 10 Students: ");
            var SkipFirst10Students = students.Skip(10);
            foreach (var student in SkipFirst10Students)
            {
                Console.WriteLine(student.FirstName);
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------ConvertAll Keyword-----------");
            var getFirstNameAndLastName = students.ConvertAll(student => student.FirstName + " " + student.LastName + " " + student.Age);
            foreach (var item in getFirstNameAndLastName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------Contains and Append Keyword-----------");
            var NewStudent = new Student { FirstName = "Madhur", LastName = "Asati", Gender = "M", Age = 26, TeamName = "D"};
            if (!students.Contains(NewStudent, new StudentEqualityComparer()))
            {
                var afterAppend = students.Append(NewStudent);
                foreach (var student in afterAppend)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------Name Start's with S-----------");
            var NameStartWithS = students.Where(student => student.FirstName.ToUpper().StartsWith('S'));
            
            foreach (var student in NameStartWithS)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------Missing LastName-----------");
            var NameEndWithblank = students.Where(student => student.LastName == "");

            foreach (var student in NameEndWithblank)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("-----------Only GenM and Orderby FirstName-----------");
            var GenMOrdFname = students
                .Where(student => student.Gender == "M")
                .OrderBy(student => student.FirstName);

            foreach (var student in GenMOrdFname)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("-----------Only Grp B and D and age 21-----------");
            var OnlyBDAndAge = students.Where(student => ((student.TeamName == "B" || student.TeamName == "D")
                                                                      && student.Age == 21));

            foreach (var student in OnlyBDAndAge)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");
            
            Console.WriteLine("-----------Count of Male and Female-----------");
            var MaleAndFemale = students.GroupBy(student => student.TeamName);
            foreach (var group in MaleAndFemale)
            {
                var maleStudents = group.Where(student => student.Gender == "M");
                var femaleStudents = group.Where(student => student.Gender == "F");
                Console.Write("Group: " + group.Key + " Male Count: " + maleStudents.Count());
                Console.WriteLine(" Female Count: " + femaleStudents.Count());
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------Take within range-----------");
            var WithinRange = students
                .Take(new Range(6, 12))
                .Where(student => student.Age == 20);
            foreach (var student in RangeOf5Students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------FirstName and Age -----------");
            var FirstNameAge = students
                .Select(student => new { student.FirstName, student.Age });
            foreach (var student in FirstNameAge)
            {
                Console.WriteLine(student.FirstName + " " + student.Age);
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------Age 21 and Name and teamName-----------");
            var Age21NameTeam = students
                .Where(student => student.Age == 21)
                .Select(student => new { student.FirstName, student.TeamName });
            foreach (var student in Age21NameTeam)
            {
                Console.WriteLine(student.FirstName + " " + student.TeamName);
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------Name Start's with P, T, N-----------");
            var NameStartWithPTN = students.Where(student => student.FirstName.ToUpper().StartsWith('P') 
                                                    || student.FirstName.ToUpper().StartsWith('T')
                                                    || student.FirstName.ToUpper().StartsWith('N'));

            foreach (var student in NameStartWithPTN)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine("------------------------------------");

            
            
            List<int> numbers = new() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            Console.WriteLine("------------Number <3 and >8-----------");
            var NumberRange = numbers
                .Where(num => num > 3 && num < 8);
            Console.WriteLine("There are total: " + NumberRange.Count() + " Numbers");
            foreach (var num in NumberRange)
            {
                Console.WriteLine(num.ToString());
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------Even Numbers-----------");
            var EvenNumber = numbers.FindAll(num => (num % 2) == 0);
            foreach (var num in EvenNumber)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------Odd Numbers-----------");
            var OddNumber = numbers.FindAll(num => (num % 2) != 0);
            foreach (var num in OddNumber)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("------------3rd Highest Numbers-----------");
            var NHighest = numbers
                .OrderByDescending(num => num)
                .Skip(2)
                .First();
            Console.WriteLine("Third Higest Number is: " + NHighest);

            Console.WriteLine("------------4th Lowest Numbers-----------");
            var NLowest = numbers
                .OrderBy(num => num)
                .Skip(3)
                .First();
            Console.WriteLine("Fourth Higest Number is: " + NLowest);

            Console.WriteLine("------------------------------------");


        }
    }

    class Student
    {
        /*    private int myVar;

            public int MyProperty
            {
                get { return myVar; }
                set { myVar = value; }
            }*/

        //Auto implemented properties - ILDASM
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string TeamName { get; set; }

        public string ToString()
        {
            return (this.FirstName + " " + this.LastName + " " + this.Age + " " + this.TeamName);
        }

    }

    class StudentFirstNameWithAge
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
    }

    class StudentEqualityComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            return x.FirstName == y.FirstName && x.LastName == y.LastName;
        }

        public int GetHashCode(Student obj)
        {
            return obj.Age.GetHashCode();
        }
    }
}

