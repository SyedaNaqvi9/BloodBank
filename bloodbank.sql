create database bloodbank;

create table newDonor(
did int Not Null identity(1,1) primary key,
dname varchar(250) not null,
fname varchar(250) not null,
mname varchar(250) not null,
dob varchar(50) not null,
mobile bigint not null,
gender varchar(25) not null,
email varchar(250) not null,
bloodgroup varchar(250) not null,
city varchar(150) not null,
daddress varchar(550) not null);