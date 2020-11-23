using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int login;
        private List<int[]> subscribersList = new List<int[]>
            {
                new int[] { 2, 3, 4 },
                new int[] { 1, 3 },
                new int[] { 2, 4 },
                new int[] { 1, 2 },
            };

        private List<string[]> MessageList = new List<string[]>
            {
                new string[] { },
                new string[] { },
                new string[] { },
                new string[] { },
            };

        private List<int[]> subscribeList = new List<int[]>
            {
                new int[] { 2, 4 },
                new int[] { 1, 3 , 4},
                new int[] { 1, 2 },
                new int[] { 1, 3 },
            };

        public string IntegerConvert(int userid)
        {
            string result = "";
            foreach (int user in subscribersList[userid])
            {
                result += Convert.ToString(user) + ", ";
            }
            return result;
        }

        public string MessageQuery(int userid)
        {
            string result = "";
            foreach (string msg in MessageList[userid])
            {
                result += msg + "\n";
            }
            return result;
        }

        public void showSubscribers()
        {
            resultSubscribers1.Content = IntegerConvert(0);
            resultSubscribers2.Content = IntegerConvert(1);
            resultSubscribers3.Content = IntegerConvert(2);
            resultSubscribers4.Content = IntegerConvert(3);
        }

        public void showMessage()
        {
            textMessage1.Text = MessageQuery(0);
            textMessage2.Text = MessageQuery(1);
            textMessage3.Text = MessageQuery(2);
            textMessage4.Text = MessageQuery(3);
        }

        public MainWindow()
        {
            InitializeComponent();
            showSubscribers();
            showMessage();
        }

        private void radio1_Checked(object sender, RoutedEventArgs e)
        {
            login = 0;
            if (subscribeList[0].Contains(2))
                check2.IsChecked = true;
            else
                check2.IsChecked = false;

            if (subscribeList[0].Contains(3))
                check3.IsChecked = true;
            else
                check3.IsChecked = false;

            if (subscribeList[0].Contains(4))
                check4.IsChecked = true;
            else
                check4.IsChecked = false;

            check1.IsChecked = false;
            check1.IsEnabled = false;
            check2.IsEnabled = true;
            check3.IsEnabled = true;
            check4.IsEnabled = true;
        }

        private void radio2_Checked(object sender, RoutedEventArgs e)
        {
            login = 1;
            if (subscribeList[1].Contains(1))
                check1.IsChecked = true;
            else
                check1.IsChecked = false;

            if (subscribeList[1].Contains(3))
                check3.IsChecked = true;
            else
                check3.IsChecked = false;

            if (subscribeList[1].Contains(4))
                check4.IsChecked = true;
            else
                check4.IsChecked = false;

            check2.IsChecked = false;
            check1.IsEnabled = true;
            check2.IsEnabled = false;
            check3.IsEnabled = true;
            check4.IsEnabled = true;
        }

        private void radio3_Checked(object sender, RoutedEventArgs e)
        {
            login = 2;
            if (subscribeList[2].Contains(1))
                check1.IsChecked = true;
            else
                check1.IsChecked = false;

            if (subscribeList[2].Contains(2))
                check2.IsChecked = true;
            else
                check2.IsChecked = false;

            if (subscribeList[2].Contains(4))
                check4.IsChecked = true;
            else
                check4.IsChecked = false;

            check3.IsChecked = false;
            check1.IsEnabled = true;
            check2.IsEnabled = true;
            check3.IsEnabled = false;
            check4.IsEnabled = true;
        }

        private void radio4_Checked(object sender, RoutedEventArgs e)
        {
            login = 3;
            if (subscribeList[3].Contains(1))
                check1.IsChecked = true;
            else
                check1.IsChecked = false;

            if (subscribeList[3].Contains(2))
                check2.IsChecked = true;
            else
                check2.IsChecked = false;

            if (subscribeList[3].Contains(3))
                check3.IsChecked = true;
            else
                check3.IsChecked = false;

            check4.IsChecked = false;
            check1.IsEnabled = true;
            check2.IsEnabled = true;
            check3.IsEnabled = true;
            check4.IsEnabled = false;
        }
        
        public void Subscribe1(Boolean Check1)
        {
            if (Check1 == true && subscribeList[login].Contains(1) == false)
            {
                subscribeList[login] = subscribeList[login].Append(1).ToArray();
                subscribersList[0] = subscribersList[0].Append(login + 1).ToArray();
            }
            else if (Check1 == false && subscribeList[login].Contains(1))
            {
                subscribeList[login] = subscribeList[login].Where(val => val != 1).ToArray();
                subscribersList[0] = subscribersList[0].Where(val => val != login + 1).ToArray();
            }
        }

        public void Subscribe2(Boolean Check2)
        {
            if (Check2 == true && subscribeList[login].Contains(2) == false)
            {
                subscribeList[login] = subscribeList[login].Append(2).ToArray();
                subscribersList[1] = subscribersList[1].Append(login + 1).ToArray();
            }
            else if (Check2 == false && subscribeList[login].Contains(2))
            {
                subscribeList[login] = subscribeList[login].Where(val => val != 2).ToArray();
                subscribersList[1] = subscribersList[1].Where(val => val != login + 1).ToArray();
            }
        }

        public void Subscribe3(Boolean Check3)
        {
            if (Check3 == true && subscribeList[login].Contains(3) == false)
            {
                subscribeList[login] = subscribeList[login].Append(3).ToArray();
                subscribersList[2] = subscribersList[2].Append(login + 1).ToArray();
            }
            else if (Check3 == false && subscribeList[login].Contains(3))
            {
                subscribeList[login] = subscribeList[login].Where(val => val != 3).ToArray();
                subscribersList[2] = subscribersList[2].Where(val => val != login + 1).ToArray();
            }
        }

        public void Subscribe4(Boolean Check4)
        {

            if (Check4 == true && subscribeList[login].Contains(4) == false)
            {
                subscribeList[login] = subscribeList[login].Append(4).ToArray();
                subscribersList[3] = subscribersList[3].Append(login + 1).ToArray();
            }
            else if (Check4 == false && subscribeList[login].Contains(4))
            {
                subscribeList[login] = subscribeList[login].Where(val => val != 4).ToArray();
                subscribersList[3] = subscribersList[3].Where(val => val != login + 1).ToArray();
            }
        }

        private void buttonConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (radioFast.IsChecked == true || radioSlow.IsChecked == true)
            {
                Boolean checksuser1 = (bool)check1.IsChecked;
                Boolean checksuser2 = (bool)check2.IsChecked;
                Boolean checksuser3 = (bool)check3.IsChecked;
                Boolean checksuser4 = (bool)check4.IsChecked;
                Thread t1 = new Thread(() => Subscribe1(checksuser1));
                Thread t2 = new Thread(() => Subscribe2(checksuser2));
                Thread t3 = new Thread(() => Subscribe3(checksuser3));
                Thread t4 = new Thread(() => Subscribe4(checksuser4));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                if (radioSlow.IsChecked == true)
                    MessageBox.Show("Your subscribe list has updated!");
                showSubscribers();
            }
            else
                MessageBox.Show("Please select Refresh Type!");
        }

        private void buttonPublish_Click(object sender, RoutedEventArgs e)
        {
            if (radioFast.IsChecked == true || radioSlow.IsChecked == true)
            {
                string message = textMessage.Text;
                foreach (int user in subscribersList[login])
                {
                    Thread t = new Thread(() => messageSender(user - 1, message));
                    t.Start();
                }
                if (radioSlow.IsChecked == true)
                    MessageBox.Show("Message sent to your subscribers!");
                showMessage();
            }
            else
                MessageBox.Show("Please select Refresh Type!");
        }

        public void messageSender(int user, string message)
        {
            MessageList[user] = MessageList[user].Append(message).ToArray();
        }
    }
}
