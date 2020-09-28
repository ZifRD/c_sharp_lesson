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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsFormsApplication6form
{
    /// <summary>
    /// Логика взаимодействия для Map.xaml
    /// </summary>
    public partial class Map : UserControl
    {
        private int picIndex = 0;

        public Map()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ImageSourceConverter converter = new ImageSourceConverter();
            string path = "Resources/";

            switch(picIndex++)
            {
                case 0:
                {
                    path = "pack://application:,,,/WindowsFormsApplication6form;component/Resources/city12.png";
                    break;
                }
                case 1:
                {
                    path = "pack://application:,,,/WindowsFormsApplication6form;component/Resources/city2.png";
                    break;
                }
                case 2:
                {
                    path = "pack://application:,,,/WindowsFormsApplication6form;component/Resources/city21.png";
                    break;
                }   
                case 3:
                {
                    path = "pack://application:,,,/WindowsFormsApplication6form;component/Resources/city3.png";
                    break;
                }                
            }

            if (picIndex > 4)
            {
                picIndex = 0;
                path = "pack://application:,,,/WindowsFormsApplication6form;component/Resources/city1.png";
            }
            ImageSource imageSource = (ImageSource)converter.ConvertFromString(path);
            brush.ImageSource = imageSource;
            
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           // y is up
            double xVal = 5.0 - 5.0 * slider.Value / 20.0;

            camera.Position = new Point3D(xVal, 2.2, 0);
            camera.LookDirection = new Vector3D(-xVal-1E-10, -2.2,0);

        }
    }
}
