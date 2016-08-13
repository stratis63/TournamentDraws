﻿using System.Collections.Generic;
using Models.Contracts;

namespace Models
{
    public class Division : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int DivisionGroupId { get; set; }
        public ICollection<Team> Teams { get; set; } = new List<Team>();
    }
}