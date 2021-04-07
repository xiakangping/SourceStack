--查找没有录入密码的用户
select [password] from [User] where password=N''
--删除用户名（UserName）中包含“管理员”或者“17bang”字样的用户
delete [User] where [UserName]like (N'%17bang%')
--在Problem表中：
--给所有悬赏（Reward）大于10的求助标题加前缀：【推荐】
update [Reward] set Title=N'推荐'+Title
where [Reward]>10;
--给所有悬赏大于20且发布时间（Created）在2019年10月10日之后的求助标题加前缀：【加急】
update [Reward] set Title=N'加急'+Title
where [Reward]>20 and PublishDateTime >'2019/10/10';
--删除所有标题以中括号【】开头（无论其中有什么内容）的求助
delete [Problem] where Title like N'【%】';
--查找Title中第5个起，字符不为“数据库”且包含了百分号（%）的求助
select * from [Problem] where Title not like N'_____%数据库'
and Title like N'%#%%' ESCAPE '#'
--在Keyword表中：
--找出所有被使用次数（Used）大于10小于50的关键字名称（Name）
select [name] from keyword where used >10 and used <50; 
--如果被使用次数（Used）小于等于0，或者是NULL值，或者大于100的，将其更新为1
update keyword set used=1
where used<0 or used is null or used>100;
--删除所有使用次数为奇数的Keyword
delete keyword where used%2=1;
select * from [Problem]