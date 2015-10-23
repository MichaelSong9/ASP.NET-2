/* Revisão SQL */
USE NORTHWIND
GO
------------------------------------------------
/* TODOS OS DADOS DOS CLIENTES */
SELECT * FROM CUSTOMERS
------------------------------------------------
/* TODOS OS CLIENTES DO BRASIL */
SELECT * FROM CUSTOMERS 
WHERE COUNTRY = 'BRAZIL'
---
SELECT * FROM CUSTOMERS 
WHERE COUNTRY LIKE 'BRA_IL'
------------------------------------------------
/* TODOS OS CLIENTES DO BRASIL E DA ALEMANHA */
SELECT * FROM CUSTOMERS 
WHERE COUNTRY = 'BRAZIL'
	OR COUNTRY = 'GERMANY'
----
SELECT * FROM CUSTOMERS 
WHERE COUNTRY IN('BRAZIL', 'GERMANY')
------------------------------------------------
/* CLIENTES QUE COMEÇAM COM G */
SELECT * FROM CUSTOMERS
WHERE COMPANYNAME LIKE 'G%'
------------------------------------------------
SELECT * FROM CUSTOMERS
WHERE COMPANYNAME LIKE '[A,C-G,W]%'
-------------------------------------------------
/* LISTA DOS PAÍSES */
SELECT DISTINCT COUNTRY 
FROM CUSTOMERS
------------------------------------------------
/* QUANTOS CLIENTES POR PAÍS */
SELECT 
	COUNTRY AS PAÍS,
	COUNT(COMPANYNAME) AS CONTAGEM
FROM 
	CUSTOMERS
GROUP BY 
	COUNTRY
ORDER BY 1
------------------------------------------------
/* FORNCEDOR, PRODUTO */
SELECT 
	SUPPLIERS.COMPANYNAME AS FORNECEDOR,
	PRODUCTS.PRODUCTNAME AS PRODUTO
FROM
	SUPPLIERS JOIN PRODUCTS ON
		SUPPLIERS.SUPPLIERid = PRODUCTS.SUPPLIERid
ORDER BY 1,2
--------------------------------------------------------------
/* CLIENTE, FUNCIONARIO, Nº PEDIDO, DATAPEDIDO */
SELECT 
	C.COMPANYNAME AS CLIENTE,
	E.FIRSTNAME AS FUNCIONÁRIO,
	O.ORDERid AS PEDIDO,
	O.ORDERDATE AS EMISSÃO
FROM 
	CUSTOMERS AS C JOIN ORDERS AS O ON
			C.CUSTOMERid = O.CUSTOMERid
	JOIN EMPLOYEES AS E ON
			E.EMPLOYEEid = O.EMPLOYEEid
ORDER BY 1, 2, 3
-----------------------------------------------------------
/* QUANTOS PEDIDOS CADA FUNCIONÁRIO EMITIU */
SELECT 
	E.FIRSTNAME AS FUNCIONÁRIO,
	COUNT(O.ORDERid) AS CONTAGEM
FROM 
	EMPLOYEES AS E JOIN ORDERS AS O ON
			E.EMPLOYEEid = O.EMPLOYEEid
GROUP BY 
	E.FIRSTNAME
ORDER BY 2 DESC
------------------------------------------------------------
/* FUNCIONARIOS COM MAIS DE 100 PEDIDOS */
SELECT 
	E.FIRSTNAME AS FUNCIONÁRIO,
	COUNT(O.ORDERid) AS CONTAGEM
FROM 
	EMPLOYEES AS E JOIN ORDERS AS O ON
			E.EMPLOYEEid = O.EMPLOYEEid
GROUP BY 
	E.FIRSTNAME
HAVING 
	COUNT(O.ORDERid)>=100
ORDER BY 2 DESC
---------------------------------------------------------------
/* OS PRIMEIROS 3 FUNCIONARIOS (CONTAGEM DE PEDIDOS)*/
SELECT TOP 3 WITH TIES
	E.FIRSTNAME AS FUNCIONÁRIO,
	COUNT(O.ORDERid) AS CONTAGEM
FROM 
	EMPLOYEES AS E JOIN ORDERS AS O ON
			E.EMPLOYEEid = O.EMPLOYEEid
GROUP BY 
	E.FIRSTNAME
ORDER BY 2 DESC
----------------------------------------------------------------
/* CRIAR UMA TABELA CLIENTE */
CREATE TABLE CLIENTE
(
	CODIGO INT IDENTITY PRIMARY KEY,
	NOME	VARCHAR(50),
	IDADE	TINYINT
)
GO
------------------------------------------------------------------
SELECT * FROM CLIENTE
-----------------------------------------------------------------
/* PROCEDURE DE SELECT */
CREATE PROCEDURE pCliente_Select
AS
	SELECT * 
	FROM CLIENTE 
	ORDER BY 1
-----------------------------------------------------------------
EXEC pCliente_Select
-----------------------------------------------------------------
alter PROCEDURE pCliente_Insert	
	@nome	varchar(50),
	@idade tinyint
AS
INSERT CLIENTE VALUES(@NOME, @IDADE)
-----------------------------------------------------------------
EXEC pCliente_Insert 'josualdo', 31
EXEC pCliente_Insert 'cesalpino',28
EXEC pCliente_Insert 'geralcina', 30
EXEC pCliente_Insert 'adalfranklin',40
-----------------------------------------------------------------
EXEC pCliente_Select
-----------------------------------------------------------------
CREATE PROCEDURE pCliente_Update
	@nome	varchar(50),	
	@idade tinyint,
	@codigo int
AS 
UPDATE CLIENTE
SET NOME = @NOME,
		IDADE = @IDADE
WHERE CODIGO = @CODIGO
------------------------------------------------------------------
EXEC pCliente_Update 'UELITON', 26, 1 
-----------------------------------------------------------------
EXEC  pCliente_Select
-----------------------------------------------------------
CREATE PROCEDURE pCliente_Delete
	@codigo int
AS
DELETE CLIENTE
WHERE CODIGO = @CODIGO
-------------------------------------------------------------
EXEC pCliente_Delete 1
------------------------------------------------------------
EXEC  pCliente_Select
--------------------------------------------------------------
CREATE PROCEDURE pCliente_SelecPorNome
	@nome VARCHAR(50)
AS
	SELECT * FROM CLIENTE
	WHERE NOME LIKE @NOME + '%'
-----------------------------------------------------------
EXEC pCliente_SelecPorNome 'G'
-----------------------------------------------------------
EXEC  pCliente_Select
-----------------------------------------------------------
	








