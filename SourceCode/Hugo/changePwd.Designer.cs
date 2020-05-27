using System.ComponentModel;

namespace Hugo
{
    partial class changePwd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePwd));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usersCombobox = new System.Windows.Forms.ComboBox();
            this.passwordActual = new System.Windows.Forms.TextBox();
            this.passwordnueva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.actualizarPwd = new System.Windows.Forms.Button();
            this.returnHomebtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (55)))), ((int) (((byte) (28)))), ((int) (((byte) (95)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.usersCombobox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.passwordActual, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.passwordnueva, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.actualizarPwd, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.returnHomebtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Location = new System.Drawing.Point(203, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 69);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usersCombobox
            // 
            this.usersCombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usersCombobox.FormattingEnabled = true;
            this.usersCombobox.Location = new System.Drawing.Point(382, 147);
            this.usersCombobox.Name = "usersCombobox";
            this.usersCombobox.Size = new System.Drawing.Size(157, 24);
            this.usersCombobox.TabIndex = 1;
            // 
            // passwordActual
            // 
            this.passwordActual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordActual.Location = new System.Drawing.Point(381, 220);
            this.passwordActual.Name = "passwordActual";
            this.passwordActual.Size = new System.Drawing.Size(158, 22);
            this.passwordActual.TabIndex = 2;
            this.passwordActual.UseSystemPasswordChar = true;
            // 
            // passwordnueva
            // 
            this.passwordnueva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordnueva.Location = new System.Drawing.Point(381, 290);
            this.passwordnueva.Name = "passwordnueva";
            this.passwordnueva.Size = new System.Drawing.Size(158, 22);
            this.passwordnueva.TabIndex = 3;
            this.passwordnueva.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 70);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña actual:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña nueva:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // actualizarPwd
            // 
            this.actualizarPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actualizarPwd.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.actualizarPwd, 2);
            this.actualizarPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizarPwd.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.actualizarPwd.ForeColor = System.Drawing.Color.White;
            this.actualizarPwd.Location = new System.Drawing.Point(283, 342);
            this.actualizarPwd.Name = "actualizarPwd";
            this.actualizarPwd.Size = new System.Drawing.Size(234, 32);
            this.actualizarPwd.TabIndex = 7;
            this.actualizarPwd.Text = "Actualizar Contraseña";
            this.actualizarPwd.UseVisualStyleBackColor = false;
            this.actualizarPwd.Click += new System.EventHandler(this.actualizarPwd_Click);
            // 
            // returnHomebtn
            // 
            this.returnHomebtn.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.returnHomebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (55)))), ((int) (((byte) (28)))), ((int) (((byte) (95)))));
            this.returnHomebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnHomebtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.returnHomebtn.ForeColor = System.Drawing.Color.White;
            this.returnHomebtn.Location = new System.Drawing.Point(3, 55);
            this.returnHomebtn.Name = "returnHomebtn";
            this.returnHomebtn.Size = new System.Drawing.Size(146, 69);
            this.returnHomebtn.TabIndex = 8;
            this.returnHomebtn.Text = "<= REGRESAR";
            this.returnHomebtn.UseVisualStyleBackColor = true;
            this.returnHomebtn.Click += new System.EventHandler(this.returnHomebtn_Click);
            // 
            // changePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "changePwd";
            this.Text = "changePwd";
            this.Load += new System.EventHandler(this.changePwd_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button actualizarPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordActual;
        private System.Windows.Forms.TextBox passwordnueva;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button returnHomebtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox usersCombobox;

        #endregion
    }
}