﻿using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool IsWeight) : base(name, IsWeight)
        {
            Type = GradeBookType.Standard;
        }
    }
}

