namespace CompoletTest.WinForms
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nxCompolet1 = new OMRON.Compolet.CIP.NXCompolet(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.In00label = new System.Windows.Forms.Label();
            this.In01label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Out00label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Out01label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Out09label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Out08label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Out11label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Out10label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Out13label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Out12label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.In03label = new System.Windows.Forms.Label();
            this.In02label = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.In05label = new System.Windows.Forms.Label();
            this.In04label = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.In06label = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Fromlabel = new System.Windows.Forms.Label();
            this.Tolabel = new System.Windows.Forms.Label();
            this.ToAnslabel = new System.Windows.Forms.Label();
            this.FromAnslabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.LDConnectlabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.NXConnectlabel = new System.Windows.Forms.Label();
            this.In16label = new System.Windows.Forms.Label();
            this.In17label = new System.Windows.Forms.Label();
            this.In18label = new System.Windows.Forms.Label();
            this.In19label = new System.Windows.Forms.Label();
            this.In23label = new System.Windows.Forms.Label();
            this.In22label = new System.Windows.Forms.Label();
            this.In21label = new System.Windows.Forms.Label();
            this.In20label = new System.Windows.Forms.Label();
            this.In31label = new System.Windows.Forms.Label();
            this.In30label = new System.Windows.Forms.Label();
            this.In29label = new System.Windows.Forms.Label();
            this.In28label = new System.Windows.Forms.Label();
            this.In27label = new System.Windows.Forms.Label();
            this.In26label = new System.Windows.Forms.Label();
            this.In25label = new System.Windows.Forms.Label();
            this.In24label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nxCompolet1
            // 
            this.nxCompolet1.Active = false;
            this.nxCompolet1.ConnectionType = OMRON.Compolet.CIP.ConnectionType.UCMM;
            this.nxCompolet1.DontFragment = false;
            this.nxCompolet1.HeartBeatTimer = 0;
            this.nxCompolet1.LocalPort = 2;
            this.nxCompolet1.PeerAddress = "200.1.61.12";
            this.nxCompolet1.ReceiveTimeLimit = ((long)(750));
            this.nxCompolet1.RoutePath = "";
            this.nxCompolet1.UseRoutePath = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // In00label
            // 
            this.In00label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In00label.Location = new System.Drawing.Point(254, 43);
            this.In00label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In00label.Name = "In00label";
            this.In00label.Size = new System.Drawing.Size(16, 17);
            this.In00label.TabIndex = 0;
            // 
            // In01label
            // 
            this.In01label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In01label.Location = new System.Drawing.Point(254, 68);
            this.In01label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In01label.Name = "In01label";
            this.In01label.Size = new System.Drawing.Size(16, 17);
            this.In01label.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "移載可";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(251, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "TM→LD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "移載中";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "LD→TM";
            // 
            // Out00label
            // 
            this.Out00label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Out00label.Location = new System.Drawing.Point(13, 43);
            this.Out00label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Out00label.Name = "Out00label";
            this.Out00label.Size = new System.Drawing.Size(16, 17);
            this.Out00label.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "移載要求";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "開始要求";
            // 
            // Out01label
            // 
            this.Out01label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Out01label.Location = new System.Drawing.Point(13, 68);
            this.Out01label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Out01label.Name = "Out01label";
            this.Out01label.Size = new System.Drawing.Size(16, 17);
            this.Out01label.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stage2";
            // 
            // Out09label
            // 
            this.Out09label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Out09label.Location = new System.Drawing.Point(118, 67);
            this.Out09label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Out09label.Name = "Out09label";
            this.Out09label.Size = new System.Drawing.Size(16, 17);
            this.Out09label.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Stage1";
            // 
            // Out08label
            // 
            this.Out08label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Out08label.Location = new System.Drawing.Point(118, 42);
            this.Out08label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Out08label.Name = "Out08label";
            this.Out08label.Size = new System.Drawing.Size(16, 17);
            this.Out08label.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Stage4";
            // 
            // Out11label
            // 
            this.Out11label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Out11label.Location = new System.Drawing.Point(118, 120);
            this.Out11label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Out11label.Name = "Out11label";
            this.Out11label.Size = new System.Drawing.Size(16, 17);
            this.Out11label.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 97);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Stage3";
            // 
            // Out10label
            // 
            this.Out10label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Out10label.Location = new System.Drawing.Point(118, 95);
            this.Out10label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Out10label.Name = "Out10label";
            this.Out10label.Size = new System.Drawing.Size(16, 17);
            this.Out10label.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 175);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Stage6";
            // 
            // Out13label
            // 
            this.Out13label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Out13label.Location = new System.Drawing.Point(118, 173);
            this.Out13label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Out13label.Name = "Out13label";
            this.Out13label.Size = new System.Drawing.Size(16, 17);
            this.Out13label.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 150);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "Stage5";
            // 
            // Out12label
            // 
            this.Out12label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Out12label.Location = new System.Drawing.Point(118, 148);
            this.Out12label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Out12label.Name = "Out12label";
            this.Out12label.Size = new System.Drawing.Size(16, 17);
            this.Out12label.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(278, 120);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "棚移載中";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(278, 95);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "モバイル移載中";
            // 
            // In03label
            // 
            this.In03label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In03label.Location = new System.Drawing.Point(254, 118);
            this.In03label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In03label.Name = "In03label";
            this.In03label.Size = new System.Drawing.Size(16, 17);
            this.In03label.TabIndex = 23;
            // 
            // In02label
            // 
            this.In02label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In02label.Location = new System.Drawing.Point(254, 93);
            this.In02label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In02label.Name = "In02label";
            this.In02label.Size = new System.Drawing.Size(16, 17);
            this.In02label.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(278, 173);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "移載一時停止中";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(278, 148);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "移載完了";
            // 
            // In05label
            // 
            this.In05label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In05label.Location = new System.Drawing.Point(254, 172);
            this.In05label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In05label.Name = "In05label";
            this.In05label.Size = new System.Drawing.Size(16, 17);
            this.In05label.TabIndex = 27;
            // 
            // In04label
            // 
            this.In04label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In04label.Location = new System.Drawing.Point(254, 147);
            this.In04label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In04label.Name = "In04label";
            this.In04label.Size = new System.Drawing.Size(16, 17);
            this.In04label.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(278, 202);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 31;
            this.label17.Text = "非常停止";
            // 
            // In06label
            // 
            this.In06label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In06label.Location = new System.Drawing.Point(254, 200);
            this.In06label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In06label.Name = "In06label";
            this.In06label.Size = new System.Drawing.Size(16, 17);
            this.In06label.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 243);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 15);
            this.label18.TabIndex = 32;
            this.label18.Text = "From";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 269);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 15);
            this.label19.TabIndex = 33;
            this.label19.Text = "To";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(252, 269);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 15);
            this.label20.TabIndex = 35;
            this.label20.Text = "To";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(252, 243);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 15);
            this.label21.TabIndex = 34;
            this.label21.Text = "From";
            // 
            // Fromlabel
            // 
            this.Fromlabel.AutoSize = true;
            this.Fromlabel.Location = new System.Drawing.Point(74, 243);
            this.Fromlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fromlabel.Name = "Fromlabel";
            this.Fromlabel.Size = new System.Drawing.Size(28, 15);
            this.Fromlabel.TabIndex = 36;
            this.Fromlabel.Text = "xxx";
            // 
            // Tolabel
            // 
            this.Tolabel.AutoSize = true;
            this.Tolabel.Location = new System.Drawing.Point(74, 269);
            this.Tolabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tolabel.Name = "Tolabel";
            this.Tolabel.Size = new System.Drawing.Size(28, 15);
            this.Tolabel.TabIndex = 37;
            this.Tolabel.Text = "xxx";
            // 
            // ToAnslabel
            // 
            this.ToAnslabel.AutoSize = true;
            this.ToAnslabel.Location = new System.Drawing.Point(327, 269);
            this.ToAnslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToAnslabel.Name = "ToAnslabel";
            this.ToAnslabel.Size = new System.Drawing.Size(28, 15);
            this.ToAnslabel.TabIndex = 39;
            this.ToAnslabel.Text = "xxx";
            // 
            // FromAnslabel
            // 
            this.FromAnslabel.AutoSize = true;
            this.FromAnslabel.Location = new System.Drawing.Point(327, 243);
            this.FromAnslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FromAnslabel.Name = "FromAnslabel";
            this.FromAnslabel.Size = new System.Drawing.Size(28, 15);
            this.FromAnslabel.TabIndex = 38;
            this.FromAnslabel.Text = "xxx";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(34, 305);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 15);
            this.label22.TabIndex = 41;
            this.label22.Text = "メモリ共有";
            // 
            // LDConnectlabel
            // 
            this.LDConnectlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LDConnectlabel.Location = new System.Drawing.Point(13, 303);
            this.LDConnectlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDConnectlabel.Name = "LDConnectlabel";
            this.LDConnectlabel.Size = new System.Drawing.Size(16, 17);
            this.LDConnectlabel.TabIndex = 40;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(275, 305);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 15);
            this.label23.TabIndex = 43;
            this.label23.Text = "NX接続";
            // 
            // NXConnectlabel
            // 
            this.NXConnectlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NXConnectlabel.Location = new System.Drawing.Point(254, 303);
            this.NXConnectlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NXConnectlabel.Name = "NXConnectlabel";
            this.NXConnectlabel.Size = new System.Drawing.Size(16, 17);
            this.NXConnectlabel.TabIndex = 42;
            // 
            // In16label
            // 
            this.In16label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In16label.Location = new System.Drawing.Point(406, 42);
            this.In16label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In16label.Name = "In16label";
            this.In16label.Size = new System.Drawing.Size(16, 17);
            this.In16label.TabIndex = 44;
            // 
            // In17label
            // 
            this.In17label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In17label.Location = new System.Drawing.Point(427, 42);
            this.In17label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In17label.Name = "In17label";
            this.In17label.Size = new System.Drawing.Size(16, 17);
            this.In17label.TabIndex = 45;
            // 
            // In18label
            // 
            this.In18label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In18label.Location = new System.Drawing.Point(448, 42);
            this.In18label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In18label.Name = "In18label";
            this.In18label.Size = new System.Drawing.Size(16, 17);
            this.In18label.TabIndex = 46;
            // 
            // In19label
            // 
            this.In19label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In19label.Location = new System.Drawing.Point(469, 42);
            this.In19label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In19label.Name = "In19label";
            this.In19label.Size = new System.Drawing.Size(16, 17);
            this.In19label.TabIndex = 47;
            // 
            // In23label
            // 
            this.In23label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In23label.Location = new System.Drawing.Point(469, 67);
            this.In23label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In23label.Name = "In23label";
            this.In23label.Size = new System.Drawing.Size(16, 17);
            this.In23label.TabIndex = 51;
            // 
            // In22label
            // 
            this.In22label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In22label.Location = new System.Drawing.Point(448, 67);
            this.In22label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In22label.Name = "In22label";
            this.In22label.Size = new System.Drawing.Size(16, 17);
            this.In22label.TabIndex = 50;
            // 
            // In21label
            // 
            this.In21label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In21label.Location = new System.Drawing.Point(427, 67);
            this.In21label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In21label.Name = "In21label";
            this.In21label.Size = new System.Drawing.Size(16, 17);
            this.In21label.TabIndex = 49;
            // 
            // In20label
            // 
            this.In20label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In20label.Location = new System.Drawing.Point(406, 67);
            this.In20label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In20label.Name = "In20label";
            this.In20label.Size = new System.Drawing.Size(16, 17);
            this.In20label.TabIndex = 48;
            // 
            // In31label
            // 
            this.In31label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In31label.Location = new System.Drawing.Point(469, 118);
            this.In31label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In31label.Name = "In31label";
            this.In31label.Size = new System.Drawing.Size(16, 17);
            this.In31label.TabIndex = 59;
            // 
            // In30label
            // 
            this.In30label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In30label.Location = new System.Drawing.Point(448, 118);
            this.In30label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In30label.Name = "In30label";
            this.In30label.Size = new System.Drawing.Size(16, 17);
            this.In30label.TabIndex = 58;
            // 
            // In29label
            // 
            this.In29label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In29label.Location = new System.Drawing.Point(427, 118);
            this.In29label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In29label.Name = "In29label";
            this.In29label.Size = new System.Drawing.Size(16, 17);
            this.In29label.TabIndex = 57;
            // 
            // In28label
            // 
            this.In28label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In28label.Location = new System.Drawing.Point(406, 118);
            this.In28label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In28label.Name = "In28label";
            this.In28label.Size = new System.Drawing.Size(16, 17);
            this.In28label.TabIndex = 56;
            // 
            // In27label
            // 
            this.In27label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In27label.Location = new System.Drawing.Point(469, 93);
            this.In27label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In27label.Name = "In27label";
            this.In27label.Size = new System.Drawing.Size(16, 17);
            this.In27label.TabIndex = 55;
            // 
            // In26label
            // 
            this.In26label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In26label.Location = new System.Drawing.Point(448, 93);
            this.In26label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In26label.Name = "In26label";
            this.In26label.Size = new System.Drawing.Size(16, 17);
            this.In26label.TabIndex = 54;
            // 
            // In25label
            // 
            this.In25label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In25label.Location = new System.Drawing.Point(427, 93);
            this.In25label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In25label.Name = "In25label";
            this.In25label.Size = new System.Drawing.Size(16, 17);
            this.In25label.TabIndex = 53;
            // 
            // In24label
            // 
            this.In24label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.In24label.Location = new System.Drawing.Point(406, 93);
            this.In24label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.In24label.Name = "In24label";
            this.In24label.Size = new System.Drawing.Size(16, 17);
            this.In24label.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 327);
            this.Controls.Add(this.In31label);
            this.Controls.Add(this.In30label);
            this.Controls.Add(this.In29label);
            this.Controls.Add(this.In28label);
            this.Controls.Add(this.In27label);
            this.Controls.Add(this.In26label);
            this.Controls.Add(this.In25label);
            this.Controls.Add(this.In24label);
            this.Controls.Add(this.In23label);
            this.Controls.Add(this.In22label);
            this.Controls.Add(this.In21label);
            this.Controls.Add(this.In20label);
            this.Controls.Add(this.In19label);
            this.Controls.Add(this.In18label);
            this.Controls.Add(this.In17label);
            this.Controls.Add(this.In16label);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.NXConnectlabel);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.LDConnectlabel);
            this.Controls.Add(this.ToAnslabel);
            this.Controls.Add(this.FromAnslabel);
            this.Controls.Add(this.Tolabel);
            this.Controls.Add(this.Fromlabel);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.In06label);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.In05label);
            this.Controls.Add(this.In04label);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.In03label);
            this.Controls.Add(this.In02label);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Out13label);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Out12label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Out11label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Out10label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Out09label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Out08label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Out01label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Out00label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.In01label);
            this.Controls.Add(this.In00label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "CIP TEST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OMRON.Compolet.CIP.NXCompolet nxCompolet1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label In00label;
        private System.Windows.Forms.Label In01label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Out00label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Out01label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Out09label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Out08label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Out11label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Out10label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Out13label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Out12label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label In03label;
        private System.Windows.Forms.Label In02label;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label In05label;
        private System.Windows.Forms.Label In04label;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label In06label;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label Fromlabel;
        private System.Windows.Forms.Label Tolabel;
        private System.Windows.Forms.Label ToAnslabel;
        private System.Windows.Forms.Label FromAnslabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label LDConnectlabel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label NXConnectlabel;
        private System.Windows.Forms.Label In16label;
        private System.Windows.Forms.Label In17label;
        private System.Windows.Forms.Label In18label;
        private System.Windows.Forms.Label In19label;
        private System.Windows.Forms.Label In23label;
        private System.Windows.Forms.Label In22label;
        private System.Windows.Forms.Label In21label;
        private System.Windows.Forms.Label In20label;
        private System.Windows.Forms.Label In31label;
        private System.Windows.Forms.Label In30label;
        private System.Windows.Forms.Label In29label;
        private System.Windows.Forms.Label In28label;
        private System.Windows.Forms.Label In27label;
        private System.Windows.Forms.Label In26label;
        private System.Windows.Forms.Label In25label;
        private System.Windows.Forms.Label In24label;
    }
}

