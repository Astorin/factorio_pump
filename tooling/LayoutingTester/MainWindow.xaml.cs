﻿using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace LayoutingTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<TestLayoutInput> TestItems { get; } = new ObservableCollection<TestLayoutInput>();

        public MainWindow()
        {
            InitializeComponent();

            foreach (var testLayoutInput in TestInputProvider.All())
            {
                TestItems.Add(testLayoutInput);
            }

            TestLayouts.ItemsSource = TestItems;
        }

        private void TestLayouts_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshLayout();
        }

        private void ProMode_Checked(object sender, RoutedEventArgs e)
        {
            RefreshLayout();
        }

        private void RefreshLayout()
        {
            this.TestLayoutRunner.TestLayoutInput = TestLayouts.SelectedItem as TestLayoutInput;
            this.TestLayoutRunner.ProMode = ProMode.IsChecked ?? false;
        }
    }
}
