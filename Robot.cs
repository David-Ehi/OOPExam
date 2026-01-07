using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public enum HouseholdSkill { Cooking, Cleaning, Laundry, Gardening, ChildCare }
    public enum DeliveryMode { Walking, Driving, Flying }

    public abstract class Robot
    {
        //properties

        public string Name { get; set; }

        public double PowerCapacityKWH { get; set; }

        public double CurrentPowerKWH { get; set; }

        //constructors
        public Robot()
        {
            Name = "";
            PowerCapacityKWH = 0;
            CurrentPowerKWH = 0;
        }

        //methods

        public double GetBatteyPercentage()
        {
            return (CurrentPowerKWH / PowerCapacityKWH) *100;
        }

        public string DisplayBatteryInformation()
        {
            return $"Battery Information\nCapacity {PowerCapacityKWH}\nCurrent Power {CurrentPowerKWH}\nBattery Level: {GetBatteyPercentage()}%";
        }

        public virtual string DescribeRobot()
        {
            return "";
        }
        //toString override
        public override string ToString()
        {
            return $"{Name} - ";
        }
    } //end of class

    public class HouseHoldRobot: Robot
    {
        //properties

        private List<HouseholdSkill> Skills;

        
        //constuctors
        public HouseHoldRobot()
        {
        }
        
        //methods
        public override string DescribeRobot()
        {
            return $"I am a Household Robot.\nI can help with chores around the house.\n\nHousehold Robot Skills {Skills}\n{DisplayBatteryInformation()}";
        }
        public void DownloadSkill(Enum hhskill)
        {
           //Skills.Add(hhskill);
        }
    }

    public class DeliveryRobot : Robot
    {

        //properties
        private List<DeliveryMode> ModeOfDelivery;
        public double MaxLoadKG { get; set; }

        //methods

        public override string DescribeRobot()
        {
            return $"I am a Delivery Robot.\n\nI specialise in Delivery by{ModeOfDelivery}\nThe Maximum load i can carry is {MaxLoadKG}KG{DisplayBatteryInformation()}";
        }



    }

}
