-- https://youtu.be/0OVtPsTb6EE min 17:40

create table categories
(
cat_id int not null identity primary key,
cat_name varchar(50) not null,
cat_isActive tinyint not null
)

create procedure st_insertCategory
@name varchar(50),
@isActive tinyint
as 
insert into categories values (@name, @isActive)

create procedure st_updateCategory
@name varchar(50),
@isActive tinyint,
@id int
as
update categories
set
cat_name = @name,
cat_isActive = @isActive
where 
cat_id = @id

create procedure st_deleteCategory
@id int 
as 
delete from categories where cat_id = @id

create procedure st_getCategoriesData
as 
select 
c.cat_id as 'ID',
c.cat_name as 'Category',
case when (c.cat_isActive = 1) then 'Yes' else 'No' end as 'Status'
from categories c
order by c.cat_name asc

create procedure st_getCategoriesList
as
select c.cat_id as 'ID',
c.cat_name as 'Category'
from categories c
order by c.cat_name asc

create procedure st_getCategoriesDataLIKE
@data varchar(50)
as
select
c.cat_id as 'ID',
c.cat_name as 'Name',
case when (c.cat_isActive = 1) then 'Yes' else 'No' end as 'Status'
from categories c
where 
c.cat_name like '%' +@data+ '%'
order by c.cat_name asc