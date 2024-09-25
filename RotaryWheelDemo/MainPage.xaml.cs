using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using RotaryWheelUserControl;

namespace RotaryWheelDemo
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            rotaryWheelDemo.Slices = new[]
            {
                "Off",
                "High",
                "Medium",
                "Low",
            };

            rotaryWheelDemo.PropertyChanged += RotaryWheelDemo_PropertyChanged;
        }

        private void SpinWheelButton_Click(object sender, RoutedEventArgs e)
        {
            rotaryWheelDemo.Spin();
        }

        private void RotaryWheelDemo_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var rotaryWheel = (RotaryWheel)sender;
            switch (e.PropertyName)
            {
                case "SelectedItemValue":
                    {
                        Debug.WriteLine(rotaryWheel.SelectedItemValue);
                        break;
                    }
            }
        }
    }
}
