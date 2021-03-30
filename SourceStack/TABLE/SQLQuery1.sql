--在User表中插入以下四行数据：
--UserName
--Password
--17bang
--1234
--Admin
--NULL
--Admin-1
--SuperAdmin
--123456
insert [user] (id,UserName,PassWord) 
values(1,N'17bang',N'1234')
insert [user] (id,UserName,PassWord)
values(2,N'Admin',N'null')
insert [user] (id,UserName,PassWord)
values(3,N'Admin-1',N'')
insert [user] (id,UserName,PassWord)
values(4,N'SuperAdmin',N'123456')
--将Problem表中的Reward全部更新为0
select * from [Problem];
UPDATE [Problem] set peward=0
--使用事务，
--删除User表中的全部数据，
--回滚事务，撤销之前的删除行为

begin tran
drop table [user]
rollback
commit