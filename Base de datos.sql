-- Creamos la base de datos.
CREATE DATABASE bookstore;

use bookstore;

-- Creamos las tablas author y book.
create table author(
id int identity(1,1) not null,
names varchar(50) not null,
);

create table book(
id int identity(1,1) not null,
title varchar(50) not null,
chapters int not null,
pages int not null,
price int not null,
autor_id int not null
);

-- Agregamos las llavves primarias a las tablas y agregamos la llave foranea para ligar el autor con los libros.
alter table author add constraint PK_author primary key(id);
alter table book add constraint PK_book primary key(id);

alter table book add constraint PK_book_author foreign key(autor_id) references author(id);


/*Insercion de datos*/
INSERT INTO author (names) VALUES ('J. K. Rowlingn');
INSERT INTO author (names) VALUES ('Benito Taibo');

INSERT INTO book (title, chapters, pages, price, autor_id) VALUES ('Harry Potter and the Goblet of Fire', 37, 635, 249, 1);
INSERT INTO book (title, chapters, pages, price, autor_id) VALUES ('Persona Normal', 25, 280, 298, 2);
INSERT INTO book (title, chapters, pages, price, autor_id) VALUES ('Cómplices', 3, 192, 258, 2);




