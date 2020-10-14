namespace Databasep
{
    partial class Display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.displayDataGrid = new System.Windows.Forms.DataGridView();
            this.btndisplay = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // displayDataGrid
            // 
            this.displayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGrid.Location = new System.Drawing.Point(47, 37);
            this.displayDataGrid.Name = "displayDataGrid";
            this.displayDataGrid.Size = new System.Drawing.Size(802, 346);
            this.displayDataGrid.TabIndex = 0;
            this.displayDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayDataGrid_CellContentClick);
            // 
            // btndisplay
            // 
            this.btndisplay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btndisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btndisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndisplay.BorderRadius = 0;
            this.btndisplay.ButtonText = "Display";
            this.btndisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndisplay.DisabledColor = System.Drawing.Color.Gray;
            this.btndisplay.Iconcolor = System.Drawing.Color.Transparent;
            this.btndisplay.Iconimage = ((System.Drawing.Image)(resources.GetObject("btndisplay.Iconimage")));
            this.btndisplay.Iconimage_right = null;
            this.btndisplay.Iconimage_right_Selected = null;
            this.btndisplay.Iconimage_Selected = null;
            this.btndisplay.IconMarginLeft = 0;
            this.btndisplay.IconMarginRight = 0;
            this.btndisplay.IconRightVisible = true;
            this.btndisplay.IconRightZoom = 0D;
            this.btndisplay.IconVisible = true;
            this.btndisplay.IconZoom = 90D;
            this.btndisplay.IsTab = false;
            this.btndisplay.Location = new System.Drawing.Point(400, -4);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btndisplay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btndisplay.OnHoverTextColor = System.Drawing.Color.White;
            this.btndisplay.selected = false;
            this.btndisplay.Size = new System.Drawing.Size(120, 35);
            this.btndisplay.TabIndex = 3;
            this.btndisplay.Text = "Display";
            this.btndisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndisplay.Textcolor = System.Drawing.Color.White;
            this.btndisplay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(861, 385);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.displayDataGrid);
            this.Name = "Display";
            this.Text = "Display";
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView displayDataGrid;
        private Bunifu.Framework.UI.BunifuFlatButton btndisplay;
    }
}