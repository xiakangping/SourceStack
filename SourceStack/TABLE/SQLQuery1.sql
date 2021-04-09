--在Problem中插入不同作者（Author）不同悬赏（Reward）的若干条数据，以便能完成以下操作：
--查找出Author为“飞哥”的、Reward最多的3条求助
select top 3 * from problem
where author=N'飞哥'
order by reward desc;
--所有求助，先按作者“分组”，然后在“分组”中按悬赏从大到小排序
select author,reward from problem
order by author,Reward desc;
--查找并统计出每个作者的：求助数量、悬赏总金额和平均值
select author,count(title),sum(reward),avg(reward)
from problem group by author;
--找出平均悬赏值少于10的作者并按平均值从小到大排序
alter table problem
drop constraint  ck_reward;
select author,avg(reward) from problem
group by author
having avg(reward)<10
order by avg(reward)asc;
--以Problem中的数据为基础，使用SELECT INTO，新建一个Author和Reward都没有NULL值的新表：NewProblem
--（把原Problem里Author或Reward为NULL值的数据删掉）
select* into newproblem from Problem
where author is not null and reward is not null;
--drop table newproblem
--使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到NewProblem中
insert newproblem(title,Content,NeedRemoteHelp,Reward,PublishDateTime,author)
select title,Content,NeedRemoteHelp,Reward,PublishDateTime,author 
from problem where reward is null;
select * from problem;
select * from newproblem;
drop table newproblem