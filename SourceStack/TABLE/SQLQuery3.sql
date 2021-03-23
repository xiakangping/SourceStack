CREATE TABLE[DBO].[User](
[id]int not null primary key,
[username]nvarchar(50) null,
[Password]nvarchar(50) null)
drop table [user]
insert [user](id,[username],[password])
values (1,N'[17bang]',N'1234');

ALTER TABLE [USER]
ALTER COLUMN [PASSWORD]NVARCHAR(50)

insert [user](id,[username],[password])
VALUEs (2,N'Admin',null);

insert [user](id,[username],[password])
values (3,N'Admin-1','');

insert [user](id,[username],[password])
values (4,N'SuperAdmin',N'123456')

