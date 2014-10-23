using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KINECT_UI_1
{
    class User//User profile
    {
        //public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int EstimatedHeight { get; set; }//height in cms
        public int ActualHeight { get; set; }
        public int AverageHeight { get; set; }

        //int id,
        public User(string name, DateTime date, int estHeight, int actHeight, int avgHeight)
        {
            //ID = id;
            Name = name;
            Date = date;
            EstimatedHeight = estHeight;
            ActualHeight = actHeight;
            AverageHeight = avgHeight;
        }


        public override string ToString()
        {
            return string.Format("Name: {0}\n Date: {1}\n Estimated Height: {2}\n Actual Height: {3}\n Average Height: {4}\n", Name, Date, EstimatedHeight, ActualHeight, AverageHeight);
        }

        public string FileWriteFormat()
        {
            return Name + "," + Date + "," + EstimatedHeight + "," + ActualHeight + "," + AverageHeight;
        }
    }//end clas User
}
