﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab3.Models
{
    internal class AgeTooHighException : Exception
    {
        public AgeTooHighException(string message) : base(message)
        {
            MessageBox.Show("Та ти точно не такий молодий, давай пиши справжній");
        }
    }
}
