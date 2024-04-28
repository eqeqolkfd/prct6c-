﻿using prct6.Model;
using prct6.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prct6.View
{
    /// <summary>
    /// Логика взаимодействия для ImagesForDay.xaml
    /// </summary>
    public partial class ImagesForDay : Page
    {
        MainWindow mainWindow = new MainWindow();
        public ImagesForDay()
        {
            InitializeComponent();

            var jsonFile = JsonSaver.DeserializeObject<List<Character>>("path.json");
            foreach (var item in jsonFile)
            {
                DateTime dateSelected = (DateTime)mainWindow.calend.SelectedDate;
                List<Character> charsDisplayed = jsonFile.FindAll(chara => chara.DateChoice == dateSelected.Date);
                images.Items.Add(item.ImageChoice);
            }

        }
    }
}