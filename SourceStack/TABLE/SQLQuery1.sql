
--在User表中：

--查找没有录入密码的用户
--删除用户名（UserName）中包含“管理员”或者“17bang”字样的用户
select * from [user] 
where PassWord is null

delete from [user]
where [UserName] =N'管理员';

--在Problem表中：

--给所有悬赏（Reward）大于10的求助标题加前缀：【推荐】
--给所有悬赏大于20且发布时间（Created）在2019年10月10日之后的求助标题加前缀：【加急】
--删除所有标题以中括号【】开头（无论其中有什么内容）的求助
--查找Title中第5个起，字符不为“数据库”且包含了百分号（%）的求助
UPDATE [Problem]
SET Reward 
WHERE > 10