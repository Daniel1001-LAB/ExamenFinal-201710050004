﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ExamenTercerParcial.Converters
{
    class ColorToHexConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Xamarin.Forms.Color color)
            {
                var red = (int)(color.R * 255);
                var green = (int)(color.G * 255);
                var blue = (int)(color.B * 255);
                var alpha = (int)(color.A * 255);
                var hex = $"#{red:X2}{green:X2}{blue:X2}";

                return hex;
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

