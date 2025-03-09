namespace To_Do_List
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
            label1 = new Label();
            textBoxTask = new TextBox();
            pictureBoxAdd = new PictureBox();
            listBox1 = new ListBox();
            pictureBoxComplete = new PictureBox();
            pictureBoxDelete = new PictureBox();
            pictureBoxUp = new PictureBox();
            pictureBoxDown = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxComplete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 45);
            label1.TabIndex = 0;
            label1.Text = "To Do";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = Color.Gray;
            textBoxTask.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxTask.ForeColor = Color.WhiteSmoke;
            textBoxTask.Location = new Point(42, 69);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(190, 34);
            textBoxTask.TabIndex = 1;
            textBoxTask.Text = "Enter new task";
            // 
            // pictureBoxAdd
            // 
            pictureBoxAdd.Image = Properties.Resources.add;
            pictureBoxAdd.Location = new Point(238, 69);
            pictureBoxAdd.Name = "pictureBoxAdd";
            pictureBoxAdd.Size = new Size(38, 34);
            pictureBoxAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAdd.TabIndex = 2;
            pictureBoxAdd.TabStop = false;
            pictureBoxAdd.Click += pictureBoxAdd_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Gray;
            listBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(42, 123);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(234, 304);
            listBox1.TabIndex = 3;
            // 
            // pictureBoxComplete
            // 
            pictureBoxComplete.Image = Properties.Resources.complete;
            pictureBoxComplete.Location = new Point(307, 172);
            pictureBoxComplete.Name = "pictureBoxComplete";
            pictureBoxComplete.Size = new Size(48, 43);
            pictureBoxComplete.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxComplete.TabIndex = 4;
            pictureBoxComplete.TabStop = false;
            pictureBoxComplete.Click += pictureBoxComplete_Click;
            // 
            // pictureBoxDelete
            // 
            pictureBoxDelete.Image = Properties.Resources.delete;
            pictureBoxDelete.Location = new Point(307, 221);
            pictureBoxDelete.Name = "pictureBoxDelete";
            pictureBoxDelete.Size = new Size(48, 43);
            pictureBoxDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDelete.TabIndex = 5;
            pictureBoxDelete.TabStop = false;
            pictureBoxDelete.Click += pictureBoxDelete_Click;
            // 
            // pictureBoxUp
            // 
            pictureBoxUp.Image = Properties.Resources.up;
            pictureBoxUp.Location = new Point(307, 270);
            pictureBoxUp.Name = "pictureBoxUp";
            pictureBoxUp.Size = new Size(48, 43);
            pictureBoxUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUp.TabIndex = 6;
            pictureBoxUp.TabStop = false;
            pictureBoxUp.Click += pictureBoxUp_Click;
            // 
            // pictureBoxDown
            // 
            pictureBoxDown.Image = Properties.Resources.down;
            pictureBoxDown.Location = new Point(307, 319);
            pictureBoxDown.Name = "pictureBoxDown";
            pictureBoxDown.Size = new Size(48, 43);
            pictureBoxDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDown.TabIndex = 7;
            pictureBoxDown.TabStop = false;
            pictureBoxDown.Click += pictureBoxDown_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(377, 457);
            Controls.Add(pictureBoxDown);
            Controls.Add(pictureBoxUp);
            Controls.Add(pictureBoxDelete);
            Controls.Add(pictureBoxComplete);
            Controls.Add(listBox1);
            Controls.Add(pictureBoxAdd);
            Controls.Add(textBoxTask);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxComplete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTask;
        private PictureBox pictureBoxAdd;
        private ListBox listBox1;
        private PictureBox pictureBoxComplete;
        private PictureBox pictureBoxDelete;
        private PictureBox pictureBoxUp;
        private PictureBox pictureBoxDown;
    }
}
