using Bussiness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class PttManager:ISupplierService
    {
        //ihtiyaç duyulan sınıf new lenmek yerine onun interface'i yazılıyor
        private IApplicantService _applicantService; //bu kısım sınıf bağımlılığını kaldırmak için 
        
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        
        public void GiveMask(Person person) //check person
        {
            //IApplicant 'a referans alan sınıfları verebiliriz
            //PersonManager personManager= new PersonManager();
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + person.LastName + "için maske verilebilir");
            }
            else
            {
                Console.WriteLine(person.FirstName + person.LastName + "için maske verilemez");
            }


        }
    }
}
