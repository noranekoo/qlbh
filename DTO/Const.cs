using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Const
    {
        #region SQL string
        /* USER SQL string
         *
         */

        public const string SELECT = "SELECT s1 FROM tbl WHERE s2";
        public const string INSERT = "INSERT INTO tbl(s1) VALUES(s2)";
        public const string UPDATE = "UPDATE tbl SET s1 WHERE s2";
        public const string DELETE = "DELETE * FROM tbl WHERE s1";
        #endregion
    }
}
