using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsWithSql
{
    class FileUtils
    {
        /// <summary>
        /// 根据文件路径返回byte数组
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Byte[] GetByteFromPath(string path)
        {
            var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            var ret = new Byte[fs.Length];
            fs.Read(ret, 0, ret.Length);
            fs.Close();
            return ret;
        }
    }
}
