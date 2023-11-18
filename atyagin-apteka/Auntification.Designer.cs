
namespace matyagin_apteka
{
    partial class Auntification
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCapha = new System.Windows.Forms.TextBox();
            this.pictureCapcha = new System.Windows.Forms.PictureBox();
            this.labelCapcha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapcha)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(87, 111);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(179, 25);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(87, 152);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(179, 25);
            this.textBoxPassword.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(182)))), ((int)(((byte)(84)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(62, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // pictureIcon
            // 
            this.pictureIcon.Image = global::atyagin_apteka.Properties.Resources.loltip;
            this.pictureIcon.Location = new System.Drawing.Point(12, 9);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(90, 87);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIcon.TabIndex = 5;
            this.pictureIcon.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(126, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "РУП \"Фармация\"";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textCapha
            // 
            this.textCapha.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCapha.Location = new System.Drawing.Point(62, 340);
            this.textCapha.Name = "textCapha";
            this.textCapha.Size = new System.Drawing.Size(185, 25);
            this.textCapha.TabIndex = 7;
            this.textCapha.Visible = false;
            // 
            // pictureCapcha
            // 
            this.pictureCapcha.Location = new System.Drawing.Point(62, 226);
            this.pictureCapcha.Name = "pictureCapcha";
            this.pictureCapcha.Size = new System.Drawing.Size(185, 98);
            this.pictureCapcha.TabIndex = 8;
            this.pictureCapcha.TabStop = false;
            this.pictureCapcha.Visible = false;
            // 
            // labelCapcha
            // 
            this.labelCapcha.AutoSize = true;
            this.labelCapcha.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapcha.Location = new System.Drawing.Point(93, 203);
            this.labelCapcha.Name = "labelCapcha";
            this.labelCapcha.Size = new System.Drawing.Size(123, 20);
            this.labelCapcha.TabIndex = 9;
            this.labelCapcha.Text = "Выпишите символы";
            this.labelCapcha.Visible = false;
            // 
            // Auntification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(244)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(314, 456);
            this.Controls.Add(this.labelCapcha);
            this.Controls.Add(this.pictureCapcha);
            this.Controls.Add(this.textCapha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureIcon);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Auntification";
            this.Text = "Аптечный склад \"Фармация\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCapha;
        private System.Windows.Forms.PictureBox pictureCapcha;
        private System.Windows.Forms.Label labelCapcha;
    }
}

