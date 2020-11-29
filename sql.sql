create database gestion_stagiaire_eta_finale
use gestion_stagiaire_eta_finale
create table [admin]
(
[login] varchar(50),
[password] varchar(50)
)

create table specialite 
(
idsp int identity (1,1)primary key,
SPECIALITE varchar(50),
Etat  bit DEFAULT 1,
)
create table [SERVICE]
(
idserv int identity (1,1)primary key,

[SERVICE] varchar(50),
Etat  bit DEFAULT 1,
)
create table stagiaire 
(
idSTAGIAIRE int identity (1,1) primary key,
NOM varchar(50),
PRENOM varchar(50),
CIN varchar(10),
ADRESSE varchar(50),
TELEPHON varchar(14),
ETABLISSEMENT varchar(50),

[DATE debut] date,
[DATE fin] date,
ATTESTATION bit,
BADGE bit,

 idspecialite int foreign key references specialite(idsp),
 idSERVICE int FOREIGN KEY REFERENCES [SERVICE](idserv),
)





























