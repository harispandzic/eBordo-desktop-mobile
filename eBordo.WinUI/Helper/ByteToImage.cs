using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBordo.WinUI.Helper
{
    public class ByteToImage
    {
        public Bitmap ConvertByteToImage(byte[] blob)
        {
            System.IO.MemoryStream mStream = new System.IO.MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
