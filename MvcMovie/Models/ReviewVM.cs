﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class ReviewVM
    {
        public List<Review> Reviewer { get; set; }
        public List<String> Comment { get; set; }
    }
}
