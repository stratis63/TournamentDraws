﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Contracts;

namespace Models
{
    public class Matchup : IEntity
    {
        public int Id { get; set; }
        public int Team1Id { get; set; }
        public int Team2Id { get; set; }
        public int FacilityId { get; set; }
        public int CourtId { get; set; }
        public int MatchDateTimeId { get; set; }

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Facility Facility { get; set; }
        public Court Court { get; set; }
        public MatchDateTime MatchDateTime { get; set; }
    }
}
