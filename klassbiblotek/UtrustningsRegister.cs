using System;
using System.Collections.Generic;
using System.Text;

namespace klassbiblotek
{
    public class UtrustningsRegister
    {
        private List<Utrustning> utrustningar = new List<Utrustning>();

        public void LaggTill(Utrustning utrustning)
        {
            utrustningar.Add(utrustning);
        }

        public List<Utrustning> HamtaAlla()
        {
            return new List<Utrustning>(utrustningar);
        }

        public Utrustning? HamtaMedId(int id)
        {
            foreach (Utrustning utrustning in utrustningar)
            {
                if (utrustning.Id == id)
                {
                    return utrustning;
                }
            }

            return null;
        }
    }
}