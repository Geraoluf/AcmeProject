using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClassLibary.Services
{
    public class SubmissionService
    {
        private readonly AppDbContext _appDbContext;

        public SubmissionService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }



        public bool AgeOver18(DateOnly dateOfBirth) //alders tjek
        {

           
               
        }


        public bool SerialNumberExist(string serialNumber) //serial nummer tjek
        {
           
        }



        public bool CanUseSerial(string serialNumber) // < 2 serial nummer tjek
        {
            
        }









        //----------------------


        public string Submit(SubmissionModel submissionModel)  //samlet flow
        {

            
        }



    }

            
}
