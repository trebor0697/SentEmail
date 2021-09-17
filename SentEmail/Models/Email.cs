using System;
using System.Collections.Generic;
using System.Text;

namespace SentEmail.Models
{
    public class Email
    {
        public Email(string to, string subject)
        {
            To = to;
            Subject = subject;
        }

        public string To { get; }
        public string Subject { get; }

    }
}