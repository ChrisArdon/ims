create procedure st_getProductByBarcode 
@barcode nvarchar(100)
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
p.pro_price as 'Price'
from products p where p.pro_barcode = @barcode