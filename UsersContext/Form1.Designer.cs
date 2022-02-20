
namespace UsersContext
{
    partial class Form1
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
            this.username_Label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gender_other = new System.Windows.Forms.RadioButton();
            this.gender_female = new System.Windows.Forms.RadioButton();
            this.gender_male = new System.Windows.Forms.RadioButton();
            this.gender_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_Label
            // 
            this.username_Label.AutoSize = true;
            this.username_Label.Location = new System.Drawing.Point(12, 74);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(55, 13);
            this.username_Label.TabIndex = 0;
            this.username_Label.Text = "Username";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(12, 111);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(12, 148);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(73, 71);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(219, 20);
            this.username_text.TabIndex = 2;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(73, 148);
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '*';
            this.password_text.Size = new System.Drawing.Size(219, 20);
            this.password_text.TabIndex = 4;
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(73, 111);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(219, 20);
            this.name_text.TabIndex = 3;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(85, 266);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 10;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(166, 266);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 11;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_form);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gender_other);
            this.panel1.Controls.Add(this.gender_female);
            this.panel1.Controls.Add(this.gender_male);
            this.panel1.Location = new System.Drawing.Point(73, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 46);
            this.panel1.TabIndex = 5;
            // 
            // gender_other
            // 
            this.gender_other.AutoSize = true;
            this.gender_other.Location = new System.Drawing.Point(155, 17);
            this.gender_other.Name = "gender_other";
            this.gender_other.Size = new System.Drawing.Size(51, 17);
            this.gender_other.TabIndex = 7;
            this.gender_other.TabStop = true;
            this.gender_other.Text = "Other";
            this.gender_other.UseVisualStyleBackColor = true;
            this.gender_other.CheckedChanged += new System.EventHandler(this.gender_CheckedChanged);
            // 
            // gender_female
            // 
            this.gender_female.AutoSize = true;
            this.gender_female.Location = new System.Drawing.Point(77, 17);
            this.gender_female.Name = "gender_female";
            this.gender_female.Size = new System.Drawing.Size(59, 17);
            this.gender_female.TabIndex = 6;
            this.gender_female.TabStop = true;
            this.gender_female.Text = "Female";
            this.gender_female.UseVisualStyleBackColor = true;
            this.gender_female.CheckedChanged += new System.EventHandler(this.gender_CheckedChanged);
            // 
            // gender_male
            // 
            this.gender_male.AutoSize = true;
            this.gender_male.Location = new System.Drawing.Point(12, 17);
            this.gender_male.Name = "gender_male";
            this.gender_male.Size = new System.Drawing.Size(48, 17);
            this.gender_male.TabIndex = 5;
            this.gender_male.TabStop = true;
            this.gender_male.Text = "Male";
            this.gender_male.UseVisualStyleBackColor = true;
            this.gender_male.CheckedChanged += new System.EventHandler(this.gender_CheckedChanged);
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Location = new System.Drawing.Point(12, 195);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(42, 13);
            this.gender_label.TabIndex = 11;
            this.gender_label.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // id_text
            // 
            this.id_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_text.Location = new System.Drawing.Point(73, 32);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(219, 20);
            this.id_text.TabIndex = 1;
            this.id_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(166, 237);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(85, 237);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 8;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(317, 332);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.username_Label);
            this.Name = "Form1";
            this.Text = "Crud Operations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_Label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton gender_female;
        private System.Windows.Forms.RadioButton gender_male;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.RadioButton gender_other;
    }
}
