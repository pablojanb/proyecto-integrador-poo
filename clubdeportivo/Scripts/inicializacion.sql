
CREATE TABLE IF NOT EXISTS personas(
	id BIGINT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    dni VARCHAR(50),
    direccion VARCHAR(150),
    telefono VARCHAR(50),
    email VARCHAR(50) UNIQUE
);

INSERT INTO personas (id, nombre, apellido, dni, direccion, telefono, email)
SELECT 1, 'Juan', 'Perez', '43950994', 'Av. Santa Fe 453', '1155938500', 'juanperez@gmail.com'
WHERE NOT EXISTS (SELECT 1 FROM personas WHERE email = 'juanperez@gmail.com');

INSERT INTO personas (id, nombre, apellido, dni, direccion, telefono, email)
SELECT 2, 'Lucia', 'Torres', '42556336', 'Congreso 221', '1154764433', 'luciatorres@gmail.com'
WHERE NOT EXISTS (SELECT 1 FROM personas WHERE email = 'luciatorres@gmail.com');

CREATE TABLE IF NOT EXISTS empleados_administrativos(
	id BIGINT PRIMARY KEY,
    num_legajo BIGINT AUTO_INCREMENT UNIQUE,
    username VARCHAR(50) UNIQUE,
    password VARCHAR(200),
    fecha_alta DATE NOT NULL,
    fecha_baja DATE NULL,
	FOREIGN KEY (id) REFERENCES personas(id)
);

INSERT INTO empleados_administrativos (id, username, password, fecha_alta)
SELECT 1, 'admin', '123', '2026-02-01'
WHERE NOT EXISTS (SELECT 1 FROM empleados_administrativos WHERE username = 'admin');

CREATE TABLE IF NOT EXISTS socios(
	id BIGINT PRIMARY KEY,
    num_afiliado BIGINT AUTO_INCREMENT UNIQUE,
    fecha_alta DATE NOT NULL,
    fecha_baja DATE NULL,
	apto_fisico BOOLEAN NOT NULL,
    FOREIGN KEY (id) REFERENCES personas(id)
);

INSERT INTO socios (id, fecha_alta, apto_fisico)
SELECT 2, '2026-03-04', TRUE WHERE NOT EXISTS (SELECT 1 FROM socios WHERE id = 2);

DROP PROCEDURE IF EXISTS login;
CREATE PROCEDURE login(in p_username varchar(50), in p_password varchar(200))
begin
  select ea.username
	from empleados_administrativos ea
		where ea.username = p_username and ea.password = p_password;
end