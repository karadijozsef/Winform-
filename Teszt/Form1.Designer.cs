namespace Teszt
{
    partial class Form_Nyito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Nyito));
            this.azonosito = new System.Windows.Forms.Label();
            this.button_Udvozol = new System.Windows.Forms.Button();
            this.szul_ev = new System.Windows.Forms.Label();
            this.szul_datum = new System.Windows.Forms.DateTimePicker();
            this.azon_szam = new System.Windows.Forms.NumericUpDown();
            this.angol = new System.Windows.Forms.RadioButton();
            this.nemet = new System.Windows.Forms.RadioButton();
            this.francia = new System.Windows.Forms.RadioButton();
            this.olasz = new System.Windows.Forms.RadioButton();
            this.nyelv = new System.Windows.Forms.Label();
            this.szul_hely = new System.Windows.Forms.ComboBox();
            this.szulet_hely = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.Label();
            this.nev1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.azon_szam)).BeginInit();
            this.SuspendLayout();
            // 
            // azonosito
            // 
            this.azonosito.AutoSize = true;
            this.azonosito.Location = new System.Drawing.Point(82, 72);
            this.azonosito.Name = "azonosito";
            this.azonosito.Size = new System.Drawing.Size(58, 13);
            this.azonosito.TabIndex = 0;
            this.azonosito.Text = "Azonosító:";
            // 
            // button_Udvozol
            // 
            this.button_Udvozol.Location = new System.Drawing.Point(180, 385);
            this.button_Udvozol.Name = "button_Udvozol";
            this.button_Udvozol.Size = new System.Drawing.Size(125, 35);
            this.button_Udvozol.TabIndex = 2;
            this.button_Udvozol.Text = "Üdvözöl";
            this.button_Udvozol.UseVisualStyleBackColor = true;
            this.button_Udvozol.Click += new System.EventHandler(this.button_Udvozol_Click);
            // 
            // szul_ev
            // 
            this.szul_ev.AutoSize = true;
            this.szul_ev.Location = new System.Drawing.Point(82, 119);
            this.szul_ev.Name = "szul_ev";
            this.szul_ev.Size = new System.Drawing.Size(76, 13);
            this.szul_ev.TabIndex = 3;
            this.szul_ev.Text = "Születetési év:";
            // 
            // szul_datum
            // 
            this.szul_datum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.szul_datum.Location = new System.Drawing.Point(214, 113);
            this.szul_datum.MaxDate = new System.DateTime(2800, 12, 31, 0, 0, 0, 0);
            this.szul_datum.Name = "szul_datum";
            this.szul_datum.Size = new System.Drawing.Size(200, 20);
            this.szul_datum.TabIndex = 4;
            // 
            // azon_szam
            // 
            this.azon_szam.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.azon_szam.Location = new System.Drawing.Point(214, 65);
            this.azon_szam.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.azon_szam.Name = "azon_szam";
            this.azon_szam.Size = new System.Drawing.Size(120, 20);
            this.azon_szam.TabIndex = 12;
            this.azon_szam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // angol
            // 
            this.angol.AutoSize = true;
            this.angol.Location = new System.Drawing.Point(214, 221);
            this.angol.Name = "angol";
            this.angol.Size = new System.Drawing.Size(52, 17);
            this.angol.TabIndex = 13;
            this.angol.TabStop = true;
            this.angol.Text = "Angol";
            this.angol.UseVisualStyleBackColor = true;
            // 
            // nemet
            // 
            this.nemet.AutoSize = true;
            this.nemet.Location = new System.Drawing.Point(272, 221);
            this.nemet.Name = "nemet";
            this.nemet.Size = new System.Drawing.Size(56, 17);
            this.nemet.TabIndex = 14;
            this.nemet.TabStop = true;
            this.nemet.Text = "Német";
            this.nemet.UseVisualStyleBackColor = true;
            // 
            // francia
            // 
            this.francia.AutoSize = true;
            this.francia.Location = new System.Drawing.Point(391, 221);
            this.francia.Name = "francia";
            this.francia.Size = new System.Drawing.Size(60, 17);
            this.francia.TabIndex = 15;
            this.francia.TabStop = true;
            this.francia.Text = "Francia";
            this.francia.UseVisualStyleBackColor = true;
            // 
            // olasz
            // 
            this.olasz.AutoSize = true;
            this.olasz.Location = new System.Drawing.Point(334, 221);
            this.olasz.Name = "olasz";
            this.olasz.Size = new System.Drawing.Size(51, 17);
            this.olasz.TabIndex = 16;
            this.olasz.TabStop = true;
            this.olasz.Text = "Olasz";
            this.olasz.UseVisualStyleBackColor = true;
            // 
            // nyelv
            // 
            this.nyelv.AutoSize = true;
            this.nyelv.Location = new System.Drawing.Point(82, 225);
            this.nyelv.Name = "nyelv";
            this.nyelv.Size = new System.Drawing.Size(111, 13);
            this.nyelv.TabIndex = 17;
            this.nyelv.Text = "Beszélni kívánt nyelv:";
            // 
            // szul_hely
            // 
            this.szul_hely.FormattingEnabled = true;
            this.szul_hely.Items.AddRange(new object[] {
            "",
            "Budapest",
            "Debrecen",
            "Miskolc",
            "Szeged",
            "Békéscsaba",
            "Gyula",
            "Eger"});
            this.szul_hely.Location = new System.Drawing.Point(214, 163);
            this.szul_hely.Name = "szul_hely";
            this.szul_hely.Size = new System.Drawing.Size(121, 21);
            this.szul_hely.TabIndex = 18;
            // 
            // szulet_hely
            // 
            this.szulet_hely.AutoSize = true;
            this.szulet_hely.Location = new System.Drawing.Point(82, 171);
            this.szulet_hely.Name = "szulet_hely";
            this.szulet_hely.Size = new System.Drawing.Size(74, 13);
            this.szulet_hely.TabIndex = 19;
            this.szulet_hely.Text = "Születési hely:";
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Location = new System.Drawing.Point(82, 28);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(30, 13);
            this.nev.TabIndex = 20;
            this.nev.Text = "Név:";
            // 
            // nev1
            // 
            this.nev1.Location = new System.Drawing.Point(214, 25);
            this.nev1.Name = "nev1";
            this.nev1.Size = new System.Drawing.Size(100, 20);
            this.nev1.TabIndex = 21;
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(519, 469);
            this.Controls.Add(this.nev1);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.szulet_hely);
            this.Controls.Add(this.szul_hely);
            this.Controls.Add(this.nyelv);
            this.Controls.Add(this.olasz);
            this.Controls.Add(this.francia);
            this.Controls.Add(this.nemet);
            this.Controls.Add(this.angol);
            this.Controls.Add(this.azon_szam);
            this.Controls.Add(this.szul_datum);
            this.Controls.Add(this.szul_ev);
            this.Controls.Add(this.button_Udvozol);
            this.Controls.Add(this.azonosito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Nyito";
            this.Text = "Elso WinForm";
            ((System.ComponentModel.ISupportInitialize)(this.azon_szam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label azonosito;
        private System.Windows.Forms.Button button_Udvozol;
        private System.Windows.Forms.Label szul_ev;
        private System.Windows.Forms.DateTimePicker szul_datum;
        private System.Windows.Forms.NumericUpDown azon_szam;
        private System.Windows.Forms.RadioButton angol;
        private System.Windows.Forms.RadioButton nemet;
        private System.Windows.Forms.RadioButton francia;
        private System.Windows.Forms.RadioButton olasz;
        private System.Windows.Forms.Label nyelv;
        private System.Windows.Forms.ComboBox szul_hely;
        private System.Windows.Forms.Label szulet_hely;
        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.TextBox nev1;
    }
}

