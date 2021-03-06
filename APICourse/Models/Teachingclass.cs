﻿using System;
using System.Collections.Generic;

namespace APICourse.Models
{
    public partial class Teachingclass
    {
        public int Id { get; set; }
        public int Idclass { get; set; }
        public int Idteacher { get; set; }
        public int Session { get; set; }
        public DateTime Day { get; set; }
        public int? State { get; set; }

        public virtual Class IdclassNavigation { get; set; }
        public virtual Teacher IdteacherNavigation { get; set; }
    }
}
