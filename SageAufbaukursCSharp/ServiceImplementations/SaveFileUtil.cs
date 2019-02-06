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
            try
            {

                using (var swDatei = new StreamWriter(""))
                {
                    swDatei.WriteLine(beleg);
                }
                return true;
            }
            catch (PathTooLongException ptl)
            {
                string DateiName = Path.GetFileNameWithoutExtension(path);
                string DateiExtension = Path.GetExtension(path);
                string DateiPfad = Path.GetFullPath(path);
                string sNeuerPfad = string.Empty;
                int Frei = 260 - DateiPfad.Length - DateiExtension.Length - 1;
                if (Frei > 1)
                {
                    sNeuerPfad = String.Concat(DateiPfad, DateiName, ".", DateiExtension);
                    SaveFileUtil Ergebnis = new SaveFileUtil();
                    bool gings = Ergebnis.Save(beleg, sNeuerPfad);
                    if (string.IsNullOrEmpty(Ergebnis.Message))
                    {
                        Message = ptl;
                    }
                    return Ergebnis

                }
                else
                {
                    using (var swDatei1 = new StreamWriter(sDefaultPfad + "TEXT.TXT"))
                        Message = ae.Message;
                    Fault = ae;
                    return false;
                }
                  



            }
            catch (UnauthorizedAccessException uae)
            {
                throw;
            }
            catch (ArgumentException ae)
            {
                using (var swDatei1 = new StreamWriter(sDefaultPfad + "TEXT.TXT"))
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
            catch (PathTooLongException ptl)
            {
                string DateiName = Path.GetFileName(path);

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
