--在User表上的基础上：
--添加Id列，让Id成为主键
ALTER TABLE [user] DROP COLUMN id;
ALTER TABLE [user]
ADD id int ;
ALTER TABLE [user] 
ADD CONSTRAINT PK_Id PRIMARY KEY(Id); 

--添加约束，让UserName不能重复
--在Problem表的基础上：
ALTER TABLE [user]
ADD CONSTRAINT UQ_UserName UNIQUE(UserName);

--为NeedRemoteHelp添加NOT NULL约束，再删除NeedRemoteHelp上NOT NULL的约束
--添加自定义约束，让Reward不能小于10
alter table[Problem]
alter column NeedRemoteHelp bit not null;
alter table[Problem]
alter column NeedRemoteHelp bit  null;



alter table[Problem]
drop NeedRemoteHelp;
alter table[Problem]
ADD CONSTRAINT CK_NeedRemoteHelp CHECK(NeedRemoteHelp>=10);

select * from [user]
select * from [Problem]