using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager:ISupplierService 
    {

        private IAppilicantService _appilicantService;

        public PttManager( IAppilicantService appilicantService)  // new yapıldığı zaman önce çalışır .
        {
            _appilicantService = appilicantService; 
        } 


        public void GiveMask(Person person)
        {
          
            if (_appilicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "İçin maske verildi .");
            }
            else 
            {
                Console.WriteLine(person.FirstName + "İçin maske VERİLEMEDİ .");
            }    
        }

    }
}
