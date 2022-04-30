namespace CapaPresentación
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtEsta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnAct = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(18, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(490, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(527, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNom.Location = new System.Drawing.Point(640, 34);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(180, 23);
            this.txtNom.TabIndex = 2;
            // 
            // txtEsta
            // 
            this.txtEsta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEsta.Location = new System.Drawing.Point(640, 178);
            this.txtEsta.Name = "txtEsta";
            this.txtEsta.Size = new System.Drawing.Size(180, 23);
            this.txtEsta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(527, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado";
            // 
            // txtCant
            // 
            this.txtCant.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCant.Location = new System.Drawing.Point(640, 141);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(180, 23);
            this.txtCant.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(527, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad";
            // 
            // txtPrec
            // 
            this.txtPrec.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrec.Location = new System.Drawing.Point(640, 104);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(180, 23);
            this.txtPrec.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(527, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Precio";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDesc.Location = new System.Drawing.Point(640, 69);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(180, 23);
            this.txtDesc.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(527, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descripcion";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.BtnGuardar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardar.Location = new System.Drawing.Point(601, 231);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(153, 39);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnAct
            // 
            this.BtnAct.BackColor = System.Drawing.Color.LemonChiffon;
            this.BtnAct.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAct.Location = new System.Drawing.Point(257, 276);
            this.BtnAct.Name = "BtnAct";
            this.BtnAct.Size = new System.Drawing.Size(114, 34);
            this.BtnAct.TabIndex = 16;
            this.BtnAct.Text = "Actualizar";
            this.BtnAct.UseVisualStyleBackColor = false;
            this.BtnAct.Click += new System.EventHandler(this.BtnAct_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.MistyRose;
            this.BtnEliminar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEliminar.Location = new System.Drawing.Point(394, 276);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(114, 35);
            this.BtnEliminar.TabIndex = 17;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCerrar.Location = new System.Drawing.Point(18, 276);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(114, 34);
            this.BtnCerrar.TabIndex = 18;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(843, 327);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAct);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEsta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtNom;
        private TextBox txtEsta;
        private Label label4;
        private TextBox txtCant;
        private Label label5;
        private TextBox txtPrec;
        private Label label6;
        private TextBox txtDesc;
        private Label label7;
        private Button BtnGuardar;
        private Button BtnAct;
        private Button BtnEliminar;
        private Button BtnCerrar;
    }
}