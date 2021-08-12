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

namespace Azeri_Chat_Task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Send_Btn_Click(object sender, RoutedEventArgs e)
        {
            string space = "\n";

            user.HorizontalAlignment = HorizontalAlignment.Left;
            user.Items.Add(Message_Text_Box.Text);
            user.Items.Add(space);

            Message_Text_Box.Text = Message_Text_Box.Text.ToLower();
            if (Message_Text_Box.Text == "salam" || Message_Text_Box.Text == "Salam")
            {
                ai.HorizontalAlignment = HorizontalAlignment.Right;
                ai.Items.Add(space);
                ai.Items.Add(AIServer.GetResponseSalam());
            }
            else if (Message_Text_Box.Text == "necesen?" || Message_Text_Box.Text == "Necesen?")
            {
                ai.HorizontalAlignment = HorizontalAlignment.Right;
                ai.Items.Add(space);
                ai.Items.Add(AIServer.GetResponseNecesen());
            }
            else if (Message_Text_Box.Text == "neyneyirsen?" || Message_Text_Box.Text == "Neyneyirsen?" || Message_Text_Box.Text == "Ne edirsen?" || Message_Text_Box.Text == "ne edirsen?")
            {
                ai.HorizontalAlignment = HorizontalAlignment.Right;
                ai.Items.Add(space);
                ai.Items.Add(AIServer.GetResponseNeVarNeYox());
            }
            else if (Message_Text_Box.Text == "hardasan?" || Message_Text_Box.Text == "Hardasan?")
            {
                ai.HorizontalAlignment = HorizontalAlignment.Right;
                ai.Items.Add(space);
                ai.Items.Add(AIServer.GetResponseHardasan());
            }
            else
            {
                ai.HorizontalAlignment = HorizontalAlignment.Right;
                ai.Items.Add(space);
                ai.Items.Add(AIServer.GetResponse());
            }
        }
    }
}
