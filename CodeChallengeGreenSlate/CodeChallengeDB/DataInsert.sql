USE [CodeChallenge]
GO

INSERT INTO [dbo].[User]
           ([Id]
           ,[FirstName]
           ,[LastName])
     VALUES
           (1,'Juan', 'Perez'),
		   (2,'Beto', 'Betes'),
		   (3,'Luis', 'Lopez'),
		   (4,'Susan', 'Sanchez'),
		   (5,'Mary', 'Mendoza')



INSERT INTO [dbo].[Project]
           ([Id]
           ,[StartDate]
           ,[EndDate]
           ,[Credits])
     VALUES
           (1,'20190404','20190910',5),
		   (2,'20190202','20200101',2),
		   (3,'20190604','20190910',6),
		   (4,'20190401','20190910',50),
		   (5,'20191101','20200910',15),
		   (6,'20190411','20190511',25)



USE [CodeChallenge]
GO

INSERT INTO [dbo].[UserProject]
           ([UserId]
           ,[ProjectId]
           ,[IsActive]
           ,[AssignedDate])
     VALUES
           (1,1,1,'20190501'),
		   (1,2,1,'20190501'),
		   (1,3,0,'20190501'),

		   (2,1,1,'20190101'),
		   (2,2,1,'20190501'),
		   (2,3,0,'20190601'),


		   (3,4,1,'20190501'),
		   (3,5,1,'20190501'),
		   (3,6,1,'20190501'),


		   (4,4,1,'20190201'),
		   (4,5,1,'20190201'),
		   (4,6,0,'20190201'),


		   (5,1,1,'20190401'),
		   (5,2,1,'20190301'),
		   (5,4,1,'20190201')

