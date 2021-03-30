create database [TimesDb]

use TimesDb

create table [Times]
([id] int primary key IDENTITY(1,1),
[NomeJogador] varchar (100) NOT NULL,
[Posicao] varchar(50) NOT NULL,
[Time] varchar (100)NOT NULL)