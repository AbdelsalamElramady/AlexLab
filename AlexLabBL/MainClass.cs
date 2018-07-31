﻿using System;
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

        public static object getCourseTypes()
        {
            DbObj = new DataClassesAlexLabDataContext(ConectionString);

            var obj = from ob in DbObj.CourseTypes select ob;
            return obj;
        }

        public static object getCourses()
        {
            DbObj = new DataClassesAlexLabDataContext(ConectionString);

            var obj = from ob in DbObj.Courses
                      join cli in DbObj.Clients
                      on ob.ClientId equals cli.ClientId
                      join courseType in DbObj.CourseTypes
                      on ob.CourseTypeId equals courseType.CourseTypeId
                      select new { ob.CourseId, cli.ClientName, courseType.CourseTypeDesc, ob.CourseName, ob.StudentBookMoney, ob.Notes };
            return obj;
        }
    }
}
