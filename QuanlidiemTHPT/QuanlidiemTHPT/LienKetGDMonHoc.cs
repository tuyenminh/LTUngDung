using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlidiemTHPT
{
    class LienKetGDMonHoc
    {
        QliMonHoc qli;
        public LienKetGDMonHoc() {
            qli = new QliMonHoc();
        }
        public DataTable getMonHoc() {
            return qli.getMonHoc();
        }
        public bool InsertMonHoc(MonHoc mh) {
            return qli.InsertMonHoc(mh);
        }
        public bool UpdateMonHoc(MonHoc mh) {
            return qli.UpdateMonHoc(mh);
        }
        public bool DeleteMonHoc(MonHoc mh) {
            return qli.DeleteMonHoc(mh);
        }
    }
}
