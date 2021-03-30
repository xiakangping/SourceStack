--观察“一起帮”的注册和发布求助功能，试着建立表User：包含UserName（用户名），Password（密码）……
create table [user](
id int,
UserName nvarchar(20),
PassWord nvarchar(20)
)
--为User表添加一列：邀请人（InvitedBy），类型为INT
alter table [user]
ADD InvitedBy int

--将InvitedBy类型修改为NVARCHAR(10)
alter table [user]
alter column InvitedBy nvarchar(10)

--删除列InvitedBy
alter table [user]
drop  column InvitedBy 