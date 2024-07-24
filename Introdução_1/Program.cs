//>>> numero randomico <<<
/*Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
if (daysUntilExpiration<=10 && daysUntilExpiration>5)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration<=5 && daysUntilExpiration>1)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
}
else if(daysUntilExpiration == 1)
{   
    Console.WriteLine($"Your subscription expires within a {daysUntilExpiration} day!\nRenew now and save 20%!");    
}
else if(daysUntilExpiration == 0)
{   
    Console.WriteLine("Your subscription has expired.");    
}
*/

//>>> criação de matriz <<<
/*
string [] matrix = new string [3];

matrix [0] = "A123";
matrix [1] = "B456";
matrix[2] = "C789";

//string [] matrix = new string [] {"A123";"B456";"C789"}; // mesmo resultado das linhas acima.

int x = matrix.Length;
for (int i = 0; i < x; i++) 
{
    Console.WriteLine(matrix [i]);
}
*/

// >>> implementação de uma lista <<<<
/*
List<int> nota = new List<int> {10,20,30,40};

for (int i = 0;i<nota.Count;i++){
    Console.WriteLine(nota[i]);
}*/


/*
// >>>Para cada um dos alunos na matriz studentNames, o aplicativo fará o seguinte:<<<

        determinar o aluno atual.
        acessar as pontuações do aluno atual.
        calcular a nota atual do aluno (soma e média).
        gravar a nota do aluno atual no console.


// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// initialize variables - Sum

int andrewSum = 0;

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];
foreach (string name in studentNames)
{
    string currentName = name;
    if (currentName=="Sophia")
    {   
        studentScores = sophiaScores;
    }
    else if (currentName=="Andrew")
    {
        studentScores = andrewScores;
    }
    else if (currentName=="Emma")
    {
        studentScores = emmaScores;
    }
    else if (currentName=="Logan")
    {
        studentScores = loganScores;
    }
    
    int studentSum = 0;
    decimal studentScore;

    foreach(int score in studentScores)
    {
        studentSum+=score;
    }
    
    studentScore = (decimal)(studentSum)/currentAssignments;
    string finalNote="?"; 
    if (studentScore>=97 )
    {   
        finalNote = "A+";
    }
    else if (studentScore>=93 )
    {
        finalNote = "A";
    }
     else if (studentScore>=90 )
    {
        finalNote = "A-";
    } 
    else if (studentScore>=87 )
    {
        finalNote = "B+";
    }
 
    else if(studentScore>=83 )
    {
        finalNote= "B";
    }
    else if(studentScore>=80 )
    {
        finalNote= "B-";
    }
    else if(studentScore>=77 )
    {
        finalNote= "C+";
    }
    else if(studentScore>=73 )
    {
        finalNote= "C";
    }
    else if(studentScore>=70 )
    {
        finalNote= "C-";
    }
    else
    {
        finalNote = "F";
    }
    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine($"{currentName}:\t\t {studentScore} \t {finalNote}");
}
*/

/*
O projeto de código Starter deste módulo é um aplicativo de console em C# que implementa os seguintes recursos de código:

Usa matrizes para armazenar nomes de alunos e pontuações de tarefas.

Usa uma instrução foreach para fazer a iteração pelos nomes dos alunos como um loop de programa externo.

Usa uma instrução if no loop externo para identificar o nome do aluno atual e acessar as pontuações das tarefas dele.

Usa uma instrução foreach no loop externo para fazer a iteração pela matriz de pontuações de tarefas e somar os valores.

Usa um algoritmo no loop externo a fim de calcular a pontuação média de exame para cada aluno.

Usa um constructo if-elseif-else no loop externo para avaliar a pontuação média de exame e atribuir automaticamente uma nota em formato de letra.

Integra as pontuações de crédito extra ao calcular a pontuação final e a nota em formato de letra do aluno da seguinte maneira:

    Detecta tarefas de crédito extra com base no número de elementos na matriz de pontuações do aluno.
    Aplica um fator de ponderação de 10% às tarefas de crédito extra antes de adicionar pontuações de crédito extra à soma das pontuações de exame.
*/

