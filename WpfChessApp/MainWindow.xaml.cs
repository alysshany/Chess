﻿using ChessCore;
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

namespace WpfChessApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        object lastSender;
        ChessCore.Figure lastFigure;
        private void MouseRightButton(object sender, MouseButtonEventArgs e)
        {
            if (mainListBox.SelectedItem != null)
            {
                string[] s = mainListBox.SelectedItem.ToString().Split();
                string n = s[1].Trim();
                lastFigure = Fab.FiguresMaking(n + " " + Grid.GetColumn((UIElement)sender).ToString() + " " +
                                            Grid.GetRow((UIElement)sender).ToString());
                (sender as Button).Content = n;
                lastSender = sender;
                mainListBox.SelectedItem = null;
            }
            if ((sender as Button).Content.ToString() != "")
            {
                lastSender = sender;
                lastFigure = Fab.FiguresMaking((sender as Button).Content + " " + Grid.GetColumn((UIElement)sender).ToString() + " " +
                            Grid.GetRow((UIElement)sender).ToString());
                return;
            }
            if ((sender as Button) == (lastSender as Button))
            {
                (sender as Button).Content = " ";
                lastSender = null;
                lastFigure = null;
            }
        }

        private void MouseLeftButton(object sender, MouseButtonEventArgs e)
        {
            if (lastFigure.Move(Grid.GetColumn((UIElement)sender) + "" +
                              Grid.GetRow((UIElement)sender)))
            {
                (sender as Button).Content = (lastSender as Button).Content;
                (lastSender as Button).Content = "";
                lastSender = sender;
                return;
            }
        }
    }
}
