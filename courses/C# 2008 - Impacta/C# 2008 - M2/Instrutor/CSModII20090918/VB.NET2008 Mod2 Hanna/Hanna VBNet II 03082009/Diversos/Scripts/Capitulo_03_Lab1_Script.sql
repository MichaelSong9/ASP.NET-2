/* Criar o DataBase Oficina */
Create DataBase Oficina
go
------------------------------------
/* Alterar o DataBase */
Use Oficina
go
------------------------------------
/* Criar a tabela Veiculo */
Create table Veiculo
(
	Placa	char(7)	primary key not null,
	Modelo	varchar(30)	not null,
	Cor		varchar(30)	not null,
	Ano		smallint	not null
)	
go
-----------------------------------
/* Criar a tabela TipoServico */
Create table TipoServico
(
	CodigoTipo	int	identity	primary key not null,
	NomeTipo	varchar(80)	not null
)
go
-----------------------------------
/* Criar a tabela Servico */
Create table Servico
(
	OS	int identity primary key not null,
	Placa	char(7)	not null,
	CodigoTipo	int	not null,
	DataInicio	datetime	not null,
	DataFim		datetime	null,

	constraint FK_Servico_Veiculo 
			foreign key(Placa) 
			references veiculo(Placa),
	constraint FK_Servico_TipoServico 
			foreign key(CodigoTipo) 
			references tiposervico(CodigoTipo)
)
go
----------------------------------------------------
/* Inserindo dados */
Insert Veiculo Values('PPP0808','Veraneio','Bege',1972)
Insert Veiculo Values('KKK5656','Karmanghia','Vermelho',1967)
Insert Veiculo Values('HHH8484','Gurgel','Azul',1988)
Insert Veiculo Values('LLL1515','Variant TL','Branco',1977)
------------
Insert TipoServico Values('Regulagem de Freio')
Insert TipoServico Values('Regulagem de Motor')
Insert TipoServico Values('Troca de óleo')
Insert TipoServico Values('Troca de Pastilhas')
Insert TipoServico Values('Troca de Amortecedores')
------------
Insert Servico(Placa, CodigoTipo,DataInicio) 
		Values('PPP0808',1,'1/16/2009')
Insert Servico(Placa, CodigoTipo,DataInicio) 
		Values('PPP0808',2,'1/16/2009')
Insert Servico(Placa, CodigoTipo,DataInicio) 
		Values('PPP0808',3,'1/16/2009')
Insert Servico(Placa, CodigoTipo,DataInicio) 
		Values('KKK5656',1,'1/19/2009')
Insert Servico(Placa, CodigoTipo,DataInicio) 
		Values('KKK5656',4,'1/19/2009')
Insert Servico(Placa, CodigoTipo,DataInicio) 
		Values('LLL1515',5,'1/19/2009')
--------------------------------------------------------------
