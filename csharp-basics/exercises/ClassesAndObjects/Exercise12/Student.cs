using System;

public interface IStudent
{
    string[] TestsTaken { get; }
    void TakeTest(ITestpaper paper, string[] answers);
}
public class Student : IStudent
{
    private string[] testsTaken = new string[] {"No test taken"};
    public string[] TestsTaken { get { return testsTaken; } }
    public Student()
	{
	}
    public void TakeTest(ITestpaper paper, string[] answers)
    {
        int correctAnswers = 0;
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == paper.MarkScheme[i])
            {
                correctAnswers++;
            }
        }
        double percentage = ((double)correctAnswers / paper.MarkScheme.Length) * 100;
        string result = $"{paper.Subject}: {(percentage >= double.Parse(paper.PassMark.TrimEnd('%')) ? "Passed" : "Failed")}! ({percentage}%)";
        Array.Resize(ref testsTaken, testsTaken.Length + 1);
        testsTaken[testsTaken.Length - 1] = result;
    }
}
