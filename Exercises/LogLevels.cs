
using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int startIndex = logLine.IndexOf(' ') ;
        int endIndex = (logLine.Length - startIndex);
        string expression = logLine.Substring(startIndex, endIndex);
        return expression.Trim();
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.IndexOf('[') + 1;
        int endIndex = logLine.IndexOf(']') - 1;
        string expression = logLine.Substring(startIndex, endIndex);
        return expression.ToLower();
    }

    public static string Reformat(string logLine)
    {
        int startIndex1 = logLine.IndexOf(' ') ;
        int endIndex1 = (logLine.Length - startIndex1);
        string expression1 = logLine.Substring(startIndex1, endIndex1);
        string firstStr = expression1.Trim();

        int startIndex2 = logLine.IndexOf('[') + 1;
        int endIndex2 = logLine.IndexOf(']') - 1;
        string expression2 = logLine.Substring(startIndex2, endIndex2);
        string secExpression = expression2.ToLower();
        return firstStr + " (" + secExpression + ")";
    }
}
