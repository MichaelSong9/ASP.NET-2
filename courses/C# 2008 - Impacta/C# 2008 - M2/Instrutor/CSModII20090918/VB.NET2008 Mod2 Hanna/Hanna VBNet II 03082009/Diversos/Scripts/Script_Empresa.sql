/* Criar o DataBase Empresa */
Create DataBase Empresa
go
----------------------------------
/* Usar o DataBase Empresa */
Use Empresa
go
----------------------------------
Create table Cliente
(
	Codigo	int	identity not null primary key,
	Nome	varchar(80)	not null,
	Endereco	varchar(80) not null
)
go
----------------------------------