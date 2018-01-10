using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.DB;

namespace WebApplication1.Models.BAL
{
    public class StudentBL
    {
        public int SaveStudent(textbox id)
        {
            int result = 0;
            int nxtresult = 0;
            using (StudentEntities ctx = new StudentEntities()) {

                tbl_student obj = new tbl_student();

                obj.id = 1;
                obj.name = id.name;
                obj.address = id.address;
                obj.startdate = id.startdate;

                ctx.tbl_student.Add(obj);
                result = ctx.SaveChanges();

            }
                return result;
        }

        public List<textbox> getlist()
        {
            List<textbox> listget = new List<textbox>();
            int result = 0;
            using (StudentEntities ctx = new StudentEntities())
            {

                listget = (from reslutlist in ctx.tbl_student
                           select new textbox
                           {
                               ID = reslutlist.id,
                               name = reslutlist.name

                           }).ToList();

            }
            return listget;
        }

    }
}