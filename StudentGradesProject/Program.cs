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

Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\t\tExtra Credit\n");

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
    int extraGrades = 0;
    int finalExamScore = 0;
    int extraGradesScore = 0;
    decimal currentStudentExtraPoints = 0;
    decimal currentStudentOverallScore = 0;
    decimal currentStudentExamScore = 0;
    int extraAssigments = 0;

    foreach (int score in studentScores)
    {
        extraAssigments++;
        if (extraAssigments <= currentAssignments)
        {
            sumScores += score;
            finalExamScore = sumScores;
        }
        else
        {
            sumScores += score / 10;
            extraGradesScore += score;
            extraGrades++;
        }
    }
    currentStudentExamScore = (decimal)(finalExamScore) / currentAssignments;
    currentStudentOverallScore = (decimal)(sumScores) / currentAssignments;
    currentStudentExtraPoints = currentStudentOverallScore - currentStudentExamScore;
    extraGradesScore /= extraGrades;

    if (currentStudentOverallScore >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentOverallScore >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentOverallScore >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentOverallScore >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentOverallScore >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentOverallScore >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentOverallScore >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentOverallScore >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentOverallScore >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentOverallScore >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentOverallScore >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentOverallScore >= 60)
        currentStudentLetterGrade = "D-";

    Console.WriteLine($"{student}\t\t{currentStudentExamScore}\t\t{currentStudentOverallScore}\t{currentStudentLetterGrade}\t\t{extraGradesScore} ({currentStudentExtraPoints} pts)");
}