using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NxpReaderLib.PAL;

namespace NxpReaderLib.AL.Applications
{

    public enum KeyType
    {
        KEY_A,
        KEY_B
    }

    public enum UidType{
        UIDF0,
        UIDF1,
        UIDF2,
        UIDF3
    }

    public class MifareClassic : Application
    {
        public static int DATABLOCKLENGTH = 16;
        public static int VALUEBLOCKLENGTH = 4;

        private Protocol PalMifare;

        public MifareClassic()
        {
            PalMifare = Pal.GetProtocol(Common.PALComponent.Mifare);
        }

        public void Authenticate(byte block, KeyType key, ushort keyNumber, ushort keyVersion, byte[] uid)
        {

        }

        public void Read(byte blockNo, out byte[] data)
        {
            data = null;
        }

        public void ReadValue(byte blockNo,out byte[] value, out byte AddrdData)
        {
            AddrdData = 0;
            value = null;
        }

        public void Write(byte blockNo, byte[] data)
        {

        }

        public void WriteValue(byte blockNo, byte[] value, byte addrdata)
        {

        }

        public void Increment(byte blockNo, byte[] value)
        {

        }

        public void Decrement(byte blockNo, byte[] value)
        {
        }

        public void Transfer(byte blockNo)
        {

        }

        public void Restore(byte blockNo)
        {

        }

        public void IncrementTransfer(byte srcBlock,byte dstblock,byte[] value)
        {

        }

        public void DecrementTransfer(byte srcBlock,byte dstblock,byte[] value)
        {

        }

        public void RestoreTransfer(byte srcBlock, byte dstBlock)
        {

        }

        public void PersonalizeUid(UidType uidType)
        {

        }
    }
}
