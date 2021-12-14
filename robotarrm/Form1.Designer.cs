namespace robotarrm
{
    partial class controrl_arm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controrl_arm));
            this.control_tab = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.gr_run = new System.Windows.Forms.GroupBox();
            this.btn_custom1 = new robotarrm.btn_custom();
            this.btn_stop = new robotarrm.btn_custom();
            this.btn_homeall = new robotarrm.btn_custom();
            this.btn_control_servor = new robotarrm.btn_custom();
            this.btn_connect_uart = new robotarrm.btn_custom();
            this.cbb_name_port = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_code_rb = new System.Windows.Forms.RichTextBox();
            this.tab_point = new MetroFramework.Controls.MetroTabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Step = new System.Windows.Forms.TextBox();
            this.tb_a_value = new System.Windows.Forms.TextBox();
            this.tb_z_value = new System.Windows.Forms.TextBox();
            this.tb_y_value = new System.Windows.Forms.TextBox();
            this.tb_x_value = new System.Windows.Forms.TextBox();
            this.btn_clr = new robotarrm.btn_custom();
            this.btn_delete = new robotarrm.btn_custom();
            this.btn_drag = new robotarrm.btn_custom();
            this.lb_notification = new System.Windows.Forms.Label();
            this.tb_speed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_savedata = new robotarrm.btn_custom();
            this.list_point = new System.Windows.Forms.ListView();
            this.point = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.z = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.a = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.a_value = new HZH_Controls.Controls.UCTrackBar();
            this.z_value = new HZH_Controls.Controls.UCTrackBar();
            this.y_value = new HZH_Controls.Controls.UCTrackBar();
            this.x_value = new HZH_Controls.Controls.UCTrackBar();
            this.about = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.newserial = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_lb_app = new System.Windows.Forms.ToolStripStatusLabel();
            this.control_tab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.gr_run.SuspendLayout();
            this.tab_point.SuspendLayout();
            this.about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // control_tab
            // 
            this.control_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.control_tab.Controls.Add(this.metroTabPage1);
            this.control_tab.Controls.Add(this.tab_point);
            this.control_tab.Controls.Add(this.about);
            this.control_tab.Location = new System.Drawing.Point(0, 63);
            this.control_tab.Name = "control_tab";
            this.control_tab.SelectedIndex = 1;
            this.control_tab.Size = new System.Drawing.Size(960, 439);
            this.control_tab.TabIndex = 0;
            this.control_tab.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.gr_run);
            this.metroTabPage1.Controls.Add(this.btn_connect_uart);
            this.metroTabPage1.Controls.Add(this.cbb_name_port);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.rtb_code_rb);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(952, 397);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Run program";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // gr_run
            // 
            this.gr_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gr_run.Controls.Add(this.btn_custom1);
            this.gr_run.Controls.Add(this.btn_stop);
            this.gr_run.Controls.Add(this.btn_homeall);
            this.gr_run.Controls.Add(this.btn_control_servor);
            this.gr_run.Location = new System.Drawing.Point(749, 83);
            this.gr_run.Name = "gr_run";
            this.gr_run.Size = new System.Drawing.Size(184, 246);
            this.gr_run.TabIndex = 12;
            this.gr_run.TabStop = false;
            this.gr_run.Text = "Run";
            // 
            // btn_custom1
            // 
            this.btn_custom1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_custom1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btn_custom1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_custom1.BorderRadius = 10;
            this.btn_custom1.BorderSize = 0;
            this.btn_custom1.FlatAppearance.BorderSize = 0;
            this.btn_custom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_custom1.ForeColor = System.Drawing.Color.White;
            this.btn_custom1.Location = new System.Drawing.Point(17, 23);
            this.btn_custom1.Name = "btn_custom1";
            this.btn_custom1.Size = new System.Drawing.Size(150, 40);
            this.btn_custom1.TabIndex = 3;
            this.btn_custom1.Text = "RUN";
            this.btn_custom1.TextColor = System.Drawing.Color.White;
            this.btn_custom1.UseVisualStyleBackColor = false;
            this.btn_custom1.Click += new System.EventHandler(this.btn_custom1_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_stop.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btn_stop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_stop.BorderRadius = 10;
            this.btn_stop.BorderSize = 0;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Location = new System.Drawing.Point(17, 69);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(150, 40);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "STOP";
            this.btn_stop.TextColor = System.Drawing.Color.White;
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_homeall
            // 
            this.btn_homeall.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_homeall.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btn_homeall.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_homeall.BorderRadius = 10;
            this.btn_homeall.BorderSize = 0;
            this.btn_homeall.FlatAppearance.BorderSize = 0;
            this.btn_homeall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_homeall.ForeColor = System.Drawing.Color.White;
            this.btn_homeall.Location = new System.Drawing.Point(17, 115);
            this.btn_homeall.Name = "btn_homeall";
            this.btn_homeall.Size = new System.Drawing.Size(150, 40);
            this.btn_homeall.TabIndex = 5;
            this.btn_homeall.Text = "HOME ALL";
            this.btn_homeall.TextColor = System.Drawing.Color.White;
            this.btn_homeall.UseVisualStyleBackColor = false;
            this.btn_homeall.Click += new System.EventHandler(this.btn_homeall_Click);
            // 
            // btn_control_servor
            // 
            this.btn_control_servor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_control_servor.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btn_control_servor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_control_servor.BorderRadius = 10;
            this.btn_control_servor.BorderSize = 0;
            this.btn_control_servor.FlatAppearance.BorderSize = 0;
            this.btn_control_servor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_control_servor.ForeColor = System.Drawing.Color.White;
            this.btn_control_servor.Location = new System.Drawing.Point(17, 161);
            this.btn_control_servor.Name = "btn_control_servor";
            this.btn_control_servor.Size = new System.Drawing.Size(150, 40);
            this.btn_control_servor.TabIndex = 6;
            this.btn_control_servor.Text = "SERVOR ON";
            this.btn_control_servor.TextColor = System.Drawing.Color.White;
            this.btn_control_servor.UseVisualStyleBackColor = false;
            this.btn_control_servor.Click += new System.EventHandler(this.btn_control_servor_Click);
            // 
            // btn_connect_uart
            // 
            this.btn_connect_uart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_connect_uart.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_connect_uart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_connect_uart.BorderRadius = 10;
            this.btn_connect_uart.BorderSize = 0;
            this.btn_connect_uart.FlatAppearance.BorderSize = 0;
            this.btn_connect_uart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect_uart.ForeColor = System.Drawing.Color.White;
            this.btn_connect_uart.Location = new System.Drawing.Point(243, 10);
            this.btn_connect_uart.Name = "btn_connect_uart";
            this.btn_connect_uart.Size = new System.Drawing.Size(114, 40);
            this.btn_connect_uart.TabIndex = 11;
            this.btn_connect_uart.Text = "Connect";
            this.btn_connect_uart.TextColor = System.Drawing.Color.White;
            this.btn_connect_uart.UseVisualStyleBackColor = false;
            this.btn_connect_uart.Click += new System.EventHandler(this.btn_connect_uart_Click);
            // 
            // cbb_name_port
            // 
            this.cbb_name_port.BackColor = System.Drawing.Color.White;
            this.cbb_name_port.DropDownHeight = 100;
            this.cbb_name_port.FormattingEnabled = true;
            this.cbb_name_port.IntegralHeight = false;
            this.cbb_name_port.ItemHeight = 23;
            this.cbb_name_port.Location = new System.Drawing.Point(104, 21);
            this.cbb_name_port.Name = "cbb_name_port";
            this.cbb_name_port.Size = new System.Drawing.Size(121, 29);
            this.cbb_name_port.TabIndex = 10;
            this.cbb_name_port.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "COM Name:";
            // 
            // rtb_code_rb
            // 
            this.rtb_code_rb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_code_rb.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_code_rb.Location = new System.Drawing.Point(16, 83);
            this.rtb_code_rb.Name = "rtb_code_rb";
            this.rtb_code_rb.Size = new System.Drawing.Size(707, 246);
            this.rtb_code_rb.TabIndex = 2;
            this.rtb_code_rb.Text = "";
            // 
            // tab_point
            // 
            this.tab_point.Controls.Add(this.label9);
            this.tab_point.Controls.Add(this.tb_Step);
            this.tab_point.Controls.Add(this.tb_a_value);
            this.tab_point.Controls.Add(this.tb_z_value);
            this.tab_point.Controls.Add(this.tb_y_value);
            this.tab_point.Controls.Add(this.tb_x_value);
            this.tab_point.Controls.Add(this.btn_clr);
            this.tab_point.Controls.Add(this.btn_delete);
            this.tab_point.Controls.Add(this.btn_drag);
            this.tab_point.Controls.Add(this.lb_notification);
            this.tab_point.Controls.Add(this.tb_speed);
            this.tab_point.Controls.Add(this.label6);
            this.tab_point.Controls.Add(this.label5);
            this.tab_point.Controls.Add(this.label4);
            this.tab_point.Controls.Add(this.label3);
            this.tab_point.Controls.Add(this.label2);
            this.tab_point.Controls.Add(this.btn_savedata);
            this.tab_point.Controls.Add(this.list_point);
            this.tab_point.Controls.Add(this.a_value);
            this.tab_point.Controls.Add(this.z_value);
            this.tab_point.Controls.Add(this.y_value);
            this.tab_point.Controls.Add(this.x_value);
            this.tab_point.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_point.HorizontalScrollbarBarColor = true;
            this.tab_point.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_point.HorizontalScrollbarSize = 20;
            this.tab_point.Location = new System.Drawing.Point(4, 38);
            this.tab_point.Name = "tab_point";
            this.tab_point.Size = new System.Drawing.Size(952, 397);
            this.tab_point.TabIndex = 1;
            this.tab_point.Text = "Point Data";
            this.tab_point.VerticalScrollbarBarColor = true;
            this.tab_point.VerticalScrollbarHighlightOnWheel = false;
            this.tab_point.VerticalScrollbarSize = 20;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(773, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "STEP:";
            // 
            // tb_Step
            // 
            this.tb_Step.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Step.Location = new System.Drawing.Point(826, 249);
            this.tb_Step.Name = "tb_Step";
            this.tb_Step.Size = new System.Drawing.Size(93, 24);
            this.tb_Step.TabIndex = 27;
            // 
            // tb_a_value
            // 
            this.tb_a_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_a_value.Location = new System.Drawing.Point(832, 189);
            this.tb_a_value.Name = "tb_a_value";
            this.tb_a_value.Size = new System.Drawing.Size(79, 24);
            this.tb_a_value.TabIndex = 26;
            this.tb_a_value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.a_enter);
            this.tb_a_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_a_check);
            // 
            // tb_z_value
            // 
            this.tb_z_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_z_value.Location = new System.Drawing.Point(832, 133);
            this.tb_z_value.Name = "tb_z_value";
            this.tb_z_value.Size = new System.Drawing.Size(79, 24);
            this.tb_z_value.TabIndex = 25;
            this.tb_z_value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.z_enter);
            this.tb_z_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_z_check);
            // 
            // tb_y_value
            // 
            this.tb_y_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_y_value.Location = new System.Drawing.Point(832, 75);
            this.tb_y_value.Name = "tb_y_value";
            this.tb_y_value.Size = new System.Drawing.Size(79, 24);
            this.tb_y_value.TabIndex = 24;
            this.tb_y_value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.y_enter);
            this.tb_y_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_y_check);
            // 
            // tb_x_value
            // 
            this.tb_x_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_x_value.Location = new System.Drawing.Point(832, 15);
            this.tb_x_value.Name = "tb_x_value";
            this.tb_x_value.Size = new System.Drawing.Size(79, 24);
            this.tb_x_value.TabIndex = 23;
            this.tb_x_value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.x_enter);
            this.tb_x_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_x_check);
            // 
            // btn_clr
            // 
            this.btn_clr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clr.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_clr.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btn_clr.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_clr.BorderRadius = 10;
            this.btn_clr.BorderSize = 0;
            this.btn_clr.FlatAppearance.BorderSize = 0;
            this.btn_clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr.ForeColor = System.Drawing.Color.White;
            this.btn_clr.Location = new System.Drawing.Point(761, 325);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(150, 40);
            this.btn_clr.TabIndex = 22;
            this.btn_clr.Text = "Clear";
            this.btn_clr.TextColor = System.Drawing.Color.White;
            this.btn_clr.UseVisualStyleBackColor = false;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_delete.BorderRadius = 10;
            this.btn_delete.BorderSize = 0;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(570, 325);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 40);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextColor = System.Drawing.Color.White;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_drag
            // 
            this.btn_drag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_drag.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_drag.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btn_drag.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_drag.BorderRadius = 10;
            this.btn_drag.BorderSize = 0;
            this.btn_drag.FlatAppearance.BorderSize = 0;
            this.btn_drag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_drag.ForeColor = System.Drawing.Color.White;
            this.btn_drag.Location = new System.Drawing.Point(761, 279);
            this.btn_drag.Name = "btn_drag";
            this.btn_drag.Size = new System.Drawing.Size(150, 40);
            this.btn_drag.TabIndex = 20;
            this.btn_drag.Text = "DRAG";
            this.btn_drag.TextColor = System.Drawing.Color.White;
            this.btn_drag.UseVisualStyleBackColor = false;
            this.btn_drag.Click += new System.EventHandler(this.btn_drag_Click);
            // 
            // lb_notification
            // 
            this.lb_notification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_notification.AutoSize = true;
            this.lb_notification.Location = new System.Drawing.Point(532, 381);
            this.lb_notification.Name = "lb_notification";
            this.lb_notification.Size = new System.Drawing.Size(422, 16);
            this.lb_notification.TabIndex = 19;
            this.lb_notification.Text = "If you don\'t have speed input then speed default is f=500 and step s=1";
            // 
            // tb_speed
            // 
            this.tb_speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_speed.Location = new System.Drawing.Point(620, 249);
            this.tb_speed.Name = "tb_speed";
            this.tb_speed.Size = new System.Drawing.Size(93, 24);
            this.tb_speed.TabIndex = 18;
            this.tb_speed.TextChanged += new System.EventHandler(this.check_text);
            this.tb_speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.speed_key_press);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "SPEED:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Axis A x1000";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Axis Z x1000";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Axis Y x1000";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Axis X x1000";
            // 
            // btn_savedata
            // 
            this.btn_savedata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_savedata.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_savedata.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_savedata.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_savedata.BorderRadius = 10;
            this.btn_savedata.BorderSize = 0;
            this.btn_savedata.FlatAppearance.BorderSize = 0;
            this.btn_savedata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savedata.ForeColor = System.Drawing.Color.White;
            this.btn_savedata.Location = new System.Drawing.Point(570, 279);
            this.btn_savedata.Name = "btn_savedata";
            this.btn_savedata.Size = new System.Drawing.Size(150, 40);
            this.btn_savedata.TabIndex = 16;
            this.btn_savedata.Text = "Add Data";
            this.btn_savedata.TextColor = System.Drawing.Color.White;
            this.btn_savedata.UseVisualStyleBackColor = false;
            this.btn_savedata.Click += new System.EventHandler(this.btn_savedata_Click);
            // 
            // list_point
            // 
            this.list_point.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_point.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.point,
            this.x,
            this.y,
            this.z,
            this.a});
            this.list_point.FullRowSelect = true;
            this.list_point.GridLines = true;
            this.list_point.HideSelection = false;
            this.list_point.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.list_point.LabelEdit = true;
            this.list_point.Location = new System.Drawing.Point(0, 23);
            this.list_point.Name = "list_point";
            this.list_point.Size = new System.Drawing.Size(526, 380);
            this.list_point.TabIndex = 7;
            this.list_point.UseCompatibleStateImageBehavior = false;
            this.list_point.View = System.Windows.Forms.View.Details;
            this.list_point.MouseClick += new System.Windows.Forms.MouseEventHandler(this.click_listview);
            // 
            // point
            // 
            this.point.Text = "Point";
            this.point.Width = 73;
            // 
            // x
            // 
            this.x.Text = "X";
            this.x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x.Width = 114;
            // 
            // y
            // 
            this.y.Text = "Y";
            this.y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.y.Width = 123;
            // 
            // z
            // 
            this.z.Text = "Z";
            this.z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.z.Width = 114;
            // 
            // a
            // 
            this.a.Text = "A";
            this.a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.a.Width = 120;
            // 
            // a_value
            // 
            this.a_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.a_value.DcimalDigits = 0;
            this.a_value.IsShowTips = true;
            this.a_value.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.a_value.LineWidth = 10F;
            this.a_value.Location = new System.Drawing.Point(567, 216);
            this.a_value.MaxValue = 18000F;
            this.a_value.MinValue = 2000F;
            this.a_value.Name = "a_value";
            this.a_value.Size = new System.Drawing.Size(352, 30);
            this.a_value.TabIndex = 6;
            this.a_value.Text = "ucTrackBar4";
            this.a_value.TipsFormat = null;
            this.a_value.Value = 2000F;
            this.a_value.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.a_value.MouseCaptureChanged += new System.EventHandler(this.mouseA_changed);
            // 
            // z_value
            // 
            this.z_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.z_value.DcimalDigits = 0;
            this.z_value.IsShowTips = true;
            this.z_value.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.z_value.LineWidth = 10F;
            this.z_value.Location = new System.Drawing.Point(567, 160);
            this.z_value.MaxValue = 19000F;
            this.z_value.MinValue = 2000F;
            this.z_value.Name = "z_value";
            this.z_value.Size = new System.Drawing.Size(352, 28);
            this.z_value.TabIndex = 5;
            this.z_value.Text = "ucTrackBar3";
            this.z_value.TipsFormat = null;
            this.z_value.Value = 2000F;
            this.z_value.ValueColor = System.Drawing.Color.Orange;
            this.z_value.MouseCaptureChanged += new System.EventHandler(this.mouse_z_changed);
            // 
            // y_value
            // 
            this.y_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.y_value.DcimalDigits = 0;
            this.y_value.IsShowTips = true;
            this.y_value.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.y_value.LineWidth = 10F;
            this.y_value.Location = new System.Drawing.Point(567, 100);
            this.y_value.MaxValue = 35000F;
            this.y_value.MinValue = 2000F;
            this.y_value.Name = "y_value";
            this.y_value.Size = new System.Drawing.Size(352, 27);
            this.y_value.TabIndex = 4;
            this.y_value.Text = "ucTrackBar2";
            this.y_value.TipsFormat = null;
            this.y_value.Value = 2000F;
            this.y_value.ValueColor = System.Drawing.Color.SpringGreen;
            this.y_value.MouseCaptureChanged += new System.EventHandler(this.mouse_y_changed);
            // 
            // x_value
            // 
            this.x_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.x_value.DcimalDigits = 0;
            this.x_value.IsShowTips = true;
            this.x_value.LineColor = System.Drawing.Color.Transparent;
            this.x_value.LineWidth = 10F;
            this.x_value.Location = new System.Drawing.Point(567, 42);
            this.x_value.MaxValue = 35000F;
            this.x_value.MinValue = 2000F;
            this.x_value.Name = "x_value";
            this.x_value.Size = new System.Drawing.Size(344, 27);
            this.x_value.TabIndex = 3;
            this.x_value.TipsFormat = null;
            this.x_value.Value = 2000F;
            this.x_value.ValueColor = System.Drawing.Color.DeepSkyBlue;
            this.x_value.MouseCaptureChanged += new System.EventHandler(this.mouse_x_changed);
            // 
            // about
            // 
            this.about.Controls.Add(this.pictureBox1);
            this.about.Controls.Add(this.linkLabel1);
            this.about.Controls.Add(this.label8);
            this.about.Controls.Add(this.label7);
            this.about.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.HorizontalScrollbarBarColor = true;
            this.about.HorizontalScrollbarHighlightOnWheel = false;
            this.about.HorizontalScrollbarSize = 20;
            this.about.Location = new System.Drawing.Point(4, 38);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(952, 397);
            this.about.TabIndex = 2;
            this.about.Text = "About me";
            this.about.VerticalScrollbarBarColor = true;
            this.about.VerticalScrollbarHighlightOnWheel = false;
            this.about.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(706, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(432, 278);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "access";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "This software design by HBHanoi";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(978, 147);
            this.label7.TabIndex = 2;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // newserial
            // 
            this.newserial.BaudRate = 115200;
            this.newserial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.UART_receive);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_lb_app});
            this.statusStrip1.Location = new System.Drawing.Point(20, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(920, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_lb_app
            // 
            this.status_lb_app.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.status_lb_app.Name = "status_lb_app";
            this.status_lb_app.Size = new System.Drawing.Size(39, 17);
            this.status_lb_app.Text = "Status";
            // 
            // controrl_arm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.control_tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "controrl_arm";
            this.Text = "CONTROL ROBOT SOFTWARE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closed_event);
            this.Load += new System.EventHandler(this.controrl_arm_Load);
            this.control_tab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.gr_run.ResumeLayout(false);
            this.tab_point.ResumeLayout(false);
            this.tab_point.PerformLayout();
            this.about.ResumeLayout(false);
            this.about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl control_tab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage tab_point;
        private System.Windows.Forms.RichTextBox rtb_code_rb;
        private MetroFramework.Controls.MetroTabPage about;
        private System.IO.Ports.SerialPort newserial;
        private MetroFramework.Controls.MetroComboBox cbb_name_port;
        private System.Windows.Forms.Label label1;
        private btn_custom btn_control_servor;
        private btn_custom btn_homeall;
        private btn_custom btn_stop;
        private btn_custom btn_custom1;
        private HZH_Controls.Controls.UCTrackBar a_value;
        private HZH_Controls.Controls.UCTrackBar z_value;
        private HZH_Controls.Controls.UCTrackBar y_value;
        private HZH_Controls.Controls.UCTrackBar x_value;
        private btn_custom btn_savedata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView list_point;
        private System.Windows.Forms.Label lb_notification;
        private System.Windows.Forms.TextBox tb_speed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_lb_app;
        private System.Windows.Forms.ColumnHeader point;
        public System.Windows.Forms.ColumnHeader x;
        public System.Windows.Forms.ColumnHeader y;
        public System.Windows.Forms.ColumnHeader z;
        public System.Windows.Forms.ColumnHeader a;
        private btn_custom btn_drag;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private btn_custom btn_connect_uart;
        private btn_custom btn_clr;
        private btn_custom btn_delete;
        private System.Windows.Forms.GroupBox gr_run;
        private System.Windows.Forms.TextBox tb_z_value;
        private System.Windows.Forms.TextBox tb_y_value;
        private System.Windows.Forms.TextBox tb_x_value;
        private System.Windows.Forms.TextBox tb_a_value;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Step;
    }
}

