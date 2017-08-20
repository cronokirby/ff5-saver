using System;

namespace FF5Saver.Data
{
    public class ByteReader
    {

        private byte[] buffer;

        private int index;

        public ByteReader(byte[] array, int offset)
        {
            buffer = array;
            index = offset;
        }

        public byte Byte()
        {
            byte r = buffer[index];
            index++;
            return r;
        }

        public ushort Word()
        {
            // little endian handling
            var r = (ushort)((buffer[index + 1] << 8) + buffer[index]);
            index += 2;
            return r;
        }

        public uint Triple()
        {
            var r = (uint)((buffer[index + 2] << 16) + (buffer[index + 1] << 8) + buffer[index]);
            index += 3;
            return r;
        }

        public void Skip(int amount)
        {
            index += amount;
        }
    }
}

