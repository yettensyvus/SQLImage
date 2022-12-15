namespace SQLImage
{
    partial class SQLImage
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
            this.pic_data = new System.Windows.Forms.PictureBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_browse = new System.Windows.Forms.Button();
            this.pic_load_data = new System.Windows.Forms.PictureBox();
            this.btn_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_load_data)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_data
            // 
            this.pic_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_data.Location = new System.Drawing.Point(36, 38);
            this.pic_data.Name = "pic_data";
            this.pic_data.Size = new System.Drawing.Size(166, 176);
            this.pic_data.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_data.TabIndex = 90;
            this.pic_data.TabStop = false;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_insert.FlatAppearance.BorderSize = 0;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.Location = new System.Drawing.Point(128, 233);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(74, 27);
            this.btn_insert.TabIndex = 93;
            this.btn_insert.Text = "Insert";
            this.btn_insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_browse.FlatAppearance.BorderSize = 0;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_browse.Location = new System.Drawing.Point(36, 233);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(74, 27);
            this.btn_browse.TabIndex = 92;
            this.btn_browse.Text = "Browse";
            this.btn_browse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // pic_load_data
            // 
            this.pic_load_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_load_data.Location = new System.Drawing.Point(287, 38);
            this.pic_load_data.Name = "pic_load_data";
            this.pic_load_data.Size = new System.Drawing.Size(166, 176);
            this.pic_load_data.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_load_data.TabIndex = 94;
            this.pic_load_data.TabStop = false;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_load.FlatAppearance.BorderSize = 0;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_load.Location = new System.Drawing.Point(287, 233);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(166, 27);
            this.btn_load.TabIndex = 95;
            this.btn_load.Text = "Load";
            this.btn_load.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // SQLImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(501, 303);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.pic_load_data);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.pic_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SQLImage";
            ((System.ComponentModel.ISupportInitialize)(this.pic_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_load_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox pic_data;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_browse;
        internal System.Windows.Forms.PictureBox pic_load_data;
        private System.Windows.Forms.Button btn_load;
    }
}

