

CREATE TABLE Klub (
ID int NOT NULL identity,
ImeKluba varchar(255) NOT NULL,
DatumOsnivanja date NOT NULL,
OIB INT NOT NULL,
Clanarina float NOT NULL,
adresa varchar(255) not null,
PRIMARY KEY (ID));



Create TABLE Sportas (
ID int not null identity,
KlubID int not null,
TrenerID int,
Ime varchar(255) NOT NULL,
Prezime varchar(255) NOT NULL,
DatumRodenja date NOT NULL,
OIB INT NOT NULL,
MjestoStanovanja varchar(255) NOT NULL,
Adresa varchar(255) not null,
LijecnickiPregled datetime not null,
DatumUpisa datetime NOT NULL,
primary key(ID)
);


CREATE TABLE Trener (
ID int NOT NULL identity,
KlubID int not null,
SportasID int not null,
IsAdmin bit NOT NULL,
ime varchar(255) NOT NULL,
prezime varchar(255) NOT NULL,
OIB INT NOT NULL,
adresa varchar(255),
primary key(ID)

);

create table Clanarina(
ID int not null,
SportasID int not null,
KlubID int  not null,
mjesec date not  null,
iznos float not null,
primary key(ID)
);


CREATE TABLE Sport(
ID int NOT NULL IDENTITY,
KlubID int NOT NULL,
ImeSporta varchar(255)
PRIMARY KEY(ID)
);





