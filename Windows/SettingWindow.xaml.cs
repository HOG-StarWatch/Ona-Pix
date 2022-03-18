﻿using System.ComponentModel;
using System.Windows;

namespace Ona_Pix
{
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();
        }
        private void SettingWin_Loaded(object sender, RoutedEventArgs e)
        {
            PaneListBox.SelectedIndex = 0;
            PaneListBox.Focus();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            PageBorder.Child = PaneListBox.SelectedIndex switch
            {
                0 => (UIElement)Resources["appearancePage"],
                1 => (UIElement)Resources["behaviorPage"],
                _ => (UIElement)Resources["appearancePage"],
            };
        }
    }
}