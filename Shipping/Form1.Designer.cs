namespace Shipping
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
            button1 = new Button();
            tabControl1 = new TabControl();
            Ship = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Cargo = new TabPage();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            Shipment = new TabPage();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            dataGridView3 = new DataGridView();
            Запросы = new TabPage();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            dataGridView4 = new DataGridView();
            tabControl1.SuspendLayout();
            Ship.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Cargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Shipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            Запросы.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(549, 16);
            button1.Name = "button1";
            button1.Size = new Size(181, 43);
            button1.TabIndex = 0;
            button1.Text = "Загрузить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Ship);
            tabControl1.Controls.Add(Cargo);
            tabControl1.Controls.Add(Shipment);
            tabControl1.Controls.Add(Запросы);
            tabControl1.Location = new Point(1, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1015, 418);
            tabControl1.TabIndex = 2;
            // 
            // Ship
            // 
            Ship.Controls.Add(button4);
            Ship.Controls.Add(button3);
            Ship.Controls.Add(button2);
            Ship.Controls.Add(dataGridView1);
            Ship.Location = new Point(4, 29);
            Ship.Name = "Ship";
            Ship.Padding = new Padding(3);
            Ship.Size = new Size(1007, 385);
            Ship.TabIndex = 0;
            Ship.Text = "Ship";
            Ship.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(885, 146);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(885, 86);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Обновить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(885, 26);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(860, 385);
            dataGridView1.TabIndex = 0;
            // 
            // Cargo
            // 
            Cargo.Controls.Add(button7);
            Cargo.Controls.Add(button6);
            Cargo.Controls.Add(button5);
            Cargo.Controls.Add(dataGridView2);
            Cargo.Location = new Point(4, 29);
            Cargo.Name = "Cargo";
            Cargo.Padding = new Padding(3);
            Cargo.Size = new Size(1007, 385);
            Cargo.TabIndex = 1;
            Cargo.Text = "Cargo";
            Cargo.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(885, 86);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 3;
            button7.Text = "Обновить";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(885, 146);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 2;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(885, 26);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 1;
            button5.Text = "Добавить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(-4, 1);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(860, 385);
            dataGridView2.TabIndex = 0;
            // 
            // Shipment
            // 
            Shipment.Controls.Add(button10);
            Shipment.Controls.Add(button9);
            Shipment.Controls.Add(button8);
            Shipment.Controls.Add(dataGridView3);
            Shipment.Location = new Point(4, 29);
            Shipment.Name = "Shipment";
            Shipment.Size = new Size(1007, 385);
            Shipment.TabIndex = 2;
            Shipment.Text = "Shipment";
            Shipment.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(885, 146);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 3;
            button10.Text = "Удалить";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(885, 86);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 2;
            button9.Text = "Обновить";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(885, 26);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 1;
            button8.Text = "Добавить";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 1);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(860, 385);
            dataGridView3.TabIndex = 0;
            // 
            // Запросы
            // 
            Запросы.Controls.Add(button13);
            Запросы.Controls.Add(button12);
            Запросы.Controls.Add(button11);
            Запросы.Controls.Add(dataGridView4);
            Запросы.Location = new Point(4, 29);
            Запросы.Name = "Запросы";
            Запросы.Size = new Size(1007, 385);
            Запросы.TabIndex = 3;
            Запросы.Text = "Запросы";
            Запросы.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(796, 149);
            button13.Name = "button13";
            button13.Size = new Size(184, 59);
            button13.TabIndex = 3;
            button13.Text = "600 < DeclareValue < 900";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Location = new Point(796, 90);
            button12.Name = "button12";
            button12.Size = new Size(184, 29);
            button12.TabIndex = 2;
            button12.Text = "Cargo Origin1";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(796, 16);
            button11.Name = "button11";
            button11.Size = new Size(184, 42);
            button11.TabIndex = 1;
            button11.Text = "Ship Capacity > 250";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(3, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.Size = new Size(775, 385);
            dataGridView4.TabIndex = 0;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 455);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            Ship.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Cargo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Shipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            Запросы.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TabControl tabControl1;
        private TabPage Ship;
        private DataGridView dataGridView1;
        private TabPage Cargo;
        private TabPage Shipment;
        private TabPage Запросы;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button10;
        private Button button9;
        private Button button8;
        private DataGridView dataGridView4;
        private Button button11;
        private Button button12;
        private Button button13;
    }
}