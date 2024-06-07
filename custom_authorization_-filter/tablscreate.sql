create table product(productid bigint identity primary key,productname varchar(50) not null,mfgname varchar(50)not null,price decimal(10,2)not null)
create table usertbl(userid bigint primary key identity,firstname varchar(30)not null,lastname varchar(30)not null,emailid varchar(50)not null,mobileno varchar(20)not null,password varchar(20)not null,address varchar(50)not null)
select * from usertbl
select * from product
insert into product values('mouse','intex',450)
insert into product values('keyboard','dell',550)
insert into product values('computer','hp',4450)
insert into product values('laptop','acer',850)
insert into product values('router','computing',90)
insert into usertbl values('priyanka','chaure','priya@gmail.com','9874563210','priya@12','pune')
insert into usertbl values('prachi','salve','prachi@gmail.com','9999963210','prachi@14','kamshet')
insert into usertbl values('sweety','chaure','sweety@gmail.com','9555563210','sweety@15','akurdi')
delete  from usertbl where userid=5