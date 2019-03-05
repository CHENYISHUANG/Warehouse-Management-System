if db_id('Warehouse')is not null
begin
	 use master
     drop database Warehouse
     end 
     create database Warehouse
     go
     use Warehouse
     go
/*==============================================================*/
create type id
   from char(10)
go

/*==============================================================*/
/* Table: Bill                                                  */
/*==============================================================*/
create table Bill (
   id                   int                  identity(1,1),
   goods_id             int                  null,
   goods_amount         int                  null,
   goods_price          money                null,
   manufacture_date     date                 null,
   expiration_date      date                 null,
   operation_type_id    int                  null,
   warehouse_id         int                  null,
   lot_number           varchar(20)          null,
   client_id            int                  null,
   operation_time       datetime             null,
   manager_id           int                  null,
   bill_note            varchar(30)          null,
   constraint PK_BILL primary key (id)
)
go

/*==============================================================*/
/* Table: Client                                                */
/*==============================================================*/
create table Client (
   id                   int                  identity(1,1),
   client_name          varchar(20)          null,
   client_address       varchar(20)          null,
   client_contacts      varchar(20)          null,
   client_phone         varchar(20)          null,
   client_note          varchar(30)          null,
   constraint PK_CLIENT primary key (id)
)
go

/*==============================================================*/
/* Table: Goods                                                 */
/*==============================================================*/
create table Goods (
   id                   int                  identity(1,1),
   goods_name           varchar(20)          null,
   goods_type_id        int                  null,
   goods_code           varchar(20)          null,
   specifications       varchar(20)          null,
   goods_wight          varchar(20)          null,
   goods_volume         varchar(20)          null,
   goods_note           varchar(30)          null,
   constraint PK_GOODS primary key (id)
)
go

/*==============================================================*/
/* Table: GoodsType                                             */
/*==============================================================*/
create table GoodsType (
   id                   int                  identity(1,1),
   goods_type           varchar(20)          null,
   node_parent          int                  null,
   node_depth           int                  null,
   constraint PK_GOODSTYPE primary key (id)
)
go

/*==============================================================*/
/* Table: Inventory                                             */
/*==============================================================*/
create table Inventory (
   id                   int                  identity(1,1),
   warehouse_id         int                  null,
   goods_id              int                  null,
   client_id               int                  null,
   goods_amount         int                  null,
   goods_total          money                null,
   constraint PK_INVENTORY primary key (id)
)
go

/*==============================================================*/
/* Table: Manager                                               */
/*==============================================================*/
create table Manager (
   id                   int                  identity(1,1),
   manager_username     varchar(20)          null,
   manager_password     varchar(20)          null,
   manager_name         varchar(20),
   constraint PK_MANAGER primary key (id)
)
go

/*==============================================================*/
/* Table: OperationType                                         */
/*==============================================================*/
create table OperationType (
   id                   int                  identity(1,1),
   operation_type       varchar(20)          null,
   constraint PK_OPERATIONTYPE primary key (id)
)
go

/*==============================================================*/
/* Table: WarehouseNumber                                       */
/*==============================================================*/
create table WarehouseNumber (
   id                   int                  identity(1,1),
   warehouse_name       varchar(20)                  null,
   warehouse_position   varchar(20)          null,
   warehouse_note       varchar(30)          null,
   constraint PK_WAREHOUSENUMBER primary key (id)
)
go

alter table Bill
   add constraint FK_BILL_REFERENCE_OPERATIO foreign key (operation_type_id)
      references OperationType (id)
go

alter table Goods
   add constraint FK_GOODS_REFERENCE_GOODSTYP foreign key (goods_type_id)
      references GoodsType (id)
go

alter table Inventory
   add constraint FK_INVENTOR_REFERENCE_WAREHOUS foreign key (warehouse_id)
      references WarehouseNumber (id)
go



