select*from usuario

drop table mensajes

create table usuario (id int primary key identity(1,1), nombre varchar(50), telefono varchar(15),
matricula varchar(50), email varchar(50), password varchar(50),fotoUrl varchar(max) );

create table mensajes (id int primary key identity(1,1),MessageText nvarchar(max) , MessageTextSend nvarchar(100), idu int not null, foreign key(idu) references usuario(id));
select*from mensajes
select * from usuario where nombre = @nombre and password = @password

delete from mensajes

insert into mensajes (MessageText,MessageTextSend,id) values('as','ddd',2);

CREATE PROCEDURE verificar_usuario
    @nombre VARCHAR(50),
    @password VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id INT;

    SELECT @id = id FROM usuario WHERE nombre = @nombre AND password = @password;

    IF @id IS NOT NULL
        SELECT @id AS id_usuario
    ELSE
        SELECT 0 AS id_usuario
END

drop procedure verificar_usuario

select * from mensajes

EXEC verificar_usuario 'goku', '1234'

SELECT MessageText , MessageTextSend from mensajes where idu =1;

delete from usuario