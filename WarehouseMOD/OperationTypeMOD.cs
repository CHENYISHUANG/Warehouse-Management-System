using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseMOD
{
   public class OperationTypeMOD
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string operation_type;

        public string Operation_type
        {
            get { return operation_type; }
            set { operation_type = value; }
        }
    }
}
