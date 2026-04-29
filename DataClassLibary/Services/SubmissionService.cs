using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
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






        public bool SerialNumberExist(string serialNumber) //serial nummer tjek om det er i databasen
        {
            if (serialNumber == null)
            {
                return false;
            }

           foreach (var item in _appDbContext.SerialNumbers)
           {

                if (item.SerialNumber == serialNumber)
                {
                    return true;
                }
           }

           return false;
        }



        public bool SerialCount(string serialNumber) // < 2 serial nummer tjek
        {
            int count = 0;

            foreach (var item in _appDbContext.SubmissionModels)
            {
                if (item.SerialNumber == serialNumber)
                {
                    count++;
                }
            }

            if (count < 2)
            {

                return true;
            }

            return false;
            

        }




        public string Submit(SubmissionModel submissionModel)
        {
            

            if (SerialNumberExist(submissionModel.SerialNumber) == false)
                return "Serial number does not exist";

            if (SerialCount(submissionModel.SerialNumber) == false)
                return "Serial number has already been used too many times";

            _appDbContext.SubmissionModels.Add(submissionModel);
            _appDbContext.SaveChanges();

            return "ok";
        }



    }

}

            

