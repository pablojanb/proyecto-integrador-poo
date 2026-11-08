
CREATE TABLE IF NOT EXISTS personas(
	id BIGINT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    dni VARCHAR(50) UNIQUE,
    direccion VARCHAR(150),
    telefono VARCHAR(50),
    email VARCHAR(50),
    apto_fisico BOOLEAN NOT NULL
);

INSERT INTO personas (id, nombre, apellido, dni, direccion, telefono, email, apto_fisico)
SELECT 1, 'Juan', 'Perez', '43950994', 'Av. Santa Fe 453', '1155938500', 'juanperez@gmail.com', TRUE
WHERE NOT EXISTS (SELECT 1 FROM personas WHERE email = 'juanperez@gmail.com');

INSERT INTO personas (id, nombre, apellido, dni, direccion, telefono, email, apto_fisico)
SELECT 2, 'Lucia', 'Torres', '42556336', 'Congreso 221', '1154764433', 'luciatorres@gmail.com', TRUE
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
    FOREIGN KEY (id) REFERENCES personas(id)
);

INSERT INTO socios (id, fecha_alta)
SELECT 2, '2026-03-04' WHERE NOT EXISTS (SELECT 1 FROM socios WHERE id = 2);

CREATE TABLE IF NOT EXISTS membresias (
	id BIGINT PRIMARY KEY AUTO_INCREMENT,
    id_socio BIGINT,
    monto DECIMAL,
    periodo DATE,
    fecha_vencimiento DATE,
	FOREIGN KEY (id_socio) REFERENCES socios(id)
);

INSERT INTO membresias (id_socio, monto, periodo, fecha_vencimiento)
SELECT 2, 30000.00, '2026-10-01', '2026-10-5' WHERE NOT EXISTS (SELECT 1 FROM membresias WHERE id_socio = 2);

CREATE TABLE IF NOT EXISTS medios_pago (
	id BIGINT PRIMARY KEY AUTO_INCREMENT,
    descripcion VARCHAR(40)
);

INSERT INTO medios_pago (id, descripcion)
SELECT 1, "Efectivo" WHERE NOT EXISTS (SELECT 1 FROM medios_pago WHERE id = 1);

INSERT INTO medios_pago (id, descripcion)
SELECT 2, "Crédito" WHERE NOT EXISTS (SELECT 1 FROM medios_pago WHERE id = 2);

CREATE TABLE IF NOT EXISTS pagos (
	id BIGINT PRIMARY KEY AUTO_INCREMENT,
    id_membresia BIGINT,
	id_medio_pago BIGINT,
    fecha_hora DATETIME,
    monto DECIMAL,
    detalle VARCHAR(255),
	FOREIGN KEY (id_membresia) REFERENCES membresias(id),
    FOREIGN KEY (id_medio_pago) REFERENCES medios_pago(id)
);

INSERT INTO pagos (id_membresia, id_medio_pago, fecha_hora, monto, detalle)
SELECT 1, 2, '2026-10-01 10:30:00', 20000.00, 'Pago mensual de membresía' WHERE NOT EXISTS (SELECT 1 FROM pagos WHERE id = 1);

INSERT INTO pagos (id_membresia, id_medio_pago, fecha_hora, monto, detalle)
SELECT 1, 1, '2026-10-01 10:30:00', 5000.00, 'Pago mensual de membresía' WHERE NOT EXISTS (SELECT 1 FROM pagos WHERE id = 2);

CREATE TABLE IF NOT EXISTS ingresos (
	id BIGINT PRIMARY KEY AUTO_INCREMENT,
    id_persona BIGINT,
    ingresoHorario DATETIME,
    egresoHorario DATETIME NULL,
	FOREIGN KEY (id_persona) REFERENCES personas(id)
);

CREATE TABLE IF NOT EXISTS carnets(
	id BIGINT PRIMARY KEY AUTO_INCREMENT,
    id_persona BIGINT NOT NULL,
    fecha_emision DATE NOT NULL,
    fecha_entrega DATE,
    activo BOOLEAN NOT NULL,
    FOREIGN KEY (id_persona) REFERENCES personas(id)
);

INSERT INTO carnets (id, id_persona, fecha_emision, fecha_entrega, activo)
SELECT 1, 2, '2026-03-04', NULL, FALSE
WHERE NOT EXISTS (SELECT 1 FROM carnets WHERE id = 1);

DROP PROCEDURE IF EXISTS login;
CREATE PROCEDURE login(in p_username varchar(50), in p_password varchar(200))
begin
  select ea.username
	from empleados_administrativos ea
		where ea.username = p_username and ea.password = p_password;
end