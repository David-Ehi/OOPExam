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

namespace OOPExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Robot> robots;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            robots = CreateRobots();
            lbxRobotList.ItemsSource = robots;
            
        }

        public List<Robot> CreateRobots()
        {

            List<Robot> AllRobot = new List<Robot>();
            HouseHoldRobot r1 = new HouseHoldRobot() { Name = "HouseBot", TypeofRobot="HouseHold"};
            HouseHoldRobot r2 = new HouseHoldRobot() { Name = "GardenMate", TypeofRobot = "HouseHold" };
            //r2.DownloadSkill(Gardening);
            HouseHoldRobot r3 = new HouseHoldRobot() { Name = "Housemate 3000", TypeofRobot = "HouseHold" };
            //r3.DownloadSkill(Laundry);


            DeliveryRobot r4 = new DeliveryRobot() { Name = "DeliverBot", TypeofRobot = "Delivery" };
            DeliveryRobot r5 = new DeliveryRobot() { Name = "FlyBot", TypeofRobot = "Delivery" };
            DeliveryRobot r6 = new DeliveryRobot() { Name = "Driver", TypeofRobot = "Delivery" };
            AllRobot.Add(r1);
            AllRobot.Add(r2);
            AllRobot.Add(r3);
            AllRobot.Add(r4);
            AllRobot.Add(r5);
            AllRobot.Add(r6);



            return AllRobot;
        }
    }
}


//i couldnt get anything to commit. I dont know why but here is the link to the repo anyways: https://github.com/David-Ehi/OOPExam