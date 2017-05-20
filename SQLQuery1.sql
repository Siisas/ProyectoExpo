create table Usuario(
IdUsuario int identity primary key,
Usuario varchar (50),
Password varchar(100),
)
select * from Usuario

create proc SpNewUsers
@Usuario nvarchar(100), 
@Password nvarchar(100)
as 
begin  
declare @Countero int 
declare @ReturnValue int 
select @Countero = COUNT(@Usuario) 
from Usuario where Usuario = @Usuario
if @Countero >0 
begin  
set @ReturnValue = -1 
end 
else 
begin  
set @ReturnValue = 1 
Insert into Usuario(Usuario,Password) Values 
(@Usuario,@Password) 
end 
select @ReturnValue as Valor 
end 