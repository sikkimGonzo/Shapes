select 
    p.Title,
    c.Title
from
    Products as p
left join ProductsCategories as pc
  on p.Id = pc.ProductId
left join Categories as c
  on pc.CategoryId = c.Id
