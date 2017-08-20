using System;

namespace FF5Saver.Data
{
    public class ByteHelper
    {
        public static byte[] Slice(byte[] array, int start = 0, int stop = 0, bool reverse = false)
        {
            if (stop <= 0)
            {
                stop = array.Length - stop;
            }
            byte[] buffer = new byte[stop - start];
            Buffer.BlockCopy(array, start, buffer, 0, stop - start);
            if (reverse)
            {
                Array.Reverse(buffer);
            }
            return buffer;
        }

        public static ushort GetWord(byte[] array, int start)
        {   
            // We reverse if our layout is not the same as the SNES
            byte[] buff = Slice(array, start, start + 2, !BitConverter.IsLittleEndian);
            return BitConverter.ToUInt16(buff, 0);
        }

        public static uint GetTriple(byte[] array, int start)
        {
            // this corrects for the extra 4th byte
            byte[] buff = Slice(array, start, start + 4, !BitConverter.IsLittleEndian);
            return (uint)((buff[0] << 16) + (buff[1] << 8) + buff[2]);
        }
    }
}

