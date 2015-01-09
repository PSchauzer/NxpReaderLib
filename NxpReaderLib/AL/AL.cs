using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NxpReaderLib.Common;

namespace NxpReaderLib.AL
{
    public interface Application
    {
      
    }

    public class Al
    {
        private List<Application> applications = new List<Application>();

        public Al(ALComponent[] apps, HALComponent hardware, BALComponent bus)
        {
            foreach(ALComponent comp in apps)
            {
                applications.Add(GetApplicationByComponentType(comp));
            }
        }

        private Application GetApplicationByComponentType(Common.ALComponent component)
        {
            switch(component){
                case Common.ALComponent.FeliCa:
                    return null;
                case Common.ALComponent.IcodeSli:
                    return null;
                case Common.ALComponent.Iso15693:
                    return null;
                case Common.ALComponent.Iso1800p3m3:
                    return null;
                case Common.ALComponent.MifareClassic:
                    return new Applications.MifareClassic();
                case Common.ALComponent.MifareDesfire:
                    return new Applications.MifareDesFire();
                case Common.ALComponent.MifareUltralight:
                    return new Applications.MifareUltralight();
                default:
                    return null;
            }
        }
    }
}
