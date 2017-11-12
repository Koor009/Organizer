using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    interface IManage
    { 
        void Add();
        void Delete();
        void Edit();
        void GetNote();
    }
}
