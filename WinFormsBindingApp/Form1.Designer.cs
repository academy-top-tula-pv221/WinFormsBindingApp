namespace WinFormsBindingApp
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
            txtSource = new TextBox();
            lblTarget = new Label();
            lblDateTarget = new Label();
            dateTimePicker = new DateTimePicker();
            txtUserName = new TextBox();
            btnUserNameChange = new Button();
            numUserAge = new NumericUpDown();
            btnViewUser = new Button();
            ((System.ComponentModel.ISupportInitialize)numUserAge).BeginInit();
            SuspendLayout();
            // 
            // txtSource
            // 
            txtSource.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtSource.Location = new Point(25, 45);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(303, 43);
            txtSource.TabIndex = 0;
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTarget.Location = new Point(470, 45);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(120, 37);
            lblTarget.TabIndex = 1;
            lblTarget.Text = "lblTarget";
            // 
            // lblDateTarget
            // 
            lblDateTarget.AutoSize = true;
            lblDateTarget.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateTarget.Location = new Point(470, 115);
            lblDateTarget.Name = "lblDateTarget";
            lblDateTarget.Size = new Size(176, 37);
            lblDateTarget.TabIndex = 2;
            lblDateTarget.Text = "lblDateTarget";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker.Location = new Point(25, 110);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(303, 43);
            dateTimePicker.TabIndex = 3;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(25, 205);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(303, 43);
            txtUserName.TabIndex = 4;
            // 
            // btnUserNameChange
            // 
            btnUserNameChange.Location = new Point(695, 408);
            btnUserNameChange.Name = "btnUserNameChange";
            btnUserNameChange.Size = new Size(93, 30);
            btnUserNameChange.TabIndex = 6;
            btnUserNameChange.Text = "User is Joe";
            btnUserNameChange.UseVisualStyleBackColor = true;
            btnUserNameChange.Click += btnUserNameChange_Click;
            // 
            // numUserAge
            // 
            numUserAge.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            numUserAge.Location = new Point(25, 254);
            numUserAge.Name = "numUserAge";
            numUserAge.Size = new Size(303, 43);
            numUserAge.TabIndex = 7;
            // 
            // btnViewUser
            // 
            btnViewUser.Location = new Point(470, 205);
            btnViewUser.Name = "btnViewUser";
            btnViewUser.Size = new Size(140, 43);
            btnViewUser.TabIndex = 8;
            btnViewUser.Text = "View User";
            btnViewUser.UseVisualStyleBackColor = true;
            btnViewUser.Click += btnViewUser_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewUser);
            Controls.Add(numUserAge);
            Controls.Add(btnUserNameChange);
            Controls.Add(txtUserName);
            Controls.Add(dateTimePicker);
            Controls.Add(lblDateTarget);
            Controls.Add(lblTarget);
            Controls.Add(txtSource);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numUserAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSource;
        private Label lblTarget;
        private Label lblDateTarget;
        private DateTimePicker dateTimePicker;
        private TextBox txtUserName;
        private Button btnUserNameChange;
        private NumericUpDown numUserAge;
        private Button btnViewUser;
    }
}