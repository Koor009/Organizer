using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    class Operation
    {
        public void SomeOperation()
        {
            Manage manage = new Manage();
            int someOperation = int.Parse(Console.ReadLine());
            switch (someOperation)
            {
                case 1:
                    manage.Edited();
                    break;
                case 2:
                    manage.ModifiedName();
                    break;
                case 3:
                    manage.ModifiedText();
                    break;
                case 4:
                    manage.ModifiedDate();
                    break;
                case 5:
                    manage.Added();
                    break;
            }
        }
    }
}
