// 4 students, 5 exam scores
// score integer, 0-100
// overal exam score = average of all exam scores
// add extra credit assignment score to overal exam score
// extra credit assignment score = 0-10
// add extra credit assignment score to overal exam score before calculating final grade
// assign letter grade based on overal exam score

string[] studentNames = [ "Sophia", "Andrew", "Emma", "Logan" ];
int [] sophiaScores = [ 90, 86, 87, 98, 100, 94, 90];
int [] andrewScores = [ 92, 89, 81, 96, 90, 89 ];
int [] emmaScores = [ 90, 85, 87, 98, 68, 89, 89, 89 ];
int[] loganScores = [90, 95, 87, 88, 96, 96];

string currentStudentLetterGrade = "";

int currentAssignments = 5;

int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\n");

foreach (string student in studentNames)
{
    if (student == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (student == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if (student == "Emma")
    {
        studentScores = emmaScores;
    }
    else if (student == "Logan")
    {
        studentScores = loganScores;
    }

    int sumScores = 0;
    decimal currentStudentScore = 0;
    int extraAssigments = 0;

    foreach (int score in studentScores)
    {
        extraAssigments++;
        if (extraAssigments <= currentAssignments)
            sumScores += score;
        else
            sumScores += score / 10;
    }

    currentStudentScore = (decimal)(sumScores) / currentAssignments;

    if (currentStudentScore >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentScore >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentScore >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentScore >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentScore >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentScore >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentScore >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentScore >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentScore >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentScore >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentScore >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentScore >= 60)
        currentStudentLetterGrade = "D-";

    Console.WriteLine($"{student}\t\t{currentStudentScore}\t{currentStudentLetterGrade}");
}