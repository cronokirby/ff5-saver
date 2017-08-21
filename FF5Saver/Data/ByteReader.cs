using System;

namespace FF5Saver.Data
{   
    /// <summary>
    /// Used to read off byte sequences from a buffer.
    /// This class handles index advancing for you.
    /// </summary>
    public class ByteReader
    {

        private byte[] buffer;

        private int index;

        public ByteReader(byte[] array, int offset)
        {
            buffer = array;
            index = offset;
        }
        /// <summary>
        /// Reads a byte from the buffer, and advances the index.
        /// </summary>
        /// <returns>the byte read from the buffer</returns>
        public byte Byte()
        {
            byte r = buffer[index];
            index++;
            return r;
        }
        /// <summary>
        /// Reads a ushort (2 bytes) from the buffer, advancing the index.
        /// </summary>
        /// <returns>the ushort read from the buffer</returns>
        public ushort Word()
        {
            // little endian handling
            var r = (ushort)((buffer[index + 1] << 8) + buffer[index]);
            index += 2;
            return r;
        }
        /// <summary>
        /// Reads a 24-bit number from the buffer, advancing the index.
        /// </summary>
        /// <returns>the number read from the buffer</returns>
        public uint Triple()
        {
            var r = (uint)((buffer[index + 2] << 16) + (buffer[index + 1] << 8) + buffer[index]);
            index += 3;
            return r;
        }
        /// <summary>
        /// Advances the index forward or backwards.
        /// </summary>
        /// <param name="amount">the amount to move the index</param>
        public void Skip(int amount)
        {
            index += amount;
        }
    }
}