insert into GoodsType values('ÎÄ¾ß',0,1)
insert into GoodsType values('±Ê',1,2)
insert into GoodsType values('¸Ö±Ê',2,3)
insert into GoodsType values('Ç¦±Ê',2,3)
insert into GoodsType values('Ô²Öé±Ê',2,3)
insert into GoodsType values('ÏðÆ¤éß',1,2)
insert into GoodsType values('Ê³Îï',0,1)
insert into GoodsType values('Ãæ°ü',7,2)
insert into GoodsType values('»ðÍÈ³¦Ãæ°ü',8,3)
insert into GoodsType values('ÄÌÓÍÃæ°ü',8,3)
insert into GoodsType values('³¤Ãæ°ü',8,3)
insert into GoodsType values('·½±ãÃæ',7,2)
insert into GoodsType values('¿µÊ¦¸µ·½±ãÃæ',12,3)
insert into GoodsType values('¿µÊ¦¸µÅÝ½·Î¶',13,4)
insert into GoodsType values('¿µÊ¦¸µºìÉÕÎ¶',13,4)
insert into GoodsType values('¿µÊ¦¸µÏã¹½Î¶',13,4)
insert into GoodsType values('ÇÉÃæ¹Ý',12,3)
insert into GoodsType values('ÇÉÃæ¹ÝËáÀ±Î¶',17,4)
insert into GoodsType values('ÇÉÃæ¹ÝÅÝ½·Î¶',17,4)
insert into GoodsType values('¹¤¾ß',0,1)

insert into Manager values('zhangjunbo','zhangjunbo','ÕÅ¿¢²©')



insert into Goods values('°âÊÖ',20,'gj-00001','°Ñ','1','10','²âÊÔ')
insert into Goods values('¼ô×Ó',20,'gj-00002','°Ñ','0.5','10','²âÊÔ')
insert into Goods values('Æð×Ó',20,'gj-00003','°Ñ','0.5','10','²âÊÔ')
insert into Goods values('ÂÝË¿',20,'gj-00004','°Ñ','0.1','10','²âÊÔ')
insert into Goods values('ÂÝÃ±',20,'gj-00005','°Ñ','0.1','10','²âÊÔ')
insert into Goods values('´¸×Ó',20,'gj-00006','°Ñ','2','10','²âÊÔ')
INSERT INTO OperationType VALUES('É¢»õÈë¿â')
INSERT INTO OperationType VALUES('É¢»õ³ö¿â')
INSERT INTO OperationType VALUES('ÍÐÅÌÈë¿â')
INSERT INTO OperationType VALUES('ÍÐÅÌ³ö¿â')


INSERT INTO WarehouseNumber VALUES('1ºÅ²Ö','×î×ó±ß','²âÊÔ²Ö¿â')
INSERT INTO WarehouseNumber VALUES('2ºÅ²Ö','ÖÐ±ß','²âÊÔ²Ö¿â')
INSERT INTO WarehouseNumber VALUES('3ºÅ²Ö','ÓÒ±ß','²âÊÔ²Ö¿â')
                                                                    
INSERT INTO Client VALUES('¸ßöÎ','Óª¿Ú','¸ßöÎ',1603050310,'²âÊÔ×¨ÓÃ')
INSERT INTO Client VALUES('½¯ÌðÌð','Ìì½ò','½¯ÌðÌð',1603050312,'²âÊÔ×¨ÓÃ')

INSERT INTO Inventory VALUES(1,4,1,300,600)
INSERT INTO Inventory VALUES(1,4,2,400,800)
INSERT INTO Inventory VALUES(1,4,3,500,1000)
INSERT INTO Inventory VALUES(2,4,1,600,1200)
INSERT INTO Inventory VALUES(2,4,2,700,1400)
INSERT INTO Inventory VALUES(2,4,3,800,1600)
INSERT INTO Inventory VALUES(2,7,1,900,1800)

--DELETE FROM WarehouseNumber
--DELETE FROM Inventory

SELECT * FROM Bill
SELECT * FROM GoodsType
SELECT * FROM Goods;

--with tab as
--(
-- select id,goods_type,node_parent,node_depth from GoodsType where node_parent=13
-- union all
-- select b.id,b.goods_type,b.node_parent,b.node_depth 
-- from tab a,GoodsType b
-- where b.node_parent=a.id
--)
--UPDATE GoodsType SET node_depth=node_depth-1 where id in (select id from tab)

