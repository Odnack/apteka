
namespace matyagin_apteka
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.foundMedicine = new System.Windows.Forms.Button();
            this.newApplications = new System.Windows.Forms.Button();
            this.userApplications = new System.Windows.Forms.Button();
            this.editProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foundMedicine
            // 
            this.foundMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(182)))), ((int)(((byte)(84)))));
            this.foundMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foundMedicine.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundMedicine.Location = new System.Drawing.Point(63, 114);
            this.foundMedicine.Name = "foundMedicine";
            this.foundMedicine.Size = new System.Drawing.Size(185, 43);
            this.foundMedicine.TabIndex = 2;
            this.foundMedicine.Text = "Найти лекарство";
            this.foundMedicine.UseVisualStyleBackColor = false;
            this.foundMedicine.Click += new System.EventHandler(this.button1_Click);
            // 
            // newApplications
            // 
            this.newApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(182)))), ((int)(((byte)(84)))));
            this.newApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newApplications.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newApplications.Location = new System.Drawing.Point(63, 173);
            this.newApplications.Name = "newApplications";
            this.newApplications.Size = new System.Drawing.Size(185, 43);
            this.newApplications.TabIndex = 3;
            this.newApplications.Text = "Создать заявку";
            this.newApplications.UseVisualStyleBackColor = false;
            this.newApplications.Click += new System.EventHandler(this.newApplications_Click);
            // 
            // userApplications
            // 
            this.userApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(182)))), ((int)(((byte)(84)))));
            this.userApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userApplications.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userApplications.Location = new System.Drawing.Point(63, 231);
            this.userApplications.Name = "userApplications";
            this.userApplications.Size = new System.Drawing.Size(185, 43);
            this.userApplications.TabIndex = 4;
            this.userApplications.Text = "Ваши заявки";
            this.userApplications.UseVisualStyleBackColor = false;
            // 
            // editProfile
            // 
            this.editProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(182)))), ((int)(((byte)(84)))));
            this.editProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProfile.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfile.Location = new System.Drawing.Point(63, 291);
            this.editProfile.Name = "editProfile";
            this.editProfile.Size = new System.Drawing.Size(185, 43);
            this.editProfile.TabIndex = 5;
            this.editProfile.Text = "Редактировать профиль";
            this.editProfile.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(244)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(312, 456);
            this.Controls.Add(this.editProfile);
            this.Controls.Add(this.userApplications);
            this.Controls.Add(this.newApplications);
            this.Controls.Add(this.foundMedicine);
            this.Name = "MainForm";
            this.Text = "Аптечный склад \"Фармация\"";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button foundMedicine;
        private System.Windows.Forms.Button newApplications;
        private System.Windows.Forms.Button userApplications;
        private System.Windows.Forms.Button editProfile;
    }
}

