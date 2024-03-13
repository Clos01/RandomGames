using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Security.AccessControl;



namespace  AgeNameSpace
{
    public interface IAgeVerifier
    {
        bool VerifyOfLegalAge(int isOfAge);
    }


    public class AgeVerifier : IAgeVerifier
    {
        private const int LegalAge = 21;
        public bool VerifyOfLegalAge(int isOfAge)
        {
            return isOfAge >= 21;


        }
    }

}
