﻿namespace Databasep
{
    partial class Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password));
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtcnfrmpass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtoldpass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtuserid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.brnAddUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Change Password";
            // 
            // txtpass
            // 
            this.txtpass.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtpass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpass.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtpass.BorderThickness = 3;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpass.isPassword = true;
            this.txtpass.Location = new System.Drawing.Point(136, 150);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(218, 29);
            this.txtpass.TabIndex = 20;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(32, 166);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(78, 13);
            this.bunifuCustomLabel4.TabIndex = 19;
            this.bunifuCustomLabel4.Text = "New Password";
            // 
            // txtcnfrmpass
            // 
            this.txtcnfrmpass.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtcnfrmpass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcnfrmpass.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtcnfrmpass.BorderThickness = 3;
            this.txtcnfrmpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcnfrmpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcnfrmpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcnfrmpass.isPassword = true;
            this.txtcnfrmpass.Location = new System.Drawing.Point(136, 198);
            this.txtcnfrmpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtcnfrmpass.Name = "txtcnfrmpass";
            this.txtcnfrmpass.Size = new System.Drawing.Size(218, 29);
            this.txtcnfrmpass.TabIndex = 18;
            this.txtcnfrmpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(13, 214);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(116, 13);
            this.bunifuCustomLabel3.TabIndex = 17;
            this.bunifuCustomLabel3.Text = "Confirm New Password";
            // 
            // txtoldpass
            // 
            this.txtoldpass.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtoldpass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtoldpass.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtoldpass.BorderThickness = 3;
            this.txtoldpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtoldpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtoldpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtoldpass.isPassword = true;
            this.txtoldpass.Location = new System.Drawing.Point(136, 102);
            this.txtoldpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtoldpass.Name = "txtoldpass";
            this.txtoldpass.Size = new System.Drawing.Size(218, 29);
            this.txtoldpass.TabIndex = 16;
            this.txtoldpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 118);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(72, 13);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "Old Password";
            // 
            // txtuserid
            // 
            this.txtuserid.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtuserid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtuserid.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtuserid.BorderThickness = 3;
            this.txtuserid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuserid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtuserid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtuserid.isPassword = false;
            this.txtuserid.Location = new System.Drawing.Point(136, 56);
            this.txtuserid.Margin = new System.Windows.Forms.Padding(4);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(218, 29);
            this.txtuserid.TabIndex = 14;
            this.txtuserid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(32, 67);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(43, 13);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "User ID";
            // 
            // cancel
            // 
            this.cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.BorderRadius = 0;
            this.cancel.ButtonText = "Cancel";
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.DisabledColor = System.Drawing.Color.Gray;
            this.cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.cancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("cancel.Iconimage")));
            this.cancel.Iconimage_right = null;
            this.cancel.Iconimage_right_Selected = null;
            this.cancel.Iconimage_Selected = null;
            this.cancel.IconMarginLeft = 0;
            this.cancel.IconMarginRight = 0;
            this.cancel.IconRightVisible = true;
            this.cancel.IconRightZoom = 0D;
            this.cancel.IconVisible = true;
            this.cancel.IconZoom = 90D;
            this.cancel.IsTab = false;
            this.cancel.Location = new System.Drawing.Point(260, 253);
            this.cancel.Name = "cancel";
            this.cancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.cancel.selected = false;
            this.cancel.Size = new System.Drawing.Size(94, 36);
            this.cancel.TabIndex = 22;
            this.cancel.Text = "Cancel";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.Textcolor = System.Drawing.Color.White;
            this.cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // brnAddUser
            // 
            this.brnAddUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.brnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.brnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brnAddUser.BorderRadius = 0;
            this.brnAddUser.ButtonText = "Ok";
            this.brnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnAddUser.DisabledColor = System.Drawing.Color.Gray;
            this.brnAddUser.Iconcolor = System.Drawing.Color.Transparent;
            this.brnAddUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("brnAddUser.Iconimage")));
            this.brnAddUser.Iconimage_right = null;
            this.brnAddUser.Iconimage_right_Selected = null;
            this.brnAddUser.Iconimage_Selected = null;
            this.brnAddUser.IconMarginLeft = 0;
            this.brnAddUser.IconMarginRight = 0;
            this.brnAddUser.IconRightVisible = true;
            this.brnAddUser.IconRightZoom = 0D;
            this.brnAddUser.IconVisible = true;
            this.brnAddUser.IconZoom = 90D;
            this.brnAddUser.IsTab = false;
            this.brnAddUser.Location = new System.Drawing.Point(136, 253);
            this.brnAddUser.Name = "brnAddUser";
            this.brnAddUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.brnAddUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.brnAddUser.OnHoverTextColor = System.Drawing.Color.White;
            this.brnAddUser.selected = false;
            this.brnAddUser.Size = new System.Drawing.Size(106, 36);
            this.brnAddUser.TabIndex = 21;
            this.brnAddUser.Text = "Ok";
            this.brnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnAddUser.Textcolor = System.Drawing.Color.White;
            this.brnAddUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnAddUser.Click += new System.EventHandler(this.brnAddUser_Click);
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 329);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.brnAddUser);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txtcnfrmpass);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtoldpass);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Change_Password";
            this.Text = "New Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtpass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcnfrmpass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtoldpass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtuserid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton cancel;
        private Bunifu.Framework.UI.BunifuFlatButton brnAddUser;
    }
}