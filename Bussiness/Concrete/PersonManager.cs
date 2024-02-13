using Bussiness.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class PersonManager :IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            
        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person) 
        {
            //mernis controlü, connected service eklendi (https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx)
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            
            //return client.TCKimlikNoDogrulaAsync(15512317454, "Büşra", "Ünlü", 1997)
            //    .Result.Body.TCKimlikNoDogrulaResult;

            return client.TCKimlikNoDogrulaAsync(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear)
                .Result.Body.TCKimlikNoDogrulaResult;
        }

    }

}
