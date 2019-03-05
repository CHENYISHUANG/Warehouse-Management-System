/*==============================================================*/
/* Database name:  Warehouse                                    */
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     2017/7/21 9:03:49                            */
/*==============================================================*/


drop database Warehouse
go

/*==============================================================*/
/* Database: Warehouse                                          */
/*==============================================================*/
create database Warehouse
go

use Warehouse
go

/*==============================================================*/
/* Domain: id                                                   */
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
   lot_number           varchar(20)          null,
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
   constraint PK_GOODSTYPE primary key (id)
)
go

/*==============================================================*/
/* Table: Inventory                                             */
/*==============================================================*/
create table Inventory (
   id                   int                  identity(1,1),
   warehouse_id         int                  null,
   goods_id             int                  null,
   client               int                  null,
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
   warehouse_name       int                  null,
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
      references GoodsType (goods_type)
go

alter table Inventory
   add constraint FK_INVENTOR_REFERENCE_WAREHOUS foreign key (warehouse_id)
      references WarehouseNumber (id)
go

