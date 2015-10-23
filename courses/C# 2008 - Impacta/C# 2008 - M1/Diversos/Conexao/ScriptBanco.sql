create database Loja
go
--------------------------------------------------
use Loja
go
--------------------------------------------------
create table Cliente
(
	Nome varchar(50),
	Idade int
)
go
--------------------------------------------------
insert Cliente values('Josualdo',47)
insert Cliente values('Marilivia',32)
insert Cliente values('Usnavy',23)
insert Cliente values('Maick',34)
insert Cliente values('Adegesto',19)
go
--------------------------------------------------
create table Fornecedor
(
	Nome varchar(50),
	Idade int
)
go
--------------------------------------------------
insert Fornecedor values('Mariana',63)
insert Fornecedor values('Luciana',45)
insert Fornecedor values('Adriana',18)
insert Fornecedor values('Ana',39)
go
-------------------------------------------------
Select * from Cliente order by 1
Select * from Fornecedor order by 1
-------------------------------------------------