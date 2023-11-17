USE [master];

CREATE DATABASE dboDinassaur;

USE [dboDinassaur];

CREATE TABLE age (
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(60) NOT NULL,
	yBeg INTEGER NOT NULL,
	yEnd INTEGER NOT NULL
);

CREATE TABLE grupos (
	id INTEGER PRIMARY KEY NOT NULL IDENTITY,
	nome VARCHAR(50) NOT NULL
);

CREATE TABLE dinossaur (
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(25) NOT NULL,
	fk_grupo INTEGER NOT NULL,
	toneladas INTEGER NOT NULL,
	yDescoberta INTEGER NOT NULL,
	descobridor VARCHAR(50) NOT NULL,
	fk_age INTEGER NOT NULL,
	pais VARCHAR(50) NOT NULL,

	FOREIGN KEY (fk_grupo) REFERENCES grupos(id),
	FOREIGN KEY (fk_age) REFERENCES age(id),
);

INSERT INTO age VALUES (
	'Cret�ceo',
	145,
	65
), (
	'Jur�ssico',
	205,
	142
);

INSERT INTO grupos VALUES (
	'Anquilossauros'
), (
	'Ceratops�deos'
), (
	'Estegossauros'
), (
	'Ter�podes'
);

INSERT INTO dinossaur VALUES (
	'Saichana',
	1,
	4,
	1977,
	'Maryanska',
	1,
	'Mong�lia'
), (
	'Triceratops',
	2,
	6,
	1887,
	'John Bell Hatcher',
	1,
	'Canada'
), (
	'Kentossauro',
	3,
	2,
	1909,
	'Cientitas Alem�es',
	2,
	'Tanz�nia'
), (
	'Pinacossauro',
	1,
	6,
	1999,
	'Museu Americano de Hist�ria Natural',
	1,
	'China'
), (
	'Alossauro',
	4,
	3,
	1877,
	'Othinel Charles Marsh',
	2,
	'Am�rica do Norte'
), (
	'Torossauro',
	2,
	8,
	1891,
	'John Bell Hatcher',
	1,
	'USA'
), (
	'Anquilossauro',
	1,
	8,
	1906,
	'John Bell Hatcher',
	1,
	'Am�rica do Norte'
);
