/* PROCEDURES DO BANCO EMPRESA */
Select * from Cliente
----------------------------------------------------
CREATE PROCEDURE pCliente_Insert
	@nome varchar(80),
	@endereco	varchar(80)
AS
Insert Cliente(Nome, Endereco)
Values(@nome, @endereco)
-------------------------------------------------
CREATE PROCEDURE pCliente_Update
	@codigo	int,
	@nome	varchar(80),
	@endereco	varchar(80)
AS
Update Cliente
Set Nome = @nome,
	Endereco = @endereco
Where Codigo = @codigo
----------------------------------------------------
CREATE PROCEDURE pCliente_Delete
	@codigo int
AS
Delete Cliente
Where Codigo = @codigo
----------------------------------------------------
CREATE PROCEDURE pCliente_SelectPorNome
	@nome	varchar(80)
AS
Select * From Cliente
Where Nome = @nome
-----------------------------------------------
ALTER PROCEDURE pCliente_Insert
	@nome varchar(80),
	@endereco	varchar(80),
	@codigo		int		output
AS
Insert Cliente(Nome, Endereco)
Values(@nome, @endereco)
Select @codigo = @@identity
-------------------------------------------------
CREATE PROCEDURE pCliente_Select
AS
Select * From Cliente Order By 1
-------------------------------------------------
