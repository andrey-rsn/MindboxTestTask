--products (таблица продуктов)
--categories (таблица категорий)
--productsCategories (таблица категорий продуктов (отношение многие ко многим) )

select products.product_name,categories.category_name from productsCategories 
full outer join products on productsCategories.product_id=products.id
full outer join categories on productsCategories.category_id=categories.id

