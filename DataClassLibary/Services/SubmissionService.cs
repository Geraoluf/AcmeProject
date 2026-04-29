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
            if (string.IsNullOrWhiteSpace(serialNumber))
            {
                return false;
            }

            return _appDbContext.SerialNumbers
                .Any(s => s.SerialNumber == serialNumber);
        }



        public bool SerialCount(string serialNumber) // < 2 serial nummer tjek
        {
            var count = _appDbContext.SubmissionModels
                .Count(s => s.SerialNumber == serialNumber);

            return count < 2;
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

            

