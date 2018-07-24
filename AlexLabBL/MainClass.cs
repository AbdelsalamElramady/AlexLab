using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLabBL
{
    public class MainClass
    {
        public static String ConectionString { get; set; }
        public static DataClassesAlexLabDataContext DbObj { get; set; }

        public static Object getRooms()
        {
            DbObj = new DataClassesAlexLabDataContext(ConectionString);

            var obj = from ob in DbObj.Rooms select ob;
            return obj;
        }
    }
}
