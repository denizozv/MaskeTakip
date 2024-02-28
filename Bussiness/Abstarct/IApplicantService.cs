using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstarct
{
    public interface IApplicantService
    {
        void ApplyForMask();

        List<Person> GetAll();


        bool CheckPerson(Person person);

    }
}
