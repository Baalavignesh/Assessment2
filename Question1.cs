using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Licence_Plate
{
    internal class ReorderPlate
    {

        private string _LicenceNumber = string.Empty;
        private int _GroupNumber = 0;

        public string NewNumber = string.Empty;
        public ReorderPlate(string s, int g) {
            this._LicenceNumber =s;
            this._GroupNumber = g;
        }

        public string ReorderNumber() {

            this._LicenceNumber = this._LicenceNumber.Trim().ToUpper();
            this._LicenceNumber = this._LicenceNumber.Replace("-", "");

            int OrginalLength = _LicenceNumber.Length;

            int counter = 0;

            for (int i = OrginalLength; i > 0; i--)
            {
                counter++;
                if(counter == _GroupNumber) 
                {
                    NewNumber += _LicenceNumber[i - 1];

                    if(i!= 1) NewNumber += "-";
                    counter = 0;
                }   
                else
                {
                    NewNumber += _LicenceNumber[i-1];
                }

            }

            Console.WriteLine($"\nOrginal Plate Number : {this._LicenceNumber}");

            char[] stringArray = this.NewNumber.ToCharArray();
            Array.Reverse(stringArray);
            this.NewNumber = new string(stringArray);
            Console.WriteLine($"Changed Plate Number : {this.NewNumber}");
            return NewNumber;
        }

    }
}
