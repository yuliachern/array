Console.WriteLine("Hello, World!");
// Declare fixed size array 

int number = 0;
int numberOfGrade = Convert.ToInt32(Console.ReadLine());
// 5 space adresses / indexes - 0, 1, 2, 3, 4
// if n is  the size of the array, then your array has adresses between 0 to n-1
int[] grades = new int[numberOfGrade];
string[] students = new string[numberOfGrade];

// add values to fixed size array
grades[0] = 45;
grades[1] = 35;
grades[2] = 34;
grades[3] = 21;
grades[4] = 13;

for (int i = 0; i < numberOfGrade; i++)
{
    Console.WriteLine("Enter student's name");
    students[i] = Console.ReadLine();

    Console.WriteLine("Enter grade");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}
// print value in Fixed size array
Console.WriteLine("The Grade you have entered are: ");
for (int i = 0;i < numberOfGrade; i++)
{
    Console.WriteLine($"{students[i]} : {grades[i]}");
    Console.WriteLine(students[i]);
    Console.WriteLine(grades[i]);
}

// Declare variable size array
string[] studentName = {"newtone", "Joshua", "Eric"};

// add values to variable size array
for (int i = 0; i < studentName.Length; i++)
{
    Console.WriteLine("Enter student name");
    studentName[i] = Console.ReadLine();
}
// print values in variable size array
Console.WriteLine("The students names you have entered are: ");
for (int i = 0; i < studentName.Length; i++)
{
    Console.WriteLine(studentName[i]);
}

// Declare a list

List<int> grade1 = new List<int>();
var name2 = new List<int>();
List<int> name3 = new();
// Add values to list
name2.Add(5);
Console.WriteLine(name2[0]);
do
{
    Console.WriteLine("Enter a number");
    number = Convert.ToInt32(Console.ReadLine());
    if (number != -1)
    {
        grade1.Add(number);
    }
}
while(number != -1);
// Print values in list - for
for (int i = 0; i < grade1.Count; i++)
{
    Console.WriteLine(grade1[i]);
}
// print values in list - foreach
foreach (int g in name2) 
{
    Console.WriteLine(g);
}

