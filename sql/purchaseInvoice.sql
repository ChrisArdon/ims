create procedure st_getProductByBarcode 
@barcode nvarchar(100)
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
p.pro_price as 'Price',
p.pro_barcode as 'Barcode'
from products p where p.pro_barcode = @barcode