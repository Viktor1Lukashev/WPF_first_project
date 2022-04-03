using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string Choise_Animal;
        private string _NameAnimal;
        public MainWindow()
        {
            InitializeComponent();
        }

      
        private void check_yes_Checked(object sender, RoutedEventArgs e)
        {
            if (check_no.IsChecked == true)
            {
                check_no.IsChecked = false;
            }
            info_type_animal.IsEnabled=true;
            input_nameParent.IsEnabled = true;
            info_type_animal.IsEnabled = true;
            Name_Animal.IsEnabled = true;
            Kind_of_Animal.IsEnabled = true;

        }

        private void check_no_Checked(object sender, RoutedEventArgs e)
        {
            if(check_yes.IsChecked==true)
            {
                check_yes.IsChecked = false;
            }
            
            Name_Animal.IsEnabled = false;
            info_type_animal.IsEnabled = false;
            input_nameParent.IsEnabled = true;
            Kind_of_Animal.IsEnabled = true;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text != "" && sername.Text != "" && check_no.IsChecked.Value == true)
                
            {
                Error_Input.Content = "";
                MessageBox.Show($"Уважаемый {name.Text} {sername.Text} \n Советуем вам завести питомца! \n Это круто!");
            } 
            else if(name.Text == "" || sername.Text == "" || (check_no.IsChecked.Value==false && check_yes.IsChecked.Value == false))
            {
                Error_Input.Content = "Заполните корректно поля! (имя и фамилия и наличие животных)";
            }
            else if (name.Text != "" && sername.Text != "" && check_yes.IsChecked.Value==true && this.Choise_Animal!="")
            {

                Error_Input.Content = "";

                if (String.IsNullOrEmpty(this._NameAnimal) || this._NameAnimal == "")
                    MessageBox.Show($"{name.Text} {sername.Text} вы счастливее остальных! \n ведь у Вас есть лучший друг {this.Choise_Animal}, \n" +
                        $"к сожалению вы не указали кличку питомца !");

                else
                {
                    MessageBox.Show($"{name.Text} {sername.Text} вы счастливее многих! \n ведь у Вас есть лучший друг - {this.Choise_Animal} по кличке {this._NameAnimal}!");
                }
            }

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            this.Choise_Animal = pressed.Content.ToString();
            
            
        }


        private void check_yes_Unchecked(object sender, RoutedEventArgs e)
        {
            info_type_animal.IsEnabled = false;

        }

        private void input_nameParent_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            this._NameAnimal = t.Text;
        }
    }
}
