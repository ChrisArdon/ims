create table supplier
(
sup_id int not null identity primary key,
sup_company varchar(100) not null unique,
sup_contactPerson varchar(50) not null,
sup_phone1 varchar(15) not null,
sup_phone2 varchar(15),
sup_address nvarchar(100) not null,
sup_ntn varchar(25),
sup_status tinyint not null
)

--Insert
create procedure st_insertSupplier
--the variables must have the same length and type from the table 
@company varchar(100),
@conPerson varchar(50),
@phone1 varchar(15),
@phone2 varchar(15),
@address nvarchar(100),
@ntn varchar(25),
@status tinyint
as
insert into supplier values(@company, @conPerson, @phone1, @phone2, @address, @ntn, @status)

--Update
create procedure st_updateSupplier 
@company varchar(100),
@conPerson varchar(50),
@phone1 varchar(15),
@phone2 varchar(15),
@address nvarchar(100),
@ntn varchar(25),
@status tinyint,
@suppID int
as
update supplier
set
sup_company = @company,
sup_contactPerson = @conPerson,
sup_phone1 = @phone1,
sup_phone2 = @phone2,
sup_address = @address,
sup_ntn = @ntn,
sup_status = @status
where 
sup_id = @suppID

--Delete
create procedure st_deleteSupplier 
@suppID int
as 
delete from supplier where sup_id = @suppID

--Get List
create procedure st_getSupplierList
as
select
s.sup_id as 'ID',
s.sup_company as 'Company'
from supplier s where s.sup_status = 1
order by s.sup_company asc

--Get Data
create procedure st_getSupplierData
as 
select
s.sup_id as 'ID',
s.sup_company as 'Company',
s.sup_contactPerson as 'Contact Person',
s.sup_phone1 as 'Phone 1',
s.sup_phone2 as 'Phone 2',
s.sup_ntn as 'NTN #',
s.sup_address as 'Address',
case when (s.sup_status = 1) then 'Active' else 'In-Active' end as 'Status'
from supplier s order by s.sup_company asc