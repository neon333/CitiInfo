﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CitiInfo.API.Services
{
    public class LocalMailService
    {
        private string _mailTo = "admin@mycompany.com";
        private string _mailFrom = "noreply@mycompany.com";

        public void Send(string subject, string message)
        {
            //send mail - output debug window
            Debug.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with LocalMailService.");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");
        }
    }
}