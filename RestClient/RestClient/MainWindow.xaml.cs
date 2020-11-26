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

namespace RestClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private  readonly object txtResponse;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        #region UI Event Handlers
        private void buttonGo_Click(object sender, RoutedEventArgs e)
        {
            debugOutput("this is some output that I can use to test stuff");
        }
        #endregion
        private void debugOutput(string strDebugText)
        {

            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.SelectionLength;
                txtResponse.ScrollToHome();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
         }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
