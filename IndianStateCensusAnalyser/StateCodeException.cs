﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
   
        public class StateCodeException : Exception
        {
            public enum ExceptionType
            {
                FILE_INCORRECT, FILE_NOT_EXISTS, HEADER_INCORRECT, DELIMETER_INCORRECT
            }
            public ExceptionType type;
            public StateCodeException(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }
        }
}
