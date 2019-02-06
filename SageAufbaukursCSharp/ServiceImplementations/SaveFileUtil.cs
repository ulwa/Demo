using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SageAufbaukursCSharp.Services;

namespace SageAufbaukursCSharp.ServiceImplementations
{
    public class SaveFileUtil : ISaveFilesUtils
    {

        string sDefaultPfad = Environment.GetEnvironmentVariable("TEMP");
        public Exception Fault
        {
            get ;
            private set;
        }

        public string Message
        {
            get;
            private set;
        }

        #region Services
        private readonly iProblemSolver _problemsolver;
        #endregion
        public bool Save(object beleg, string path)
        {
            throw new NotImplementedException();
        }

        public bool Save(object beleg)
        {

            try
            {

                using (var swDatei = new StreamWriter(""))
                {
                    swDatei.WriteLine(beleg);
                }
                return true;    
            }
            catch (UnauthorizedAccessException uae)
            {
                throw;
            }
            catch (ArgumentException ae)
            {
                using(var swDatei1 = new StreamWriter(sDefaultPfad+"TEXT.TXT"))
                Message = ae.Message;
                Fault = ae;
                return false;
            }
            catch (Exception ex)
            {
                Fault = ex;

                return false;
            }
            return true;
        }

        

    }
}
