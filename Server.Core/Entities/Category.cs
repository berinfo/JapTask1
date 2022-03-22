﻿using System;
using System.Collections.Generic;

namespace server.Models
{
    public class Category
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public DateTime CreatedAt { get; set; }
        public List<Recipe> Recipes { get; set; }

    }
}
