CREATE DATABASE pasienteDB;
GO

USE pasienteDB;
GO

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    NombreUsuario NVARCHAR(50) NOT NULL,
    Contrasena NVARCHAR(50) NOT NULL
);

INSERT INTO Usuarios (NombreUsuario, Contrasena) VALUES ('Alvaro', '12345');
INSERT INTO Usuarios (NombreUsuario, Contrasena) VALUES ('Miguel', '12345');
INSERT INTO Usuarios (NombreUsuario, Contrasena) VALUES ('Daniel', '12345');
 select * from Usuarios