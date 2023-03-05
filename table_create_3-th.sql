--use warehouse
--alter database scoped configuration set identity_cache=off 


--create table product
--(
--	--id товара
--	id_p int  identity (1,1) primary key not null,
--	--тип товара товара
--	type_p nvarchar( 30 ) not null,
--	--поставщик товара
--	product_supplier_p int not null,
--	-- вторичный ключ
--	foreign key (product_supplier_p) references link_table(num_l)
--)

--create table supplier
--(
--	id_s int not null identity (1,1) primary key,
--	-- вторичный ключ, он же имя поставщика из таблицы соединения
--	name_s nvarchar( 30 ) not null,
--	foreign key (name_s) references link_table(name_l),
--	-- количество едениц товара
--	quantity_s int not null,
--	-- себестоимость товара
--	cost_price_s int not null,
--	-- дата поставки
--	date_s date not null
--)
create table link_table
(
	-- id для порядка
	--id_l int  identity (1,1) primary key not null,
	--  вторичный ключ, он же номер поставщика
	num_l int not null ,
	foreign key (num_l) references product (id_p),
	-- вторичный ключ, он же имя поставщика
	name_l int not null,
	foreign key (name_l) references supplier(id_s)
	)
	----alter database scoped configuration set identity_cache=off 
