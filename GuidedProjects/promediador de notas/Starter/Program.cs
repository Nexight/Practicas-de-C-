﻿using System;
#region Notas

/* Nota con letra
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F

-- Informe de salida --

Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-
*/
#endregion
// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100,94,90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89,89,89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };  

// nombres de los estudiantes
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan","Becky","Chris","Eric","Gregor"};

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Escribe el encabezado del reporte en la consola
Console.WriteLine("Student\t\tGrade\tLetter Grade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
    
        studentScores=sophiaScores;

    else if (currentStudent=="Andrew")
        studentScores=andrewScores;

    else if (currentStudent=="Emma")
        studentScores=emmaScores;

    else if(currentStudent=="Logan")
        studentScores=loganScores;
    
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
    continue;

    // inicializa/resetea la suma de las notas
    int sumAssignmentScores = 0;

    // inicializa/resetea la nota promedio calculada de los examenes + los creditos extra
    decimal currentStudentGrade=0;

    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)

            // add the exam score to the sum
            sumAssignmentScores += score;

       else
            // suma los creditos extra a la suma total - los puntos extra son iguales a un 10% de la nota del examen
            sumAssignmentScores += score/10;
    }

    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";    

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

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

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

