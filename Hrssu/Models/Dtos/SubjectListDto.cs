﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hrssu.Models.Dtos
{
    public class SubjectListDto
    {
        public int SubjectId { get; set; }
        public string FormTeacher { get; set; }
        public string UserId { get; set; }
        public string SubjectName { get; set; }
        public int? ClassLevelId { get; set; }
    }
}