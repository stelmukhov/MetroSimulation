using System;

namespace MetroSimulation.Train.UI.Model
{
    public class LogMessage
    {
        public string BgColor { get; }
        public String Time => DateTime.Now.ToLongTimeString();

        public string Text { get; }

        public LogMessage(string bgColor, string text)
        {
            BgColor = bgColor;
            Text = text;
        }

        public static LogMessage NormalMessage(string text)
        {
            return new LogMessage("#03a9f4", text);
        }

        public static LogMessage WarningMessage(string text)
        {
            return new LogMessage("#f9a825", text);
        }

        public static LogMessage FailureMessage(string text)
        {
            return new LogMessage("#b71c1c", text);
        }

        public static LogMessage SuccessMessage(string text)
        {
            return new LogMessage("#689f38", text);
        }
    }
}