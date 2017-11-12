using System;

namespace Organizer
{
    internal class Operation
    {
        public enum EnumOperation
        {
            Add,
            Delete,
            Edit
        }
        public void SomeOperation(EnumOperation operation)
        {
            Manage manage = new Manage();
            switch (operation)
            {
                case EnumOperation.Add:
                    manage.Add();
                    break;
                case EnumOperation.Delete:
                    manage.Delete();
                    break;
                case EnumOperation.Edit:
                    manage.Edit();
                    break;
                     
            }
        }
    }
}
