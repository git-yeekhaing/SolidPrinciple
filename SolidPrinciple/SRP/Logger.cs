using System;

namespace SolidPrinciple
{
    public interface ILogger
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }

    public class Logger : ILogger
    {
        public Logger()
        {

        }

        public void Info(string info)
        {

        }

        public void Debug(string info)
        {

        }

        public void Error(string message, Exception ex)
        {

        }
    }
}