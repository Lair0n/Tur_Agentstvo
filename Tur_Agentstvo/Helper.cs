using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Tur_Agentstvo
{
    public class Helper
    {
        public static Models.AgentstvoEntity a_agentstvo;

        public static Models.AgentstvoEntity getContext()
        {
            if(a_agentstvo == null)
            {
                a_agentstvo = new Models.AgentstvoEntity();
            }
            return a_agentstvo;
        }
        public void CreateUsers(Models.Avtorizacia avtorizacia)
        {

            a_agentstvo.Avtorizacia.Add(avtorizacia);
            a_agentstvo.SaveChanges();
        }
    }
}
