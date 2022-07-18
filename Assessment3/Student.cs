namespace Assessment3
{
    internal class Student
    {
        
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
}