/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
/*
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia"){
        studentScores = sophiaScores;}

    else if (currentStudent == "Andrew"){
        studentScores = andrewScores;}

    else if (currentStudent == "Emma"){
        studentScores = emmaScores;}

    else if (currentStudent == "Logan"){
        studentScores = loganScores;}

    int sumAssignmentScores = 0;
    decimal sumPontosExtras = 0;
    decimal currentStudentGrade = 0;
    int notaPontosExtra = 0;
    int gradedAssignments = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments){
            sumAssignmentScores += score;
        }
        else
        {
            notaPontosExtra+=score;
            sumPontosExtras +=(decimal) score / 10;
        }
        
    }
    
    currentStudentGrade =(decimal) sumAssignmentScores / examAssignments + sumPontosExtras/examAssignments;
    
    if (currentStudentGrade >= 97){
        currentStudentLetterGrade = "A+";
}
    else if (currentStudentGrade >= 93){
        currentStudentLetterGrade = "A";
}
    else if (currentStudentGrade >= 90){
        currentStudentLetterGrade = "A-";}

    else if (currentStudentGrade >= 87){
        currentStudentLetterGrade = "B+";}

    else if (currentStudentGrade >= 83){
        currentStudentLetterGrade = "B";}

    else if (currentStudentGrade >= 80){
        currentStudentLetterGrade = "B-";}

    else if (currentStudentGrade >= 77){
        currentStudentLetterGrade = "C+";}

    else if (currentStudentGrade >= 73){
        currentStudentLetterGrade = "C";}

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";
    

    Console.WriteLine($"{currentStudent}\t\t{(decimal)sumAssignmentScores/examAssignments}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{notaPontosExtra/(gradedAssignments-examAssignments)} ({sumPontosExtras/examAssignments} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
*/

/*
// >>> Operador Condicional <<<
decimal valorCompra = 1200.50m;
//int descontoCompra = valorCompra > 1000?100:50;

Console.WriteLine($"Valor do desconto $ {(valorCompra > 1000?100:50)}");
*/

/*
//string permission = "Admin|Manager";
string permission = "Manager";
int level = 65;

if(permission.Contains("Admin"))
{
    Console.WriteLine(level>55?"Welcome, Super Admin user.":"Welcome, Admin user.");
}
else if(permission.Contains("Manager"))
{
    Console.WriteLine(level>=20?"Contact an Admin for access.":"You do not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

*/

/*
//>>> operações condicionais <<<
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    //if (number == 42)
    //{
    //   found = true;
    //}
    found = number== 42?true:false; // equivalente ao bloco if acima.
}
if (found) 
{
    Console.WriteLine("Set contains 42");
}
Console.WriteLine($"Total: {total}");
*/
/*
// >>>> uso do foreach <<<<
int i = 0;
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{  
    // Can't do this:
    if (name == "David") names[i] = "Sammy"; Console.WriteLine(names[i]);
    i++;
}
*/

/*
//>>> Implementação do for <<<
for (int i = 0; i < 100;i++) 
{   
   
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }else
    {
        Console.WriteLine($"{i}");
    }
}
*/

/*
// >>> interação do-while<<<
int vidaHeroi= 10;
int vidaMonstro = 10;
int ataque = 0;
Random random= new Random();

do
{       
    ataque = random.Next(1, 11);
    vidaMonstro -=ataque; 
    Console.WriteLine($"O Heroi atacou:\n{ataque} de dano... ");
    Console.WriteLine($"Vida do Monstro > {vidaMonstro} ");
    
    if (vidaMonstro<=0) continue;

    ataque = random.Next(1, 10);
    vidaHeroi -= ataque;
    Console.WriteLine($"O Monstro atacou:\n{ataque} de dano... ");
    Console.WriteLine($"Vida do Heroi > {vidaHeroi} ");
    
    
    
}while(vidaMonstro>0);

string ganhador = vidaHeroi < 0 ? "O Heroe foi derrotado :( " : "O Heroi venceu!!!\n\\0/";
Console.WriteLine(ganhador);

*/


