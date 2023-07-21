using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.Enumaration
{
    public class GeneralEnumarations
    {
        public enum Response
        {
            error = 0,
            success = 1,

        }

        public enum EnumNotificationType
        {
            Success = 0,
            Info,
            Warning,
            Error
        }
    }
}
