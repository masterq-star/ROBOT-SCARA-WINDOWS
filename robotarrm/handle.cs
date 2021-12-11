using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace robotarrm
{
    public class handle
    {
        public string MOV_HANDLE(float x , float y , float z , float a ) {
            var data = new System.Text.StringBuilder();
            data.Append(string.Format("G1X-{0:f}", x));
            data.Append(string.Format("Y-{0:f}", y));
            data.Append(string.Format("Z-{0:f}", z));
            data.Append(string.Format("A-{0:f}\n", a));
            return data.ToString();
        }
        public int DLY_handle(int delay)
        {
            return delay;
        }
        
        public string SPEED(int speed)
        {
            string data;
            data = "G1 F" + speed.ToString() + "\n";
            return data;
        }
        public float gety(ListView mylistview,int point)
        {
            return float.Parse(mylistview.Items[point].SubItems[2].Text);
          
        }
        public float getz(ListView mylistview, int point)
        {
            return float.Parse(mylistview.Items[point].SubItems[3].Text);

        }
        public float geta(ListView mylistview, int point)
        {
            return float.Parse(mylistview.Items[point].SubItems[4].Text);

        }
        public float getx(ListView mylistview, int point)
        {
            return float.Parse(mylistview.Items[point].SubItems[1].Text);

        }
        public bool read_input_ok(string input , int stt , int value)
        {
            uint value_convert = uint.Parse(input, System.Globalization.NumberStyles.HexNumber);
            int data_check;
            if(value == 1)
            {
                data_check = 1 << stt;
            }
            else
            {
                data_check = 0;
            }
            if ((data_check ^ value_convert) != 0)
            {
                return true;

            }
            else return false;
        }
    }
}
