﻿CREATE TABLE [dbo].[Teams]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
	Name varchar(100) not null, 
	RatingId int foreign key references Ratings(Id) not null, 
	DivisionId int foreign key references Divisions(Id), 
	TournamentId int foreign key references Tournaments(Id) not null 
)
