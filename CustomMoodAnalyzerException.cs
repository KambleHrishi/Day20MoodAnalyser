﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public enum ExceptionType
    {
        NULL_VALUE,
        EMPTY_TYPE,
    }

    public class CustomMoodAnalyzerException : Exception
    {
        public ExceptionType extype;

        public CustomMoodAnalyzerException(string msg, ExceptionType extype) : base(msg)
        {
            this.extype = extype;
        }
    }

}
