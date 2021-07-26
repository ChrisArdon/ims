create table purchaseInvoice
(
pi_id bigint not null identity primary key,
pi_date date not null,
pi_doneBy int not null,
pi_suppID int not null,
)

create table purchaseInvoiceDetails
(
pid_id bigint not null identity primary key,
pid_purchaseID bigint not null foreign key references purchaseInvoice(pi_id),
pid_proID int not null,
pid_proquan int not null,
pid_totprice money not null
)

create procedure st_inserPurchaseINvoice
@date date,
@doneBy int,
@suppID int
as 
insert into purchaseInvoice values (@date, @doneBy, @suppID)

create procedure st_getLastPurchaseID
as
select top 1 pii.pi_id
from purchaseInvoice pii
order by pii.pi_id desc --here in the desc order is where we pick the last purchase

create procedure st_insertPurchaseInvoiceDetails
@purchaseID bigint,
@proID int,
@quan int,
@totPrice money
as
insert into purchaseInvoiceDetails values (@purchaseID, @proID, @quan, @totPrice)

alter procedure st_getPurchaseInvoiceList
@month int,
@year int
as
select
pii.pi_id as 'ID',
su.sup_company+' '+FORMAT(pii.pi_date,'dd-MMM-yyyy') as 'Company'
from purchaseInvoice pii inner join supplier su on su.sup_id = pii.pi_suppID
where month(pii.pi_date) = @month and year(pii.pi_date) = @year

alter procedure st_getPurchaseInvoiceDetails
@pid bigint
as
select 
pid.pid_proID as 'Product ID',
p.pro_name as 'Product',
pid.pid_proquan as 'Quantity',
pid.pid_totprice as 'Total Price',
p.pro_price as 'Per Unit Price'
from purchaseInvoice pii 
inner join purchaseInvoiceDetails pid 
inner join products p on p.pro_id = pid.pid_proID on pii.pi_id = pid.pid_purchaseID
where pii.pi_id = @pid