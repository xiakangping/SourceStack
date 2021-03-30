--观察“一起帮”的发布求助功能，试着建立表Problem，包含：

--Id
--Title（标题）
--Content（正文）
--NeedRemoteHelp（需要远程求助）
--Reward（悬赏）
--PublishDateTime（发布时间）……
--请为这些列选择合适的数据类型。
create table Problem(
id int,
title nvarchar(20),
content text,
NeedRemoteTime bit,
Peward int,
PublishDateTime datetime
)