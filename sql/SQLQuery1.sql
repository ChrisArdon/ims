create database imsDB
use imsDB

create table users
(
usr_id int not null identity primary key,
usr_name varchar(40) not null,
usr_username varchar(30) not null,
usr_password nvarchar(30) not null,
usr_phone varchar(15) not null,
usr_email varchar(50) not null,

usr_status tinyint not null default 1 --This is for a user that we have in our database but we don't want him to use the program
)

create procedure st_insertUsers
@name varchar(40),
@username varchar(30),
@pwd nvarchar(30),
@phone varchar(15),
@email varchar(50),
@status tinyint
as
insert into users values (@name, @username, @pwd, @phone, @email, @status)

create procedure st_UpdateUsers
@name varchar(40),
@username varchar(30),
@pwd nvarchar(30),
@phone varchar(15),
@email varchar(50),
@status tinyint,
@id int
as
update users
set
usr_name = @name,
usr_username = @username,
usr_password = @pwd,
usr_phone = @phone,
usr_email = @email,
usr_status = @status
where  usr_id = @id

create procedure st_deleteUser
@id int
as
delete from users where usr_id = @id

create procedure st_getUsersData
as
select
u.usr_id as 'ID',
u.usr_name as 'Name',
u.usr_username as 'Username',
u.usr_password as 'Password',
u.usr_phone as 'Phone',
u.usr_email as 'Email',
case when (usr_status = 1) then 'Active' else 'In-active' end as 'Status' from users u
order by u.usr_name asc

create procedure st_getUsersDataLIKE
@data varchar(50)
as
select
u.usr_id as 'ID',
u.usr_name as 'Name',
u.usr_username as 'Username',
u.usr_password as 'Password',
u.usr_phone as 'Phone',
u.usr_email as 'Email',
case when (usr_status = 1) then 'Active' else 'In-active' end as 'Status' from users u
where
u.usr_name like '%'+@data+'%'
or
u.usr_username like '%'+@data+'%'
or
u.usr_phone like '%'+@data+'%'
or
u.usr_email like '%'+@data+'%'
order by u.usr_name asc
