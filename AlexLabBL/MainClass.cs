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

        public static object getRooms()
        {
            DbObj = new DataClassesAlexLabDataContext(ConectionString);

            var obj = from ob in DbObj.Rooms select ob;
            return obj;
        }

        public static object getClients()
        {
            DbObj = new DataClassesAlexLabDataContext(ConectionString);

            var obj = from ob in DbObj.Clients select ob;
            return obj;
        }

        public static object getCourseType()
        {
            DbObj = new DataClassesAlexLabDataContext(ConectionString);

            var obj = from ob in DbObj.CourseTypes select ob;
            return obj;
        }
    }
}
