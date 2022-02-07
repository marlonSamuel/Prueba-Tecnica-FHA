CREATE DATABASE FACTURAS_DB

GO

USE FACTURAS_DB

GO
CREATE TABLE Cliente(
 id int primary key identity,
 nombre varchar(50) not null,
 apellido varchar(50) not null,
 telefono varchar(15) not null,
 correo varchar(50),
 direccion varchar(100)
)

CREATE TABLE Vendedor(
 id int primary key identity,
 codigo int unique,
 nombre varchar(50) not null,
 apellido varchar(50) not null,
 telefono varchar(15) not null,
 correo varchar(50),
 direccion varchar(100)
)

CREATE TABLE Pais(
 id int primary key identity,
 nombre varchar(50)
)

CREATE TABLE Moneda(
 id int primary key identity,
 pais_id int,
 prefijo varchar(5) not null,
 descripcion varchar(25) not null,
 FOREIGN KEY (pais_id) REFERENCES Pais(id)
)

CREATE TABLE Producto(
 id int primary key identity,
 codigo int unique,
 nombre varchar(50) not null,
 precio decimal(8,2) not null,
 stock int not null
)

CREATE TABLE Venta
(
	id int primary key identity,
	no_factura int unique,
	total decimal(11,2),
	fecha datetime not null,
	cliente_id int not null,
	vendedor_id int not null,
	moneda_id int not null,
	FOREIGN KEY (cliente_id) REFERENCES Cliente(id),
	FOREIGN KEY (vendedor_id) REFERENCES Vendedor(id),
	FOREIGN KEY (moneda_id) REFERENCES Moneda(id)
)

CREATE TABLE DetalleVenta
(
	id int primary key identity,
	producto_id int not null,
	cantidad int not null,
	venta_id int not null,
	FOREIGN KEY (producto_id) REFERENCES Producto(id),
	FOREIGN KEY (venta_id) REFERENCES Venta(id)
)