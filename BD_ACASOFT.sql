CREATE DATABASE ACASOFT
USE ACASOFT

CREATE TABLE CURSO(
	ID_CURSO CHAR(6) NOT NULL PRIMARY KEY,
	NOMBRE_CURSO VARCHAR(50) NOT NULL
)

CREATE TABLE PROFESOR(
	ID_PROF INT IDENTITY(1000,1) PRIMARY KEY,
	DNI_PROF CHAR(8)  NOT NULL,
	NOMBRE_PROF VARCHAR(50) NOT NULL,
	APELLIDO_PROF VARCHAR(50) NOT NULL,
	CORREO_PROF VARCHAR(50) NOT NULL,
	ESPECIALIDAD_PROF VARCHAR(50) NOT NULL,
	CELULAR_PROF CHAR(9) 
)

CREATE TABLE CLASE(
	ID_CLAS CHAR(6) NOT NULL PRIMARY KEY,
	ID_CURSO CHAR(6) NOT NULL,
	ID_PROFESOR INT NOT NULL,
	FE_IN_INS_CLAS DATE NOT NULL,
	FE_FI_INS_CLASE DATE NOT NULL,
	CAPACIDAD_CLAS INT NOT NULL,

	FOREIGN KEY(ID_CURSO) REFERENCES CURSO(ID_CURSO),
	FOREIGN KEY(ID_PROFESOR) REFERENCES PROFESOR(ID_PROF)
)

CREATE TABLE HORARIO_CLASE(
	ID_HCLA INT IDENTITY(1000,1) PRIMARY KEY,
	ID_CLAS CHAR(6) NOT NULL,
	DIA_HCLA VARCHAR(20) NOT NULL,
	HORA_HCLA TIME NOT NULL,

	FOREIGN KEY(ID_CLAS) REFERENCES CLASE(ID_CLAS)
)

CREATE TABLE PROD_ACADEMICO(
	ID_PA INT IDENTITY(1000,1) PRIMARY KEY,
	ID_CLAS CHAR(6) NOT NULL,
	NOMBRE_PA VARCHAR(20) NOT NULL,
	FECHA_PA DATE NOT NULL,
	PESO_PA FLOAT NOT NULL,
	DESCRIPCION_PA VARCHAR(50),
	
	FOREIGN KEY(ID_CLAS) REFERENCES CLASE(ID_CLAS)
)

CREATE TABLE ALUMNO(
	ID_AL INT IDENTITY(1000,1) PRIMARY KEY,
	DNI_AL CHAR(8) NOT NULL,
	NOMBRE_AL VARCHAR(50) NOT NULL,
	APELLIDO_AL VARCHAR(50) NOT NULL,
	CORREO_AL VARCHAR(50) NOT NULL,
	CELULAR_AL CHAR(9) 
)

CREATE TABLE EVALUACION(
	ID_EV INT IDENTITY(1000,1) PRIMARY KEY,
	ID_AL INT NOT NULL,
	ID_PA INT NOT NULL,
	NOTA_EV INT NOT NULL,

	FOREIGN KEY(ID_AL) REFERENCES ALUMNO(ID_AL),
	FOREIGN KEY(ID_PA) REFERENCES PROD_ACADEMICO(ID_PA)
)

CREATE TABLE INSCRIPCION(
	ID_INS INT NOT NULL PRIMARY KEY,
	ID_AL INT NOT NULL,
	ID_CLAS CHAR(6) NOT NULL,
	FECHA_INS DATE NOT NULL,

	FOREIGN KEY(ID_AL) REFERENCES ALUMNO(ID_AL),
	FOREIGN KEY(ID_CLAS) REFERENCES CLASE(ID_CLAS)
)