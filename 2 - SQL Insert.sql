USE Employee
GO 

INSERT INTO dbo.Employee (Name ,Surname ,Birth_Date ,Active, Email_Address, Date_Created ,User_Created)          
                  VALUES ('Nino' , 'Smith' , '1992-06-10' ,1 , 'gmail1Nino@gmail.co.za' , GETDATE(), 'SQL Test'),
				         ('Hello' , 'World' ,'1971-02-02' ,1 ,'gmail1Hello@gmail.co.za' ,GETDATE(), 'SQL Test'),
						 ('Goodbye' , 'Hello' , '1982-04-30' ,1 ,'gmail1Goodbye@gmail.co.za' ,GETDATE(), 'SQL Test'),
						 ('Chester' , 'Williams' , '1965-10-23' ,1 ,'gmailWillams@gmail.co.za' ,GETDATE(), 'SQL Test'),
						 ('Braam' , 'van Straaten' , '1963-12-24',1 ,'gmail1Braam@gmail.co.za' ,GETDATE(), 'SQL Test'),
						 ('Hercelle' , 'Gibbs' , '1983-11-11' ,1 ,'gmail1Gibbs@gmail.co.za' ,GETDATE(), 'SQL Test');
    