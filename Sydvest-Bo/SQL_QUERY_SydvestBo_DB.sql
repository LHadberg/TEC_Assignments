use master
go
drop database SydvestBoDB
go
create database SydvestBoDB
go
use SydvestBoDB
go
create table PostNrBy
(
 PostNr int primary key,
 ByNavn nvarchar(50) not null
)
go
INSERT INTO PostNrBy VALUES
(2720, 'Vanløse'),
(2730, 'Herlev'),
(2000, 'Frederiksberg'),
(2650, 'Hvidovre'),
(2750, 'Ballerup'),
(2725, 'Andeby')
go
create table PersonType
(
 TypeNavn nvarchar(20) primary key,
 Beskrivelse nvarchar(max) not null
)
go
INSERT INTO PersonType VALUES
('Sommerhusejer', 'Ejeren af ét eller flere sommerhuse i området'),
('Kunde', 'En kunde der har én eller flere reservationer'),
('Opsynsmand', 'Timelønnet og ansvarlig for at aflæse strøm og efterse huse'),
('Udlejningskonsulent', 'Ansvarlig for udlejning i ét eller flere områder. ')
go
create table SaesonKategorier
(
 UgeNr int primary key identity(1,1),
 KategoriNavn nvarchar(20) not null
)
go
INSERT INTO SaesonKategorier VALUES
('Lav'),('Lav'),('Lav'),('Lav'),('Lav'),('Normal'),('Normal'),('Lav'),('Lav'),('Lav'),
('Lav'),('Normal'),('Normal'),('Høj'),('Høj'),('Normal'),('Normal'),('Normal'),('Normal'),('Normal'),
('Normal'),('Normal'),('Høj'),('Høj'),('Høj'),('Høj'),('Høj'),('Super'),('Super'),('Super'),
('Høj'),('Høj'),('Høj'),('Høj'),('Høj'),('Høj'),('Normal'),('Normal'),('Normal'),('Normal'),
('Normal'),('Høj'),('Normal'),('Normal'),('Normal'),('Normal'),('Normal'),('Lav'),('Lav'),('Lav'),
('Lav'),('Super'),('Super')
go
create table HusKlasse
(
 KlasseID int primary key identity (1,1),
 KlasseNavn nvarchar(50) not null
)
go
INSERT INTO HusKlasse VALUES
('*'),
('**'),
('***'),
('****'),
('*****'),
('******')
go
create table PersonTabel
(
 PersonID int primary key identity (1,1),
 Fornavn nvarchar(50) not null,
 Efternavn nvarchar(50) not null,
 TypeNavn nvarchar(20) not null,
 Adresse nvarchar(75) not null,
 PostNr int not null,
 Email nvarchar(100) not null,
 TlfNr int not null,
 constraint FK_PersonTabel_PostNrBy_PostNr foreign key (PostNr) references PostNrBy(PostNr),
 constraint FK_PersonTabel_PersonType_TypeNavn foreign key (TypeNavn) references PersonType(TypeNavn)
)
go
INSERT INTO PersonTabel VALUES
('Georg', 'Gearløs', 'Opsynsmand', 'Store Velstands Boulevard, 40', 2725, 'GG@Andemail.ab', 25256068),
('Anders', 'And', 'Kunde', 'Paradisæblevej 111', 2725, 'AA@Andemail.ab', 25602862),
('Emil', 'Galvit', 'Udlejningskonsulent', 'Herlevvej 69', 2730, 'Galvit@gmail.com', 42069420),
('Daniel', 'Matthiesen', 'Sommerhusejer', 'Frbvej 420', 2000, 'Danielbonghead@gmail.com', 42042069),
('Lasse', 'Hadberg', 'Udlejningskonsulent', 'Vanløsevej 4', 2720, 'Lasse@Hotmail.com', 40404647),
('Papa', 'Dunkel', 'Sommerhusejer', 'Frbvej 420', 2000, 'PapaDunkel@HoistTheDong.com', 69420420)
create table OmraadeTabel
(
 OmraadeID int primary key identity(1,1),
 PersonID int not null,
 PostNr int not null,
 constraint FK_OmraadeTabel_PostNrBy_PostNr foreign key (PostNr) references PostNrBy(PostNr),
 constraint FK_OmraadeTabel_PersonType_PersonID foreign key (PersonID) references PersonTabel(PersonID)
)
go
INSERT INTO OmraadeTabel VALUES
(1, 2725),
(4, 2725),
(3, 2730),
(5, 2730),
(2, 2000)
go
create table SommerhusTabel
(
 HusID int primary key identity (1,1),
 OmraadeID int not null,
 KlasseID int not null,
 PersonID int not null,
 Beskrivelse nvarchar(255) not null,
 Adresse nvarchar(255)not null,
 constraint FK_SommerhusTabel_OmraadeTabel_OmraadeID foreign key (OmraadeID) references OmraadeTabel(OmraadeID),
 constraint FK_SommerhusTabel_HusKlasse_KlasseID foreign key (KlasseID) references HusKlasse(KlasseID),
 constraint FK_SommerhusTabel_PersonType_PersonID foreign key (PersonID) references PersonTabel(PersonID)
)
go
INSERT INTO SommerhusTabel values
(1, 6, 4, 'Utroligt flot hus der ligner tusindårsfalken set forfra. ','Tornerosevej 12'),
(1, 2, 6, 'Ligner en TIE fighter... ','yeehawistan'),
(2, 3, 4, 'Flot hus fra Paradise Motel','valby St vej 12'),
(2, 4, 4, 'Det bedste resultat fra MTV Cribs','En addresse')
go
create table Reservationstabel
(
 ResID int primary key identity(1,1),
 PersonID int not null,
 HusID int not null,
 UgeNr int not null,
 Aarstal int not null,
  Pris int not null,
 constraint FK_ReservationsTabel_PersonType_PersonID foreign key (PersonID) references PersonTabel(PersonID),
 constraint FK_ReservationsTabel_SommerhusTabel_HusID foreign key (HusID) references SommerhusTabel(HusID),
 constraint FK_ReservationsTabel_SaesonKategorier foreign key (UgeNr) references SaesonKategorier(UgeNr)
)
INSERT INTO Reservationstabel VALUES
(1, 1, 21, 2018,20000),
(1, 2, 25, 2019,16666),
(5, 2, 22, 2018,15000),
(3, 3, 28, 2019,5000),
(5, 2, 29, 2018,6000),
(3, 3, 3, 2019,5500),
(4, 4, 52, 2019,10000)

select
u.Fornavn + ' ' + u.Efternavn Huslejer,
l.Fornavn + ' ' + l.Efternavn Udlejer,
SommerhusTabel.Adresse,
SommerhusTabel.Beskrivelse,
SaesonKategorier.*
from
PersonTabel u
left join Persontabel l ON l.TypeNavn = 'Sommerhusejer'
left join Reservationstabel ON u.PersonID = Reservationstabel.PersonID
left join SommerhusTabel ON SommerhusTabel.HusID = Reservationstabel.HusID AND SommerhusTabel.HusID = 2
left join SaesonKategorier ON Reservationstabel.UgeNr = SaesonKategorier.UgeNr
where Reservationstabel.HusID IS NOT NULL AND l.PersonID = SommerhusTabel.PersonID
order by
ResID;