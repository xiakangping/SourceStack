--在User表上的基础上：

--添加Id列，让Id成为主键
alter table [user]
ADD id int ;
update [user] set id=1
where username=N'18bang';
alter table [user]
alter column id int not null;
ALTER TABLE [user] 
ADD CONSTRAINT PK_Id PRIMARY KEY(Id);
--添加约束，让UserName不能重复
ALTER TABLE [user]
ALTER COLUMN [UserName] nvarchar(20) not null;
alter table [user]
ADD CONSTRAINT UQ_ENROLL UNIQUE(UserName); 
--在Problem表的基础上：

--为NeedRemoteHelp添加NOT NULL约束，再删除NeedRemoteHelp上NOT NULL的约束
ALTER TABLE [Problem]
DROP CONSTRAINT CK_NeedRemoteHelp;
update [Problem] set NeedRemoteHelp=1;
alter table [Problem]
drop  column [NeedRemoteHelp];
alter table [Problem]
ADD  [NeedRemoteHelp] BIT  NULL;
ALTER TABLE [Problem] 
ALTER COLUMN NeedRemoteHelp bit not null;
ALTER TABLE [Problem] 
ALTER COLUMN NeedRemoteHelp bit not;

--添加自定义约束，让Reward不能小于10
update [Problem] set Peward=20;
ALTER TABLE [Problem]
ADD CONSTRAINT CK_Peward CHECK(Peward>=10);


select * from [USER];
select * from [Problem];


