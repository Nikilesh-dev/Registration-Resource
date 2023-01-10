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
using System.Globalization;
using System.Threading;
using Registration2.Property;

namespace Registration2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Property.Settings settings = new Property.Settings();
        
            CultureInfo ci = new CultureInfo(settings.Language);
              Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            InitializeComponent();
            this.Title = settings.AppName;
           
        }

        String UserName = "Nikilesh05";
     
      
        String Gender = "";
        String builder = "";

       
          private void Button_Click(object sender, RoutedEventArgs e)
        {

            String Name = txtname.Text;
            String Email = txtmail.Text;
            String Password = txtPass.Password.ToString();
            String Password2 = txtPass2.Password.ToString();
            String User = txtUser.Text;

           


            if (Male.IsChecked == true)
            {
                Gender = Male.Tag.ToString();
            }
            else if (Female.IsChecked == true)
            {
                Gender = Female.Tag.ToString();
            }
            else
            {
                lblGender.Visibility = Visibility;
            }


            String LanguageSelection = "en-Us";
            if (Tamil.IsChecked == true)
            {
                LanguageSelection = Tamil.Tag.ToString();
            }
            else if (Telungu.IsChecked == true)
            {
                LanguageSelection = Telungu.Tag.ToString();
            }
            String RememberPassword = "";
            //if (Rpassword.IsChecked == true)
            //{
            //    RememberPassword = Password2;
            //}

            Property.Settings settings = new Property.Settings();
            settings.Language = LanguageSelection;
          
            settings.Save();

       
           












            login(Name, Email, Password, Password2, User);

            if (Name == "" && Email == "" && Password == "" && Password2 == "" && User == "" && Gender =="")
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

            char[] chars = { '@', '.' };

                    for (int i = 0; i < Mail.Length; i++)
                {
                    for(int j=0;j< chars.Length; j++)
                {
                    if (Mail[i] == chars[j])
                    {

                        builder = "OK";

                    }
                    
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
                if (builder != "OK")
                {
                    lblmail.Visibility = Visibility;
                }

                if (User != UserName)
                {
                    lblname1.Visibility = Visibility;
                }
                if(Gender != "Male" && Gender != "Female")
                {
                    lblGender.Visibility = Visibility;
                }
                

                   }
                




        }

        
    }
}
             
    

