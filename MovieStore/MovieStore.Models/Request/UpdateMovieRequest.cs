﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models.Request
{
    public class UpdateMovieRequest
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }
    }
}