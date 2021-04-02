--1.在Problem中插入不同作者（Author）不同悬赏（Reward）的若干条数据，以便能完成以下操作：
alter table [Problem]
add [Author] nvarchar(20); 
update [Problem] set Author=N'飞哥'; 
insert [Problem] (Peward,Author)
values  (15,N'夏康平');

--   1.查找出Author为“飞哥”的、Reward最多的3条求助
select top 3 Peward from [Problem] where Author=N'飞哥'
ORDER BY Peward DESC 

--   2.所有求助，先按作者“分组”，然后在“分组”中按悬赏从大到小排序
select author,peward from [Problem] order by
author,peward desc
--   3.查找并统计出每个作者的：求助数量、悬赏总金额和平均值
select author,count(*),sum(peward),avg(peward) from [problem]
group by author

--   4.找出平均悬赏值少于10的作者并按平均值从小到大排序
select author,avg(peward) from [problem] group by author
having avg(peward)<10
order by avg(peward)asc;
--2.以Problem中的数据为基础，使用SELECT INTO，
--新建一个Author和Reward都没有NULL值的新表：NewProblem 
--（把原Problem里Author或Reward为NULL值的数据删掉）
select author,peward into [NewProblem] from [Problem];

--3.使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到NewProblem中
update [NewProblem] set peward= null where author=N'大飞哥';
insert [NewProblem](author,peward)
select author,peward from [Problem] where peward is null；




select * from [Problem];
select * from [NewProblem];