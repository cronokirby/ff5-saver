using System;

namespace FF5Saver.Data
{
    public class ByteHelper
    {
        public static byte[] SliceBytes(byte[] array, int start = 0, int stop = 0, bool littleEndian = false)
        {
            if (stop <= 0)
            {
                stop = array.Length - stop;
            }
            byte[] buffer = new byte[stop - start];
            Buffer.BlockCopy(array, start, buffer, 0, stop - start);
            if (littleEndian)
            {
                Array.Reverse(buffer);
            }
            return buffer;
        }
    }
}

