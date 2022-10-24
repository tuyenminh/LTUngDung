using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlidiemTHPT
{
    class LienKetGDKhoi
    {
        QliKhoi qli;
        public LienKetGDKhoi()
        {
            qli = new QliKhoi();
        }
        public DataTable getKhoi()
        {
            return qli.getKhoi();
        }
        public bool InsertKhoi(Khoi k)
        {
            return qli.InsertKhoi(k);
        }
        public bool UpdateKhoi(Khoi k)
        {
            return qli.UpdateKhoi(k);
        }
        public bool DeleteKhoi(Khoi k)
        {
            return qli.DeleteKhoi(k);
        }
    }
}
