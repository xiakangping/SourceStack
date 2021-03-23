create table[dbo].Problem(
[id] int not null primary key,
[Content] text null,
[NeedRemoteHelp] nvarchar(10)  null,
Reward tinyint  null,
[PublishDateTime] datetime  null,
)

drop table problem



