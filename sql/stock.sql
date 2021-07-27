create table stock
(
st_proID int not null unique,
st_quan int not null
)

create procedure st_insertStock
@proID int,
@quan int
as
insert into stock values (@proID, @quan)

create procedure st_updateStock
@proID int,
@quan int
as
update stock
set st_quan = @quan where st_proID = @proID

create procedure st_getProductQuantity
@proID int 
as 
select
s.st_quan as 'Quantity'
from stock s where s.st_proID = @proID