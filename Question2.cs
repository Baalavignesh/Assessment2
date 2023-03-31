using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licence_Plate
{
    internal class NewLicencePlate
    {
        private string _Name = string.Empty;
        private int _AgentsAvailable = 0;
        private List<string> _AllNames = new List<string>();

        public int WaitTime = 0; 
        public NewLicencePlate(string name, int agents, string others_names) { 
            this._Name = name;
            this._AgentsAvailable = agents;
            string[] OtherNames = others_names.Split(new char[] { ' ' });

            foreach (string OtherName in OtherNames)
            {
                _AllNames.Add(OtherName);
            }
            this._AllNames.Add(name);
        }



        public int CheckWaitTime()
        {
            _AllNames.Sort();

            int myPosition = _AllNames.IndexOf(this._Name);
            int groups = (myPosition + this._AgentsAvailable) / this._AgentsAvailable;

            Console.WriteLine($"\n{this._Name} your Wait Time is {groups * 20}");

            return groups * 20;

        }

    }
}
