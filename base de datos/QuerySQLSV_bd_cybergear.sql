-- Crear la base de datos
CREATE DATABASE bd_cybergear;
GO

USE bd_cybergear;
GO

-- Crear la tabla tipos_usuario
CREATE TABLE tipos_usuario (
  id INT PRIMARY KEY,
  tipo VARCHAR(30) NOT NULL
);
GO

-- Insertar datos en tipos_usuario
INSERT INTO tipos_usuario (id, tipo) VALUES
(1, 'ADMIN'),
(2, 'SUPERVISOR'),
(3, 'VENDEDOR');
GO

CREATE TABLE domicilios (
    id INT PRIMARY KEY IDENTITY(1,1),
    direccion VARCHAR(40) NOT NULL,
    cod_postal INT NOT NULL
);

-- Crear las otras tablas con columnas de identidad
CREATE TABLE clientes (
    id_cliente INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(255) NOT NULL,
    apellido VARCHAR(255) NOT NULL,
    dni INT NOT NULL,
    domicilio_id INT NOT NULL,
    email VARCHAR(255) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    sexo VARCHAR(20) NOT NULL,
    telefono INT NOT NULL,
    FOREIGN KEY (domicilio_id) REFERENCES domicilios(id)
);




CREATE TABLE products (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre_producto VARCHAR(255),
    precio_producto DECIMAL(16,2),
    descripcion TEXT,
    categoria_id INT NOT NULL,
    cantidad INT NOT NULL,
    activo VARCHAR(2) NOT NULL DEFAULT 'SI'
);

CREATE TABLE usuarios (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(30) NOT NULL,
    apellido VARCHAR(30) NOT NULL,
    email VARCHAR(50) NOT NULL,
    usuario VARCHAR(20) NOT NULL,
    pass VARCHAR(50) NOT NULL,
    perfil_id INT NOT NULL DEFAULT 2,
    domicilio_id INT NULL,
    tel INT NULL,
    baja VARCHAR(2) NOT NULL,
    FOREIGN KEY (perfil_id) REFERENCES tipos_usuario(id),
    FOREIGN KEY (domicilio_id) REFERENCES domicilios(id)
);

CREATE TABLE ventas_cabecera (
    id INT PRIMARY KEY IDENTITY(1,1),
    fecha DATE NOT NULL,
    id_cliente INT NOT NULL,
    total_venta DECIMAL NOT NULL,
    FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente)
);

CREATE TABLE ventas_detalle (
    id INT PRIMARY KEY IDENTITY(1,1),
    venta_id INT NOT NULL,
    producto_id INT NOT NULL,
    cantidad_venta INT NOT NULL,
    precio DECIMAL NOT NULL,
    sub_total DECIMAL NOT NULL,
    FOREIGN KEY (venta_id) REFERENCES ventas_cabecera(id),
    FOREIGN KEY (producto_id) REFERENCES products(id)
);


INSERT INTO usuarios (nombre, apellido, email, usuario, pass, perfil_id, baja)
VALUES ('NombreAdmin', 'ApellidoAdmin', 'admin@example.com', 'admin', 'admin', 1, 'NO');