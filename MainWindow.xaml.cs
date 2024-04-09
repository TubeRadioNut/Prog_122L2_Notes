//Charles Milender
//4-8-2024
//CSI 122
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_122L2_Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();//don't delete this
            
            string userFirstName = txtFirstName.Text;
            //Message Box
            //MessageBox.Show(userFirstName);
        }

        private void btnPopUpMessage_Click(object sender, RoutedEventArgs e)
        {
            string userFristName = txtFirstName.Text;
            string userLastName = txtLastName.Text;

            MessageBox.Show(userFristName + " " + userLastName);
        }

        private void btnAddNumber_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txtnum1.Text);
            int b = int.Parse(txtnum2.Text);
            int sum = a + b;

            MessageBox.Show(sum.ToString());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txtnum1.Text);
            int b = int.Parse(txtnum2.Text);

            int sum = a + b;

            MessageBox.Show(sum.ToString());
        }
    }
}