using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolEntities;

namespace SchoolDAL
{
    public class CPersonDAL
    {
        public List<CPerson> Listar()
        {

            try
            {
                using (SchoolEntities context = new SchoolEntities())
                {
                    var query = context.Person.Select(p => new CPerson
                    {
                        PersonID = p.PersonID,
                        LastName = p.LastName,
                        FirstName = p.FirstName
                    });
                    return query.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}