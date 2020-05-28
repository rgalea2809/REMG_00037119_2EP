using System.ComponentModel;

namespace Hugo
{
    partial class adminWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminWF));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ordersbtn = new System.Windows.Forms.Button();
            this.productbtn = new System.Windows.Forms.Button();
            this.businessbtn = new System.Windows.Forms.Button();
            this.usersrBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (55)))), ((int) (((byte) (28)))), ((int) (((byte) (95)))));
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.ordersbtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.productbtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.businessbtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.usersrBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ordersbtn
            // 
            this.ordersbtn.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersbtn.AutoSize = true;
            this.ordersbtn.BackColor = System.Drawing.Color.White;
            this.ordersbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))), ((int) (((byte) (192)))));
            this.ordersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ordersbtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ordersbtn.Location = new System.Drawing.Point(605, 5);
            this.ordersbtn.Margin = new System.Windows.Forms.Padding(5);
            this.ordersbtn.Name = "ordersbtn";
            this.ordersbtn.Size = new System.Drawing.Size(190, 35);
            this.ordersbtn.TabIndex = 3;
            this.ordersbtn.Text = "ORDENES";
            this.ordersbtn.UseVisualStyleBackColor = false;
            this.ordersbtn.Click += new System.EventHandler(this.ordersbtn_Click);
            // 
            // productbtn
            // 
            this.productbtn.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.productbtn.AutoSize = true;
            this.productbtn.BackColor = System.Drawing.Color.White;
            this.productbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))), ((int) (((byte) (192)))));
            this.productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productbtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.productbtn.Location = new System.Drawing.Point(405, 5);
            this.productbtn.Margin = new System.Windows.Forms.Padding(5);
            this.productbtn.Name = "productbtn";
            this.productbtn.Size = new System.Drawing.Size(190, 35);
            this.productbtn.TabIndex = 2;
            this.productbtn.Text = "PRODUCTOS";
            this.productbtn.UseVisualStyleBackColor = false;
            this.productbtn.Click += new System.EventHandler(this.productbtn_Click);
            // 
            // businessbtn
            // 
            this.businessbtn.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.businessbtn.AutoSize = true;
            this.businessbtn.BackColor = System.Drawing.Color.White;
            this.businessbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))), ((int) (((byte) (192)))));
            this.businessbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.businessbtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.businessbtn.Location = new System.Drawing.Point(205, 5);
            this.businessbtn.Margin = new System.Windows.Forms.Padding(5);
            this.businessbtn.Name = "businessbtn";
            this.businessbtn.Size = new System.Drawing.Size(190, 35);
            this.businessbtn.TabIndex = 1;
            this.businessbtn.Text = "NEGOCIOS";
            this.businessbtn.UseVisualStyleBackColor = false;
            this.businessbtn.Click += new System.EventHandler(this.businessbtn_Click);
            // 
            // usersrBtn
            // 
            this.usersrBtn.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.usersrBtn.AutoSize = true;
            this.usersrBtn.BackColor = System.Drawing.Color.White;
            this.usersrBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))), ((int) (((byte) (192)))));
            this.usersrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usersrBtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.usersrBtn.Location = new System.Drawing.Point(5, 5);
            this.usersrBtn.Margin = new System.Windows.Forms.Padding(5);
            this.usersrBtn.Name = "usersrBtn";
            this.usersrBtn.Size = new System.Drawing.Size(190, 35);
            this.usersrBtn.TabIndex = 0;
            this.usersrBtn.Text = "USUARIOS";
            this.usersrBtn.UseVisualStyleBackColor = false;
            this.usersrBtn.Click += new System.EventHandler(this.usersrBtn_Click);
            // 
            // adminWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "adminWF";
            this.Text = "Administrador";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button businessbtn;
        private System.Windows.Forms.Button ordersbtn;
        private System.Windows.Forms.Button productbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button usersrBtn;

        #endregion
    }
}