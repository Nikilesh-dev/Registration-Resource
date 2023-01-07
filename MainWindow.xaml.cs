using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Resources;
using System.Windows.Media.Media3D;

namespace Registration2
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

        String UserName = "Nikilesh05";
        String Passwordinter = "123456";
        String Gender = "";
        String Check1 = "";

        String builder = "";

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radio = (RadioButton)sender;

            if (radio.Tag == "1")
            {
                Gender = "Male";
            }
            else if (radio.Tag == "2")
            {
                Gender = "Female";
            }
            else
            {
                Gender = "";
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            String Name = txtname.Text;
            String Email = txtmail.Text;
            String Password = txtPass.Text;
            String Password2 = txtPass2.Text;
            String User = txtUser.Text;

            login(Name, Email, Password, Password2, User);

            if (Name == "" && Email == "" && Password == "" && Password2 == "" && User == "" && Gender == "")
            {
                ResourceManager rm = new ResourceManager("Registration2.Property.Resource1", Assembly.GetExecutingAssembly());
                MessageBoxResult result = MessageBox.Show(rm.GetString("welcome"), "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    txtname.Clear();
                    txtPass.Clear();
                    txtmail.Clear();
                    txtPass2.Clear();
                    txtUser.Clear();

                }

            }

        }

        private void login(String Name, String Email, String Password, String Password2, String User)
        {
            char[] Mail = Email.ToCharArray();



           
            
                for (int i = 0; i < Mail.Length; i++)
                {
                    if (Mail[i] != '@' || Mail[i] != '.')
                    {
        
                    builder = "OK";


                }
                else
                {
                    lblmail.Visibility = Visibility;
                }
                }
                if (Name !=""&& Password == Password2 && User == UserName && builder =="OK")
            {
                ResourceManager rm = new ResourceManager("Registration2.Property.Resource1", Assembly.GetExecutingAssembly());

                MessageBox.Show(rm.GetString("Thanks"));
            }else
                {
                if(Name == "")
                {
                    lblname.Visibility = Visibility;
                }
                if(Password != Password2)
                {
                    lblPass2.Visibility = Visibility;
                }
               
                if (User != UserName)
                {
                    lblname1.Visibility = Visibility;
                }
                

                   }
                




        }
    }
}
             
    

