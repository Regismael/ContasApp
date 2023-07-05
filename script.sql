﻿--Criando tabela de usuários
CREATE TABLE USUARIO(
  
   ID                    UNIQUEIDENTIFIER      NOT NULL,
   NOME                  NVARCHAR(150)         NOT NULL,
   EMAIL                 NVARCHAR(100)         NOT NULL UNIQUE,
   SENHA                 NVARCHAR(40)          NOT NULL,
   DATAHORACRIACAO       DATETIME              NOT NULL,
   PRIMARY KEY(ID))
 GO