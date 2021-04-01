--1.观察一起帮的“关键字”功能，新建Keyword表，要求带一个自增的主键Id，起始值为10，步长为5；并存入若干条数据
alter table [keyword]
add id int identity(10,5);
INSERT INTO [keyword]([Name]) VALUES (N'陈国栋'); 
--2.将User表中Id列修改为可存储GUID的类型，并存入若干条包含GUID值的数据
alter table [user]
drop CONSTRAINT pk_id;
alter table [user]
drop column id;
alter table [user]
add id varchar(40);
update [user]set id= (newid())


select newid()



--3.Problem表已有Id列，如何给该列加上IDENTITY属性？
alter table [Problem]
drop column id;
alter table [Problem]
add id int identity(1,1);

select * from [Problem];
select * from [keyword];
select * from [user];