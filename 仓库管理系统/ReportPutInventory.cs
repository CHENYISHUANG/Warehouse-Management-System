using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Attributes;
using System.Drawing;
using System.Runtime.Serialization;

namespace 仓库管理系统
{
    [Serializable, DataContract, Name("基础数据")]
   public class ReportPutInventory
    {
        [DataMember,Name("物品名称")]
       /// <summary>
       /// 物品名
       /// </summary>
       public string GoodsName { get; set; }

        [DataMember, Name("物品数量")]
       /// <summary>
       /// 物品数量
       /// </summary>
       public string Amount { get; set; }

        [DataMember, Name("物品价格")]
       /// <summary>
       /// 物品价格
       /// </summary>
       public string Price { get; set; }

        [DataMember, Name("生产日期")]
       /// <summary>
       /// 生产日期
       /// </summary>
        public string Scdate { get; set; }

        [DataMember, Name("过期日期")]
       /// <summary>
       /// 过期日期
       /// </summary>
        public string Gqdate { get; set; }

        [DataMember, Name("操作方式")]
       /// <summary>
       /// 入库方式
       /// </summary>
       public string Operation { get; set; }

        [DataMember, Name("仓库")]
       /// <summary>
       /// 仓库
       /// </summary>
       public string Warehouse { get; set; }

        [DataMember, Name("批号")]
       /// <summary>
       /// 批号
       /// </summary>
       public string LotNumber { get; set; }

        [DataMember, Name("客户名称")]
       /// <summary>
       /// 客户
       /// </summary>
       public string Client { get; set; }

        [DataMember, Name("操作时间")]
       /// <summary>
       /// 操作时间
       /// </summary>
       public string OperationDate { get; set; }

        [DataMember, Name("管理员")]
       /// <summary>
       /// 管理员
       /// </summary>
       public string Manager { get; set; }

        [DataMember, Name("备注")]
       /// <summary>
       /// 备注
       /// </summary>
       public string Note { get; set; }

    }
}
