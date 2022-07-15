USE [Master]
GO
 
CREATE DATABASE [Library]
 
USE [Library]
 
CREATE TABLE [dbo].[Category](
        [Id] [INT] PRIMARY KEY IDENTITY,
        [Name] [VARCHAR](50) UNIQUE NOT NULL
        )
 
CREATE TABLE [dbo].[PublishingHouse](
        [Id] [INT] PRIMARY KEY IDENTITY,
        [Name] [VARCHAR](50)
        )
 
CREATE TABLE [dbo].[Author](
        [Id] [INT] PRIMARY KEY IDENTITY,
        [Name] [VARCHAR](25),
        [Surname] [VARCHAR](50)
        )
 
CREATE TABLE [dbo].[Book](
        [Id] [INT] PRIMARY KEY,
        [Title] [VARCHAR](50) NOT NULL,
        [AuthorId] [INT] NOT NULL FOREIGN KEY REFERENCES Author(Id),
        [Year] [INT] NOT NULL,
        [PublishingHouseId] [INT] NOT NULL FOREIGN KEY REFERENCES PublishingHouse(Id),
        [Type] [INT] NOT NULL FOREIGN KEY REFERENCES Category(Id),
        [Quantity] [INT] NOT NULL
        )
 
 
        INSERT INTO Category (Name)
        VALUES ('Powieść'),
        ('Dramat'),
        ('Fantastyka'),
        ('Basnie'),
        ('Komiksy'),
        ('Biografia'),
        ('Kryminal'),
        ('thriller'),
        ('bajka')
 
        INSERT INTO PublishingHouse (Name)
        VALUES ('GWO'),
        ('PWN'),
        ('Bialy Kruk'),
        ('SWPS'),
        ('Helion'),
        ('GREG'),
        ('Albatros'),
        ('Debit'),
        ('Nasza Księgarnia')
 
        INSERT INTO Author (Name, Surname)
        VALUES ( 'Adam', 'Mickiewicz'),
        ('Lindgren', 'Astrid'),
        ('Boleslaw','Prus'),
        ('Wladyslaw','Reymont'),
        ('Joanne,K','Rowling'),
        ('John,Ronald,Reue','Tolkien'),
        ('Stephen','King'),
        ('Juliusz','Slowacki'),
        ('Daniel','Dufoe'),
        ('Jan','Kochanowski'),
        ('Ignacy','Krasicki'),
        ('Carlo','Collodi')
       
 
INSERT INTO Book (Id, Title, AuthorId, Year, PublishingHouseId, Type, Quantity)
        VALUES ('1','Dziady III','1','2011','6','2','12'),
        ('2','Dziady IV','1','2006','1','2','24'),
        ('3','Pan Tadeusz','1','2011','6','1','12'),
        ('4','Dzieci z Bullerbyn','2','2003','6','9','14'),
        ('5','Harry Potter Kamień FIlozoficzny','5','2020','8','3','12'),
        ('6','Harry Potter Komnata Tajemnic','5','2020','8','3','10'),
        ('7','Harry Potter Więzień Askabanu','5','2020','8','3','12'),
        ('8','Harry Potter Czara Ognia','5','2020','8','3','24'),
        ('9','Harry Potter Zakon Feniksa','5','2020','8','3','14'),
        ('10','Harry Potter Książe Półkrwi','5','2020','8','3','12'),
        ('11','Harry Potter Insygnia Śmierci','5','2020','8','3','13'),
        ('12','Władca Pierścieni Bractwo Pierścienia','6','2002','4','3','25'),
        ('13','Władca Pierścieni Dwie Wieże','6','2013','2','3','12'),
        ('14','Władca Pierścieni Powrót Króla','6','2016','2','3','7'),
        ('15','Hobbit','6','2015','2','3','12'),
        ('16','To','7','2012','8','8','14'),
        ('17','Miasteczko Salem','7','2009','8','8','10'),
        ('18','Zielona Mila','7','2000','8','8','20'),
        ('19','Śpiące Królewny','7','2019','7','8','12'),
        ('20','Bezsenność','7','1999','6','8','14'),
        ('21','Treny','10','1996','3','2','7'),
        ('22','Fraszki','10','2000','1','2','9'),
        ('23','Pieśni','10','2015','6','1','18'),
        ('24','Balladyna','8','2010','6','2','13'),
        ('25','Kordian','8','2007','3','2','23'),
        ('26','Robinson Kruzoe','9','2009','1','1','12')