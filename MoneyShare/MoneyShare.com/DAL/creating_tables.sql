create table records (
    record_id serial PRIMARY KEY,
    category_id int,
    amount money,
	date_record date,
	FOREIGN KEY(category_id) REFERENCES categories(category_id)
);

create table categories (
	category_id serial PRIMARY KEY,
	title varchar(250),
	color varchar(15),
	icon varchar(110),
	category_type int
);

