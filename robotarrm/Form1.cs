using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace robotarrm
{
    public partial class controrl_arm : MetroFramework.Forms.MetroForm
    { string data_receive;

        Thread nthread;
        bool check_servor = false;
        bool drag_drop = false;
        string path = "data.txt", READ_INPUT = "S000000Z";
        string point_path = "point.txt";
       // string point_path = "point.txt";
        bool idle_signal = false, check_thread = false, check_thread_is_initialization = false;
        public controrl_arm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            data_binding_f();
        }

        private void data_binding_f()
        {
            Binding databindingx = new Binding("Text",x_value, "Value",true,DataSourceUpdateMode.OnPropertyChanged);
            tb_x_value.DataBindings.Add(databindingx);
            Binding databindingy = new Binding("Text", y_value, "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            tb_y_value.DataBindings.Add(databindingy);
            Binding databindingz = new Binding("Text", z_value, "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            tb_z_value.DataBindings.Add(databindingz);
            Binding databindinga = new Binding("Text", a_value, "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            tb_a_value.DataBindings.Add(databindinga);
        }

        private void controrl_arm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++)
                cbb_name_port.Items.Add("COM" + i);
            status_lb_app.Width = 200;
            cbb_name_port.Text = setting_com.Default["name_port"].ToString();
            rtb_code_rb.Text = System.IO.File.ReadAllText(path);
            list_point.Items.Clear();
            gr_run.Enabled = false;
            load_point_data();



            //var l_point = getpointlist();
        }

        //private List<Point_robot> getpointlist()
        //{
        //    throw new NotImplementedException();
        //}

        private void btn_connect_uart_Click(object sender, EventArgs e)
        {
            if (!newserial.IsOpen)
            {
                try {
                    newserial.PortName = cbb_name_port.Text;
                    newserial.Open();
                    btn_connect_uart.Text = "Disconnect";
                    status_lb_app.BackColor = Color.White;
                    status_lb_app.Text = "Connect ok";
                    gr_run.Enabled = true;
                }
                catch (Exception err)
                {
                    status_lb_app.BackColor = Color.Red;
                    status_lb_app.Text = err.Message;
                }

            }
            else
            {
                newserial.Close();
                btn_connect_uart.Text = "Connect";
                gr_run.Enabled = false;
            }


        }

        private void btn_control_servor_Click(object sender, EventArgs e)
        {
            byte[] Sevor_on = new byte[2] { 0xA6, 0xA9 };
            byte[] Sevor_off = new byte[2] { 0xA7, 0xA8 };
            byte[] code_open = new byte[2] { 0xB0, 0xB2 };
            byte[] code_close = new byte[2] { 0xB1, 0xB3 };
            if (newserial.IsOpen)
            {

                if (!check_servor)
                {
                    newserial.Write(Sevor_on, 0, 2);
                    btn_control_servor.Text = "SERVOR OFF";
                    newserial.Write("$X\n");
                    newserial.Write(code_open, 0, 2);
                    check_servor = true;
                }
                else
                {
                    newserial.Write(Sevor_off, 0, 2);
                    btn_control_servor.Text = "SERVOR ON";
                    newserial.Write(code_close, 0, 2);
                    check_servor = false;
                }

            }
        }

        private void btn_homeall_Click(object sender, EventArgs e)
        {
            if (newserial.IsOpen)
            {
                newserial.Write("$HA\n$HZ\n$HX\n$HY\n");
            }
        }

        private void UART_receive(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            data_receive = newserial.ReadExisting();



            this.Invoke(new EventHandler(show_to_status));
        }

        private void show_to_status(object sender, EventArgs e)
        {
            if (data_receive.Contains("S") && data_receive.Contains("Z") && data_receive.Length <= 15) READ_INPUT = data_receive.Substring(
                 data_receive.IndexOf("S"), 8);
            //status_lb_app.Text = READ_INPUT;

            if (data_receive.Contains("Idle")) idle_signal = true;
            // status_lb_app.Text = data_receive;

        }

        private void closed_event(object sender, FormClosedEventArgs e)
        {
            byte[] Sevor_off = new byte[2] { 0xA7, 0xA8 };
            byte[] code_close = new byte[2] { 0xB1, 0xB3 };
            newserial.Write(Sevor_off, 0, 2);
            newserial.Write(code_close, 0, 2);
            newserial.Close();
            rtb_code_rb.SaveFile(path, RichTextBoxStreamType.PlainText);
            setting_com.Default["name_port"] = cbb_name_port.Text;
            setting_com.Default.Save();
            savedata_point();
        }
        private void savedata_point()
        {
            string mess = "";
            foreach (ListViewItem item in list_point.Items)
            {
                mess += item.SubItems[0].Text.ToString() + " ";
                mess += item.SubItems[1].Text.ToString() + " ";
                mess += item.SubItems[2].Text.ToString() + " ";
                mess += item.SubItems[3].Text.ToString() + " ";
                mess += item.SubItems[4].Text.ToString() + " ";
                //   mess += item.SubItems[4].Text.ToString();
                mess += Environment.NewLine;


            }
            File.WriteAllText(point_path, mess);
        }
        private void load_point_data()
        {
          //  int i = 0;
            foreach (var line in File.ReadLines(point_path))
            {
                string[] arrListStr = line.Split(' ');
               // string[] row = { "P" + (list_point.Items.Count), (x_value.Value / 10).ToString(), (y_value.Value / 10).ToString(), (z_value.Value / 10).ToString(), (a_value.Value / 10).ToString() };
                var listViewItem = new ListViewItem(arrListStr);
                list_point.Items.Add(listViewItem);
            }
        }

        private void speed_key_press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void check_text(object sender, EventArgs e)
        {
            int speed;
            try { speed = Int16.Parse(tb_speed.Text); }
            catch { speed = 0; }

            if (speed > 5000 || speed < 100)
            {
                lb_notification.Text = "speed should be between 100-5000";
            }
            else
            {
                lb_notification.Text = "speed is invalid";
            }

        }

        private void btn_savedata_Click(object sender, EventArgs e)
        {
            string[] row = { "P" + (list_point.Items.Count), (x_value.Value/1000).ToString(), (y_value.Value / 1000).ToString(), (z_value.Value / 1000).ToString(), (a_value.Value / 1000).ToString() };
            var listViewItem = new ListViewItem(row);
            list_point.Items.Add(listViewItem);


        }

        private void btn_custom1_Click(object sender, EventArgs e)
        {
            byte[] byte_led_start = new byte[2] { 0xA0, 0xA3 };
            newserial.Write(byte_led_start, 0, 2);
            ThreadStart new_thread_start = new ThreadStart(run_code);
            nthread = new Thread(new_thread_start);
            nthread.Start();
            if (nthread.IsAlive) { check_thread = true; check_thread_is_initialization = true; }

        }

        private void run_code()
        {
            handle newhandle = new handle();
            while (true)
            {
                for (int i = 0; i < rtb_code_rb.Lines.Length; i++)
                {
                    string[] handle_string = rtb_code_rb.Lines;
                    try
                    {
                        //status_lb_app.Text = "line data from " + i;
                        if (handle_string[i].Contains("MOV"))
                        {
                            int point = Int16.Parse(handle_string[i].Substring(5));
                           // status_lb_app.Text = point.ToString();
                            if (list_point.Items[point] == null)
                            {
                                status_lb_app.Text = "this point data is null == ignore command";
                            }
                            else
                            {
                                status_lb_app.Text = "line data from " + i;
                                newserial.Write(newhandle.MOV_HANDLE(
                                    newhandle.getx(list_point, point),
                                    newhandle.gety(list_point, point),
                                    newhandle.getz(list_point, point),
                                    newhandle.geta(list_point, point)));
                            }

                        }
                        else if (handle_string[i].Contains("DLY"))
                        {
                            Thread.Sleep(newhandle.DLY_handle(Int16.Parse(handle_string[i].Substring(4))));
                            //     Thread.Sleep(Int16.Parse(handle_string[i].Substring(4)));
                        }
                        else if (handle_string[i].Contains("SPD"))
                        {
                            string data_speed;
                            data_speed = "G1 F" + handle_string[i].Substring(4) + "\n";
                            newserial.Write(data_speed);
                        }
                        else if (handle_string[i].Contains("MOUT"))
                        {
                            Thread.Sleep(100);
                            do
                            {
                                newserial.Write("?");
                                status_lb_app.Text = "WAITING Move to P complete... ";
                                if (!check_thread) nthread.Abort();
                                Thread.Sleep(10);
                            }
                            while (!idle_signal);
                            idle_signal = false;
                            byte[] code_output_on = new byte[16] { 0x90 , 0x92 , 0x94 , 0x96 , 0x98 , 0x9A , 0x9C , 0x9E ,
                                                                   0xA0 , 0xA2, 0xA4 , 0xA6 , 0xA8 , 0xAA , 0xAC , 0xAE};
                            byte[] code_output_off = new byte[16] { 0x91 , 0x93 , 0x95 , 0x97 , 0x99 , 0x9B , 0x9D , 0x9F ,
                                                                    0xA1 , 0xA3, 0xA5 , 0xA7 , 0xA9 , 0xAB , 0xAD , 0xAF};
                            string[] arrListStr = handle_string[i].Split(' ');
                            int stt_out = Int16.Parse(arrListStr[1]);
                            int value_out = Int16.Parse(arrListStr[2]);
                            if (value_out == 1)
                            {
                                newserial.Write(code_output_on, stt_out, 1);
                            }
                            else
                            {
                                newserial.Write(code_output_off, stt_out, 1);
                            }



                        }
                        else if (handle_string[i].Contains("MVS"))
                        {
                            do
                            {
                                newserial.Write("?");
                                status_lb_app.Text = "WAITING Move to P complete... ";
                                if (!check_thread) nthread.Abort();
                                Thread.Sleep(50);
                            }
                            while (!idle_signal);
                            idle_signal = false;
                            int point = Int16.Parse(handle_string[i].Substring(5));
                            status_lb_app.Text = point.ToString();
                            if (list_point.Items[point] == null)
                            {
                                status_lb_app.Text = "this point data is null == ignore command";
                            }
                            else
                            {
                              //  status_lb_app.Text = "line data from " + i;
                                newserial.Write(newhandle.MOV_HANDLE(
                                    newhandle.getx(list_point, point),
                                    newhandle.gety(list_point, point),
                                    newhandle.getz(list_point, point),
                                    newhandle.geta(list_point, point)));
                            }

                        }
                        else if (handle_string[i].Contains("WAIT MIN")) {
                            string[] arrListStr = handle_string[i].Split(' ');
                            byte[] byte_read_input = new byte[1] { 0xD0 };
                            int stt_in = Int16.Parse(arrListStr[2]);
                            int value_in = Int16.Parse(arrListStr[3]);
                            newserial.Write(byte_read_input, 0, 1);
                            do
                            {
                                newserial.Write(byte_read_input, 0, 1);
                                Thread.Sleep(100);
                                //  newserial.Write(READ_INPUT.Substring(1, 4) + "======" + stt_in.ToString() + "=====" + value_in.ToString() + "\n");
                            }
                            while (newhandle.read_input_ok(READ_INPUT.Substring(1, 4), stt_in, value_in));
                            READ_INPUT = "S000000Z";


                        }
                        else if (handle_string[i].Contains("BEGIN"))
                        {
                            status_lb_app.Text = "CODE Begin";


                        }
                        else if (handle_string[i].Contains("END"))
                        {
                            status_lb_app.Text = "CODE End";


                        }
                        else
                        { }
                    }
                    catch (Exception err) {
                        status_lb_app.Text = err.Message;
                    }


                }



            }


            //    status_lb_app.Text = rtb_code_rb.Lines.Length.ToString();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (check_thread_is_initialization)
            {
                check_thread = true;
                byte[] byte_led_stop = new byte[2] { 0xA1, 0xA2 };
                if (newserial.IsOpen) newserial.Write(byte_led_stop, 0, 2);
                if (check_thread) { nthread.Abort(); check_thread = false; }
                else status_lb_app.Text = "Code have never run you should run code program before ";
            }
            else status_lb_app.Text = " You haven't initialized the thread you should press run before";








        }



        private void mouseA_changed(object sender, EventArgs e)
        {
            if (newserial.IsOpen)
            {
                upload_data();
                check_listview();
            }
            else
            {
                status_lb_app.Text = "Please open com port!";
            }
        }

        private void mouse_z_changed(object sender, EventArgs e)
        {
            if (newserial.IsOpen)
            {
                upload_data();
                check_listview();
            }
            else
            {
                status_lb_app.Text = "Please open com port!";
            }
        }

        private void mouse_y_changed(object sender, EventArgs e)
        {
            if (newserial.IsOpen)
            {
                upload_data();
                check_listview();
            }
            else
            {
                status_lb_app.Text = "Please open com port!";
            }
        }

        private void mouse_x_changed(object sender, EventArgs e)
        {
            if (newserial.IsOpen)
            {
                upload_data();
                check_listview();
            }
            else
            {
                status_lb_app.Text = "Please open com port!";
            }
        }

        private void upload_data()
        {
            var data = new System.Text.StringBuilder();
            data.Append(string.Format("G1 X-{0:0.000} ", (x_value.Value)/1000));
            data.Append(string.Format("Y-{0:0.000} ", (y_value.Value) / 1000));
            data.Append(string.Format("Z-{0:0.000} ", (z_value.Value) / 1000));
            data.Append(string.Format("A-{0:0.000} ", (a_value.Value) / 1000));
            if (string.IsNullOrEmpty(tb_speed.Text))
            { data.Append("F500\n"); }
            else
            {
                int speed = Int16.Parse(tb_speed.Text.ToString());
                if (speed == 0 || speed >5000) data.Append("F500\n");
                else data.Append("F" + tb_speed.Text.ToString() + "\n");
            }
              
            newserial.Write(data.ToString());
            status_lb_app.Text = data.ToString();
        }
        private void check_listview(){
            if (list_point.SelectedItems.Count > 0)
            {
              float  x_update = x_value.Value / 1000;
                float y_update = y_value.Value / 1000;
                float z_update = z_value.Value / 1000;
                float a_update = a_value.Value / 1000;
                list_point.SelectedItems[0].SubItems[1].Text = x_update.ToString();
                list_point.SelectedItems[0].SubItems[2].Text = y_update.ToString();
                list_point.SelectedItems[0].SubItems[3].Text = z_update.ToString();
                list_point.SelectedItems[0].SubItems[4].Text = a_update.ToString();
                status_lb_app.Text = "ok _ check _list";
            }
            else
                status_lb_app.Text = "dont have";
          }

        private void click_listview(object sender, MouseEventArgs e)
        {
            if(list_point.SelectedItems.Count > 0)
            {
                x_value.Value = float.Parse(list_point.SelectedItems[0].SubItems[1].Text) *1000;
                y_value.Value = float.Parse(list_point.SelectedItems[0].SubItems[2].Text) * 1000;
                z_value.Value = float.Parse(list_point.SelectedItems[0].SubItems[3].Text) * 1000;
                a_value.Value = float.Parse(list_point.SelectedItems[0].SubItems[4].Text) * 1000;
               
                if(newserial.IsOpen)upload_data();
            }    
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (list_point.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this point?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    list_point.Items.RemoveAt(list_point.SelectedIndices[0]);
                }
                for (int i = 1; i < list_point.Items.Count; i++)
                {
                    list_point.Items[i].SubItems[0].Text = "P" + i;
                }
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear this data? ", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                list_point.Items.Clear();
            }
        }

        private void x_enter(object sender, KeyEventArgs e)
        {
            int step;
            if (String.IsNullOrEmpty(tb_Step.Text)) step = 1;
            else step = Int16.Parse(tb_Step.Text);
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    enter_key(tb_x_value, 2000, 35000);
                    break;
                case Keys.Up:

                    key_up_events(tb_x_value,2000,35000);
                    break;
                case Keys.Down:
                    key_down_events(tb_x_value, 2000, 35000);
                    break;
                default:break;
            }
            

        }

       

        private void y_enter(object sender, KeyEventArgs e)
        {
           
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    enter_key(tb_y_value, 2000, 35000);
                    break;
                case Keys.Up:

                    key_up_events(tb_y_value, 2000, 35000);
                    break;
                case Keys.Down:
                    key_down_events(tb_y_value, 2000, 35000);
                    break;
                default: break;
            }


        }

        private void z_enter(object sender, KeyEventArgs e)
        {
            enter_key(tb_z_value, 2000, 19000);
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    enter_key(tb_z_value, 2000, 19000);
                    break;
                case Keys.Up:
                    key_up_events(tb_z_value, 2000, 19000);
                    break;
                case Keys.Down:
                    key_down_events(tb_z_value, 2000, 19000);
                    break;
                default:break;
            }
        }

        private void a_enter(object sender, KeyEventArgs e)
        {
        
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    enter_key(tb_a_value, 2000, 18000);
                    break;
                case Keys.Up:
                    key_up_events(tb_a_value, 2000, 18000);
                    break;
                case Keys.Down:
                    key_down_events(tb_a_value, 2000, 18000);
                    break;
                default:break;
            }
        }
        private void key_up_events(TextBox textBox, int min , int max)
        {
            int step;
            if (String.IsNullOrEmpty(tb_Step.Text)) step = 1;
            else step = Int16.Parse(tb_Step.Text);


            if (Int32.Parse(textBox.Text) > (max-step))
                status_lb_app.Text = "Your value is limit";
            else
            {
                textBox.Text = (Int32.Parse(textBox.Text) + step).ToString();
               // status_lb_app.Text = "Your value is ok.";
                upload_data();
                
                
            }
            
        }
        private void key_down_events(TextBox textBox, int min, int max)
        {
            int step;
            if (String.IsNullOrEmpty(tb_Step.Text)) step = 1;
            else step = Int16.Parse(tb_Step.Text);


            if (Int32.Parse(textBox.Text) < (min + step))
                status_lb_app.Text = "Your value is limit";
            else
            {
                textBox.Text = (Int32.Parse(textBox.Text) - step).ToString();
                status_lb_app.Text = "Your value is ok.";
                upload_data();

            }
        }
        private void enter_key( TextBox textbox, int min, int max)
        {
           
                int x = Int32.Parse(textbox.Text.ToString());
                if (x > max || x < min)
                    status_lb_app.Text = "Your value is fault.";
                else
                {
                    if (newserial.IsOpen)
                    {
                        upload_data();
                        check_listview();
                        status_lb_app.Text = "Your value is ok.";
                    }
                    else
                    {
                        status_lb_app.Text = "Please open com port!";
                    }
                }
            
        }
        private void key_x_check(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void key_y_check(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void key_z_check(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       

        private void key_a_check(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_drag_Click(object sender, EventArgs e)
        {
            byte[] code_drag = new byte[1] { 0x90 };
            byte[] code_drop = new byte[1] { 0x91 };
            try { 
             if(!drag_drop)
                {
                    newserial.Write(code_drag, 0, 1);
                    btn_drag.Text = "DROP";
                    drag_drop = !drag_drop;

                } 
             else
                {
                    newserial.Write(code_drop, 0, 1);
                    btn_drag.Text = "DRAG";
                    drag_drop = !drag_drop;
                }    
            }
            catch(Exception err) {
                status_lb_app.Text = err.Message;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://hbhanoi.com/");
        }
    }
}
