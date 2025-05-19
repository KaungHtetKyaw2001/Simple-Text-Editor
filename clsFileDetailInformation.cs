using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor_L4DC_124_
{
    class clsFileDetailInformation
    {
        public string FileNo, FindNo, EditNo;
        public string FNo
        {
            get { return FileNo; }
            set { FileNo = value; }
        }
        public string FiNo
        {
            get { return FindNo; }
            set { FindNo = value; }
        }
        public string ENo
        {
            get { return EditNo; }
            set { EditNo = value; }
        }
    }
}
