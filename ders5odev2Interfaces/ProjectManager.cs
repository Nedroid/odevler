using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev2Interfaces
{
    internal class ProjectManager
    {
        public void AddManager(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
