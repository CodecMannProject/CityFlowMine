namespace CityFlow
{
    partial class MainForm
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
            label1 = new Label();
            routesListBox = new ListBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            routeNumberTextBox = new TextBox();
            startStopTextBox = new TextBox();
            endStopTextBox = new TextBox();
            addRouteButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 38);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Маршрути";
            // 
            // routesListBox
            // 
            routesListBox.FormattingEnabled = true;
            routesListBox.ItemHeight = 15;
            routesListBox.Location = new Point(86, 67);
            routesListBox.Name = "routesListBox";
            routesListBox.Size = new Size(291, 229);
            routesListBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addRouteButton);
            groupBox1.Controls.Add(endStopTextBox);
            groupBox1.Controls.Add(startStopTextBox);
            groupBox1.Controls.Add(routeNumberTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(404, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 229);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Новий маршрут";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 26);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 0;
            label2.Text = "Номер маршруту";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 80);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 1;
            label3.Text = "Початок маршруту";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 133);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 2;
            label4.Text = "Кінець маршруту";
            // 
            // routeNumberTextBox
            // 
            routeNumberTextBox.Location = new Point(237, 26);
            routeNumberTextBox.Name = "routeNumberTextBox";
            routeNumberTextBox.Size = new Size(100, 23);
            routeNumberTextBox.TabIndex = 3;
            routeNumberTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // startStopTextBox
            // 
            startStopTextBox.Location = new Point(237, 77);
            startStopTextBox.Name = "startStopTextBox";
            startStopTextBox.Size = new Size(100, 23);
            startStopTextBox.TabIndex = 4;
            startStopTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // endStopTextBox
            // 
            endStopTextBox.Location = new Point(237, 130);
            endStopTextBox.Name = "endStopTextBox";
            endStopTextBox.Size = new Size(100, 23);
            endStopTextBox.TabIndex = 5;
            endStopTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // addRouteButton
            // 
            addRouteButton.Location = new Point(24, 179);
            addRouteButton.Name = "addRouteButton";
            addRouteButton.Size = new Size(144, 28);
            addRouteButton.TabIndex = 6;
            addRouteButton.Text = "Додати маршрут";
            addRouteButton.UseVisualStyleBackColor = true;
            addRouteButton.Click += addRouteButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(routesListBox);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox routesListBox;
        private GroupBox groupBox1;
        private TextBox endStopTextBox;
        private TextBox startStopTextBox;
        private TextBox routeNumberTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button addRouteButton;
    }
}
