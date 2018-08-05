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

namespace EvComponents
{
    /// <summary>
    /// Логика взаимодействия для SLButton.xaml
    /// </summary>
    public partial class LoadingButton : UserControl
    {
        public LoadingButton()
        {
            InitializeComponent();
        }

        public bool Torision
        {
            get { return (bool)GetValue(TorsionProperty); }
            set { SetValue(TorsionProperty, value); }
        }



        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TorsionProperty =
            DependencyProperty.Register("Torision", typeof(bool), typeof(LoadingButton), new PropertyMetadata(false));


        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Torision = !Torision;
        }

    }
}
