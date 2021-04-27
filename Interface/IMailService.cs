using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Core_MVC_2.Entities;

namespace WebApplication_Core_MVC_2
{
    public interface IMailService
    {
        bool SendMail(MailContent content);

    }
}
