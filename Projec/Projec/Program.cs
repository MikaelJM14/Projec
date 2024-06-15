using Projec;
Console.WriteLine("Wjtamy w programie XYZ do oceny Pracownikow");
Console.WriteLine("============================================");
Console.WriteLine();
var S = new S();
var student1 = new Student("mikael", "marosz");
var student2 = new Student("mikaela", "Jazmina");
var student3 = new Student("stefan", "karol");
var student4 = new Student("maria", "magdelena");
var student5 = new Student("usef", "staniswaf");
var student6 = new Student("ana", "magozata");
var student7 = new Student("marek", "ustan");
var student8 = new Student("mariusz", "marek");
var student9 = new Student("Isabella", "natialia");
var student10 = new Student("ana", "karolina");
int A = 100;
int a = 90;
int B = 80;
int b = 70;
int C = 60;
int c = 50;
int D = 40;
int d = 30;
int E = 20;
int e = 10;
int F = 0;
student1.grades.Add(A);
student1.grades.Add(b);
student1.grades.Add(A);

student2.grades.Add(B);
student2.grades.Add(b);
student2.grades.Add(A);

student3.grades.Add(d);
student3.grades.Add(e);
student3.grades.Add(F);

student4.grades.Add(F);
student4.grades.Add(D);
student4.grades.Add(A);

student5.grades.Add(B);
student5.grades.Add(b);
student5.grades.Add(A);

student6.grades.Add(F);
student6.grades.Add(F);
student6.grades.Add(F);

student7.grades.Add(F);
student7.grades.Add(F);
student7.grades.Add(F);

student8.grades.Add(A);
student8.grades.Add(A);
student8.grades.Add(F);

student9.grades.Add(E);
student9.grades.Add(D);
student9.grades.Add(C);

student10.grades.Add(A);
student10.grades.Add(A);
student10.grades.Add(A);

Console.WriteLine($"Min: {S.Min}");
Console.WriteLine($"Max: {S.Max}");
Console.WriteLine($"Average: {S.Average}");
Console.WriteLine($"student 10 has the highest score on every thing");
Console.WriteLine($"student 1 has the medium score on every thing");
Console.WriteLine($"students 6 & 7 have the lowest score on every thing");