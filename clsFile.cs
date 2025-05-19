using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor_L4DC_124_
{
    class clsFile
    {
        public string FileNumber, UserID, FileName, FileLocation;
        public string FileNo
        {
            get { return FileNumber; }
            set { FileNumber = value; }
        }
        public string User
        {
            get { return UserID; }
            set { UserID = value; }
        }
        public string FileNames
        {
            get { return FileName; }
            set { FileName = value; }
        }
        public string FileLocate
        {
            get { return FileLocation; }
            set { FileLocation = value; }
        }
    }
}
