using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using keanet.Models;

namespace keanet
{

    public class PhoneNotFoundException : Exception
    {
        public PhoneNotFoundException()
        {

        }

        public PhoneNotFoundException(string id)
            : base($"A phone with ID '{id}' could not be found.")
        {

        }
    }

    public class PhoneNotInCartException : Exception
    {
        public PhoneNotInCartException()
        {

        }

        public PhoneNotInCartException(string id)
            : base($"You didn't add a phone with ID '{id}' to your cart.")
        {

        }
    }

}