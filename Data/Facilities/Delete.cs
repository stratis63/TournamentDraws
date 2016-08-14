﻿using DataProvider.Contracts;

namespace Data.Facilities
{
    public class Delete : ICommand
    {
        private readonly int _id;

        public Delete(int id)
        {
            _id = id;
        }

        public void Execute(ISession session)
        {
            session.Execute("Delete from Facilities where Id = @Id", new { Id = _id });
        }
    }
}
