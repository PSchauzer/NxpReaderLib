using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxpReaderLib.Common
{
    public enum ALComponent
    {
        FeliCa,
        Iso15693,
        Iso1800p3m3,
        MifareClassic,
        MifareDesfire,
        MifareUltralight,
        IcodeSli,
        Stub
    }   

    public enum PALComponent
    {
        EpcUid,
        Felica,
        Iso14443p3a,
        Iso14443p3b,
        Iso14443p4,
        Iso14443p4a,
        Iso18000p3m3,
        Iso18092p3mPi,
        Mifare,
        Sli15693,
        Stub

    }

    public enum HALComponent
    {
        Rc523,
        Rc632,
        Rc663,
        Rd70x,
        Rd710,
        Stub
    }

    public enum BALComponent
    {
        PcSc,
        Rd70xUsb,
        Serial,
        Stub
    }
}
