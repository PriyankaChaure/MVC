create table project(projectid bigint  identity primary key,projectname varchar(20),projectdesc varchar(max))
create table student(studentid bigint identity primary key,studentname varchar(20),address varchar(40),emailid varchar(20),phoneno varchar(20))
create table projectassignment(assignmentid bigint identity primary key,studentid bigint references student,assignmentdate datetime,projectid bigint references project)
 
 select * from project
 select * from student
 select * from projectassignment

 insert into project values('Titan','Apple is mum, but insiders report that the company is working on the car called Titan, slated to be road ready in 2019.')
 insert into project values('Project Hanks','when verizon communication was looking to take over alo,they needed to keep deal secret and came up with the code that is called project hanks.')
 insert into project values('Code Talkers','This was the project name for secret wwii program to recruite creek,choctow and other tribal member to transmit coded messages')
 insert into project values('Project 404','Code name for convert us air force mission to laos during vietnam war.')
 insert into project values('Durango','microsoft was looking to build upon its wildly popular xbox 360 gaming console.') 
 insert into project values('X Lab','X Lab projects like self driving cars and google glass are built under the cloak.')
	
insert into student values('priyanka','pune','priyanka@gmail.com','9874563210')
insert into student values('sweety','mumbai','sweety@gmail.com','9999563210')
insert into student values('guddi','delhi','guddi@gmail.com','8888563210')
insert into student values('vishakha','noida','vishakha@gmail.com','1111563210')
insert into student values('neha','chennai','neha@gmail.com','2222563210')
insert into student values('prachi','hydrabad','prachi@gmail.com','5555563210')
insert into student values('sonali','pune','sonali@gmail.com','6666563210')
insert into student values('shital','nashik','shital@gmail.com','3333563210')
insert into student values('shweta','mumbai','shweta@gmail.com','7777563210')
insert into student values('vedanshi','pune','vedanshi@gmail.com','9999563210')
insert into student values('pari','delhi','pari@gmail.com','1233563210')
insert into student values('rajvi','noida','rajvi@gmail.com','1100563210')

insert into projectassignment values(1,'15feb2024',1)
insert into projectassignment values(2,'18feb2024',1)
insert into projectassignment values(3,'12feb2024',1)
insert into projectassignment values(4,'15feb2024',2)
insert into projectassignment values(5,'13feb2024',2)
insert into projectassignment values(6,'14feb2024',3)
insert into projectassignment values(7,'16feb2024',4)
insert into projectassignment values(8,'17feb2024',4)
insert into projectassignment values(9,'15feb2024',4)
insert into projectassignment values(10,'18feb2024',5)
insert into projectassignment values(11,'12feb2024',5)
insert into projectassignment values(12,'15feb2024',6)
insert into projectassignment values(13,'13feb2024',6)

