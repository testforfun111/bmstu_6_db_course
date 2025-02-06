drop table userdb CASCADE;
drop table promodb CASCADE;
drop table productdb CASCADE;
drop table userpromodb CASCADE;
drop table cartdb CASCADE;
drop table itemcartdb CASCADE;
drop table orderdb CASCADE;
drop table itemorderdb CASCADE;

create table UserDB(
	Id serial primary key,
	Name varchar(50) not null,
	Phone varchar(50) not null,
	Address varchar(50) not null,
	Email varchar(50) not null,
	Login varchar(50) not null,
	Password varchar(50) not null,
	Role varchar(50) not null
);

create table PromoDB(
	Id serial primary key,
	code varchar(20) not null,
	discount int not null,
	data_start date not null,
	data_end date not null
);
create table ProductDB (
	Id serial primary key,
	Name varchar(50) not null,
	Price int not null,
	Quantity int not null,
	Manufacturer varchar(50) not null,
	Description varchar(50) not null
);
create table UserPromoDB(
	ID serial primary key,
	id_user int not null,
	id_promo int not null,
	foreign key (id_user) references UserDB(Id) ON DELETE CASCADE,
	foreign key (id_promo) references PromoDB(Id) ON DELETE CASCADE
);

create table CartDB(
	Id serial primary key,
	data_created date not null,
	id_user int references UserDB(Id) ON DELETE CASCADE
);

create table ItemCartDB(
	Id serial primary key,
	id_product int not null,
	id_cart int not null,
	quantity int not null,
	foreign key (id_cart) references CartDB(Id) ON DELETE CASCADE,
	foreign key (id_product) references ProductDB(Id) ON DELETE CASCADE
);

create table orderDB(
	Id serial primary key,
	status varchar(20) not null,
	data_created date not null,
	id_user int not null,
	id_promo int references PromoDB(Id) ON DELETE CASCADE,
	foreign key (id_user) references UserDB(Id) ON DELETE CASCADE
);

create table ItemOrderDB(
	Id serial primary key,
	id_product int not null,
	id_order int not null,
	quantity int not null,
	foreign key (id_order) references OrderDB(Id) ON DELETE CASCADE,
	foreign key (id_product) references ProductDB(Id) ON DELETE CASCADE
);


COPY UserDB (Name, Login, Password, Address, Email, Phone, Role) FROM 'E:\UserTable.csv' DELIMITER ',' CSV;

COPY PromoDB (data_start, data_end, discount, code) FROM 'E:\PromoTable.csv' DELIMITER ',' CSV;

COPY UserPromoDB (id_user, id_promo) FROM 'E:\UserPromoTable.csv' DELIMITER ',' CSV;

COPY CartDB (data_created, id_user) FROM 'E:\CartTable.csv' DELIMITER ',' CSV;

COPY ItemCartDB (id_product, id_cart, quantity) FROM 'E:\ItemCartTable.csv' DELIMITER ',' CSV;

COPY OrderDB (status, data_created, id_user, id_promo) FROM 'E:\OrderTable.csv' DELIMITER ',' CSV;

COPY ItemOrderDB (id_product, id_order, quantity) FROM 'E:\ItemOrderTable.csv' DELIMITER ',' CSV;

COPY ProductDB (name, price, quantity, manufacturer, description) FROM 'E:\ProductTable.csv' DELIMITER ',' CSV;

-- #trigger
drop trigger after_itemorder_insert on itemorderdb;

create or replace function process_itemorder()
returns trigger
as
$$
begin
	update productdb set quantity = (select quantity - new.quantity from productdb where id = new.id_product) where id = new.id_product;
    RETURN NEW;
	
end;
$$	LANGUAGE plpgsql;

CREATE TRIGGER after_itemorder_insert
AFTER INSERT ON itemorderdb
for each row
EXECUTE FUNCTION process_itemorder();


-- test trigger
CREATE OR REPLACE FUNCTION test_trigger(product_id int, order_id int, quantityI int)
RETURNS void AS $$
DECLARE
    quantity_after int;
	quantity_before int;
BEGIN
	select quantity into quantity_before from productdb where id = product_id;
	
    INSERT INTO itemorderdb(id_product, id_order, quantity) VALUES (product_id, order_id, quantityI);
	
    SELECT quantity INTO quantity_after FROM productdb WHERE id = product_id;

	if (quantity_after  = quantity_before - quantityI) then
		RAISE NOTICE 'This test passed';
	else 
		RAISE EXCEPTION 'Test failed';
	end if;
END;
$$ LANGUAGE plpgsql;

-- Запуск теста
SELECT test_trigger(1, 1, 5);
SELECT test_trigger(2, 1, 5);
SELECT test_trigger(3, 1, 5);

