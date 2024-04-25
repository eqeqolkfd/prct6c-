﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace prct6.Model
{
    internal class Character //модель для сохранения в json
    {
        public string Name { get; set; }
        public BitmapImage ImageChoice { get; set; }
        public DateTime DateChoice { get; set; }

        public Character() { }
    }
}