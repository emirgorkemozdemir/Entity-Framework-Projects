namespace Entity_FrameWork_Form
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtboxad = new System.Windows.Forms.TextBox();
            this.txtboxyazar = new System.Windows.Forms.TextBox();
            this.txtboxyayınevi = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtboxindex = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtboxad
            // 
            this.txtboxad.Location = new System.Drawing.Point(23, 203);
            this.txtboxad.Name = "txtboxad";
            this.txtboxad.Size = new System.Drawing.Size(159, 20);
            this.txtboxad.TabIndex = 1;
            // 
            // txtboxyazar
            // 
            this.txtboxyazar.Location = new System.Drawing.Point(23, 238);
            this.txtboxyazar.Name = "txtboxyazar";
            this.txtboxyazar.Size = new System.Drawing.Size(159, 20);
            this.txtboxyazar.TabIndex = 2;
            // 
            // txtboxyayınevi
            // 
            this.txtboxyayınevi.Location = new System.Drawing.Point(23, 274);
            this.txtboxyayınevi.Name = "txtboxyayınevi";
            this.txtboxyayınevi.Size = new System.Drawing.Size(159, 20);
            this.txtboxyayınevi.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(269, 181);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(60, 42);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Ekle";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(269, 238);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(60, 42);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Sil";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtboxindex
            // 
            this.txtboxindex.Location = new System.Drawing.Point(23, 168);
            this.txtboxindex.Name = "txtboxindex";
            this.txtboxindex.Size = new System.Drawing.Size(159, 20);
            this.txtboxindex.TabIndex = 6;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(370, 181);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(60, 42);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(510, 340);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtboxindex);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtboxyayınevi);
            this.Controls.Add(this.txtboxyazar);
            this.Controls.Add(this.txtboxad);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtboxad;
        private System.Windows.Forms.TextBox txtboxyazar;
        private System.Windows.Forms.TextBox txtboxyayınevi;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtboxindex;
        private System.Windows.Forms.Button btnupdate;
    }
}

