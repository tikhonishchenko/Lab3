﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab3.Models
{
    internal class InvalidEmailException : Exception 
    {
        public InvalidEmailException(string message) : base(message)
        {
            MessageBox.Show("Неправильний формат електронної пошти");
        }
    }
}
