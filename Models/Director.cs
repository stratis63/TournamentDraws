﻿using Models.Contracts;

namespace Models
{
    public class Director : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int TournamentId { get; set; }

        public Tournament Tournament { get; set; }
    }
}