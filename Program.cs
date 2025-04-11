//LINQ stands for Language Integrated Query
//It allows you to query collections in SQL like manner.
//Anything that inherits from IEnumerable or IQueryable.
//Two styles of writing LINQ: Query Syntax and Method Syntax.
//Method syntax is shorter, are powerful and flexible to use while Query syntax is easier to read for beginners.

using LinqQueries;

List<Student>students = new List<Student>();
students.Add(new Student {Name = "Mike", Score = 50});
students.Add(new Student {Name = "Lola", Score = 65});
students.Add(new Student {Name = "Femi", Score = 89});
students.Add(new Student {Name = "Joy", Score = 91});
students.Add(new Student {Name = "John", Score = 90});
students.Add(new Student {Name = "Favour", Score = 45});
students.Add(new Student {Name = "Daniel", Score = 60});
students.Add(new Student {Name = "Queen", Score = 70});
students.Add(new Student {Name = "Yazid", Score = 100});
students.Add(new Student {Name = "Dami", Score = 99});

//Uses of LINQ
//Filtering, Sorting, Projection, Grouping, Aggregate, Searching

//Query Syntax (Filtering) FWS
var highScorers = from s in students
                  where s.Score >= 80
                  select s;
//foreach (var student in highScorers)
//{
//    Console.WriteLine($"{student.Name} scored {student.Score} ");
//        }

//Method Syntax (Filtering)
var highScorers2 = students.Where(anyStudent => anyStudent.Score >= 80);
//var nameSimba = students.Where(anyStudent => anyStudent.Name == "Simba").ToList().Last();
foreach (var student in highScorers2)
{
    Console.WriteLine($"{student.Name} scored {student.Score} ");
}
//Method Syntax (Sorting), order by ascending 
var orderedByName = students.OrderBy(x => x.Name);
var orderedByScore = students.OrderByDescending(x => x.Score).Take(5);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Here is the list of the students ordered by their names");

foreach (var student in orderedByName)
{
    Console.WriteLine($"{student.Name} scored {student.Score} ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Here is the list of the top five students ordered by their scores");

foreach (var student in orderedByScore)
{
    Console.WriteLine($"{student.Name} scored {student.Score} ");
}
//Get all students whose names start with the letter "J"
var studentsWithJinName = students.Where(x => x.Name.StartsWith("J"));
foreach (var student in studentsWithJinName)
{
    Console.WriteLine($"{student.Name} starts with the letter 'J' ");
}
//Method Syntax (Projection)
var allNames = students.Select(x => x.Name);
var allScores = students.Select(x => x.Score);
foreach (var name in allNames)
{
    Console.WriteLine($"{name}");
}

foreach (var score in allScores)
{
    Console.WriteLine($"{score}");
}
//Method Syntax (Grouping)
var grouped = students.GroupBy(x => x.Name.StartsWith("L"));
foreach (var group in  grouped)
{
    Console.WriteLine($"Is there any student's name that starts with 'L': {group.Key}");
    foreach (var student in group)
    {
        Console.WriteLine($"student with name {student.Name} scored {student.Score}");
    }
}

Console.ReadLine();



