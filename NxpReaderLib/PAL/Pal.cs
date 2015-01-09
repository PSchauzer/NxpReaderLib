using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NxpReaderLib.Common;

namespace NxpReaderLib.PAL
{
    public interface Protocol
    {

    }

    public class Pal : Protocol
    {
        public static Protocol GetProtocol(PALComponent protocol)
        {
            switch (protocol)
            {
                case PALComponent.EpcUid:
                    return new Protocols.EpcUid();
                case PALComponent.Felica:
                    return new Protocols.FeliCa();
                case PALComponent.Iso14443p3a:
                    return new Protocols.I14443P3A();
                case PALComponent.Iso14443p3b:
                    return new Protocols.I14443P3B();
                case PALComponent.Iso14443p4:
                    return new Protocols.I14443P4();
                case PALComponent.Iso14443p4a:
                    return new Protocols.I14443P4A();
                case PALComponent.Iso18000p3m3:
                    return new Protocols.I18000P3M3();
                case PALComponent.Iso18092p3mPi:
                    return new Protocols.I18092P3MPI();
                case PALComponent.Mifare:
                    return new Protocols.Mifare();
                case PALComponent.Sli15693:
                    return new Protocols.Sli15693();
                default:
                    return null;
            }
        }
    }
}
