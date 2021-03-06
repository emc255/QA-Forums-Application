﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseProject_StackOverFlowV2.Models {
    public class Tag {
        public Tag() {
            QuestionTags = new HashSet<QuestionTag>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<QuestionTag> QuestionTags { get; set; }
    }
}