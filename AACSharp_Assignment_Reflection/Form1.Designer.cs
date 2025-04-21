namespace AACSharp_Assignment_Reflection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            lbl_path = new Label();
            selectFolder = new Button();
            tabPage2 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            lbl_result = new Label();
            btn_pay = new Button();
            txt_price = new TextBox();
            cb_payType = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(lbl_path);
            tabPage1.Controls.Add(selectFolder);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ListBox";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(17, 51);
            listView1.Name = "listView1";
            listView1.Size = new Size(731, 288);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // lbl_path
            // 
            lbl_path.AutoSize = true;
            lbl_path.Location = new Point(28, 20);
            lbl_path.Name = "lbl_path";
            lbl_path.Size = new Size(40, 15);
            lbl_path.TabIndex = 2;
            lbl_path.Text = "Path : ";
            // 
            // selectFolder
            // 
            selectFolder.Location = new Point(255, 345);
            selectFolder.Name = "selectFolder";
            selectFolder.Size = new Size(252, 36);
            selectFolder.TabIndex = 1;
            selectFolder.Text = "Klasör Seç";
            selectFolder.UseVisualStyleBackColor = true;
            selectFolder.Click += selectFolder_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(lbl_result);
            tabPage2.Controls.Add(btn_pay);
            tabPage2.Controls.Add(txt_price);
            tabPage2.Controls.Add(cb_payType);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ödeme Sistemi";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 119);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 5;
            label2.Text = "Fiyat giriniz : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 40);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 4;
            label1.Text = "Ödeme yöntemi seçiniz : ";
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Location = new Point(260, 252);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(0, 15);
            lbl_result.TabIndex = 3;
            lbl_result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_pay
            // 
            btn_pay.Location = new Point(260, 182);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(257, 39);
            btn_pay.TabIndex = 2;
            btn_pay.Text = "Öde";
            btn_pay.UseVisualStyleBackColor = true;
            btn_pay.Click += btn_pay_Click;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(260, 116);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(257, 23);
            txt_price.TabIndex = 1;
            // 
            // cb_payType
            // 
            cb_payType.FormattingEnabled = true;
            cb_payType.Location = new Point(260, 37);
            cb_payType.Name = "cb_payType";
            cb_payType.Size = new Size(257, 23);
            cb_payType.TabIndex = 0;
            cb_payType.SelectedIndexChanged += cb_payType_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button selectFolder;
        private Label lbl_path;
        private ListView listView1;
        private ImageList imageList1;
        private Label lbl_result;
        private Button btn_pay;
        private TextBox txt_price;
        private ComboBox cb_payType;
        private Label label1;
        private Label label2;
    }
}
