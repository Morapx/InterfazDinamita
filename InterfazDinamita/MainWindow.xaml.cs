﻿using System;
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

namespace InterfazDinamita
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboLaLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GrindPersonas.Children.Clear();
            switch (ComboLaLista.SelectedIndex)
            {
                case 0:
                    GrindPersonas.Children.Add(new Maestro());
                    break;

                case 1:
                    GrindPersonas.Children.Add(new Alumno());
                    break;
                default:
                    break;
            }
        }

        private void BotonAgregar_Click(object sender, RoutedEventArgs e)
        {
            switch (ComboLaLista.SelectedIndex)
            {

            }
        }
    }
}
