namespace Groen__Dierenpark_Abonnement
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbPersoonlijk = new System.Windows.Forms.RadioButton();
            this.dateTimePickerPersoonlijk = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEchtpaar1 = new System.Windows.Forms.DateTimePicker();
            this.rbEchtpaar = new System.Windows.Forms.RadioButton();
            this.dateTimePickerEchtpaar2 = new System.Windows.Forms.DateTimePicker();
            this.rbGezin = new System.Windows.Forms.RadioButton();
            this.nudAantalKinderen = new System.Windows.Forms.NumericUpDown();
            this.labelAantalKinderen = new System.Windows.Forms.Label();
            this.bBereken = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.labelAbonnment = new System.Windows.Forms.Label();
            this.labelPrijs = new System.Windows.Forms.Label();
            this.labelPersoonlijk1 = new System.Windows.Forms.Label();
            this.labelEchtpaar1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalKinderen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecteer uw abonnement";
            // 
            // rbPersoonlijk
            // 
            this.rbPersoonlijk.AutoSize = true;
            this.rbPersoonlijk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPersoonlijk.Location = new System.Drawing.Point(17, 55);
            this.rbPersoonlijk.Name = "rbPersoonlijk";
            this.rbPersoonlijk.Size = new System.Drawing.Size(103, 24);
            this.rbPersoonlijk.TabIndex = 1;
            this.rbPersoonlijk.TabStop = true;
            this.rbPersoonlijk.Text = "Persoonlijk";
            this.rbPersoonlijk.UseVisualStyleBackColor = true;
            this.rbPersoonlijk.Click += new System.EventHandler(this.rbPersoonlijk_Click);
            // 
            // dateTimePickerPersoonlijk
            // 
            this.dateTimePickerPersoonlijk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPersoonlijk.Location = new System.Drawing.Point(17, 101);
            this.dateTimePickerPersoonlijk.Name = "dateTimePickerPersoonlijk";
            this.dateTimePickerPersoonlijk.Size = new System.Drawing.Size(258, 26);
            this.dateTimePickerPersoonlijk.TabIndex = 2;
            // 
            // dateTimePickerEchtpaar1
            // 
            this.dateTimePickerEchtpaar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEchtpaar1.Location = new System.Drawing.Point(15, 196);
            this.dateTimePickerEchtpaar1.Name = "dateTimePickerEchtpaar1";
            this.dateTimePickerEchtpaar1.Size = new System.Drawing.Size(258, 26);
            this.dateTimePickerEchtpaar1.TabIndex = 4;
            // 
            // rbEchtpaar
            // 
            this.rbEchtpaar.AutoSize = true;
            this.rbEchtpaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEchtpaar.Location = new System.Drawing.Point(17, 150);
            this.rbEchtpaar.Name = "rbEchtpaar";
            this.rbEchtpaar.Size = new System.Drawing.Size(92, 24);
            this.rbEchtpaar.TabIndex = 3;
            this.rbEchtpaar.TabStop = true;
            this.rbEchtpaar.Text = "Echtpaar";
            this.rbEchtpaar.UseVisualStyleBackColor = true;
            this.rbEchtpaar.Click += new System.EventHandler(this.rbEchtpaar_Click);
            // 
            // dateTimePickerEchtpaar2
            // 
            this.dateTimePickerEchtpaar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEchtpaar2.Location = new System.Drawing.Point(15, 228);
            this.dateTimePickerEchtpaar2.Name = "dateTimePickerEchtpaar2";
            this.dateTimePickerEchtpaar2.Size = new System.Drawing.Size(258, 26);
            this.dateTimePickerEchtpaar2.TabIndex = 5;
            // 
            // rbGezin
            // 
            this.rbGezin.AutoSize = true;
            this.rbGezin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGezin.Location = new System.Drawing.Point(15, 279);
            this.rbGezin.Name = "rbGezin";
            this.rbGezin.Size = new System.Drawing.Size(69, 24);
            this.rbGezin.TabIndex = 6;
            this.rbGezin.TabStop = true;
            this.rbGezin.Text = "Gezin";
            this.rbGezin.UseVisualStyleBackColor = true;
            this.rbGezin.Click += new System.EventHandler(this.rbGezin_Click);
            // 
            // nudAantalKinderen
            // 
            this.nudAantalKinderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAantalKinderen.Location = new System.Drawing.Point(15, 325);
            this.nudAantalKinderen.Name = "nudAantalKinderen";
            this.nudAantalKinderen.Size = new System.Drawing.Size(120, 26);
            this.nudAantalKinderen.TabIndex = 7;
            // 
            // labelAantalKinderen
            // 
            this.labelAantalKinderen.AutoSize = true;
            this.labelAantalKinderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAantalKinderen.Location = new System.Drawing.Point(12, 306);
            this.labelAantalKinderen.Name = "labelAantalKinderen";
            this.labelAantalKinderen.Size = new System.Drawing.Size(104, 16);
            this.labelAantalKinderen.TabIndex = 8;
            this.labelAantalKinderen.Text = "Aantal kinderen:";
            // 
            // bBereken
            // 
            this.bBereken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBereken.Location = new System.Drawing.Point(15, 374);
            this.bBereken.Name = "bBereken";
            this.bBereken.Size = new System.Drawing.Size(92, 33);
            this.bBereken.TabIndex = 9;
            this.bBereken.Text = "Bereken";
            this.bBereken.UseVisualStyleBackColor = true;
            this.bBereken.Click += new System.EventHandler(this.bBereken_Click);
            // 
            // bReset
            // 
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(181, 374);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(92, 33);
            this.bReset.TabIndex = 10;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // labelAbonnment
            // 
            this.labelAbonnment.AutoSize = true;
            this.labelAbonnment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbonnment.Location = new System.Drawing.Point(11, 429);
            this.labelAbonnment.Name = "labelAbonnment";
            this.labelAbonnment.Size = new System.Drawing.Size(153, 24);
            this.labelAbonnment.TabIndex = 11;
            this.labelAbonnment.Text = "Abonnment prijs:";
            // 
            // labelPrijs
            // 
            this.labelPrijs.AutoSize = true;
            this.labelPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrijs.Location = new System.Drawing.Point(177, 429);
            this.labelPrijs.Name = "labelPrijs";
            this.labelPrijs.Size = new System.Drawing.Size(80, 24);
            this.labelPrijs.TabIndex = 12;
            this.labelPrijs.Text = "€ 100,00";
            // 
            // labelPersoonlijk1
            // 
            this.labelPersoonlijk1.AutoSize = true;
            this.labelPersoonlijk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersoonlijk1.Location = new System.Drawing.Point(14, 82);
            this.labelPersoonlijk1.Name = "labelPersoonlijk1";
            this.labelPersoonlijk1.Size = new System.Drawing.Size(154, 16);
            this.labelPersoonlijk1.TabIndex = 13;
            this.labelPersoonlijk1.Text = "Vul uw geboortedatum in";
            // 
            // labelEchtpaar1
            // 
            this.labelEchtpaar1.AutoSize = true;
            this.labelEchtpaar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEchtpaar1.ForeColor = System.Drawing.Color.Black;
            this.labelEchtpaar1.Location = new System.Drawing.Point(14, 177);
            this.labelEchtpaar1.Name = "labelEchtpaar1";
            this.labelEchtpaar1.Size = new System.Drawing.Size(161, 16);
            this.labelEchtpaar1.TabIndex = 14;
            this.labelEchtpaar1.Text = "Vul uw geboortedatums in";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 484);
            this.Controls.Add(this.labelEchtpaar1);
            this.Controls.Add(this.labelPersoonlijk1);
            this.Controls.Add(this.labelPrijs);
            this.Controls.Add(this.labelAbonnment);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bBereken);
            this.Controls.Add(this.labelAantalKinderen);
            this.Controls.Add(this.nudAantalKinderen);
            this.Controls.Add(this.rbGezin);
            this.Controls.Add(this.dateTimePickerEchtpaar2);
            this.Controls.Add(this.dateTimePickerEchtpaar1);
            this.Controls.Add(this.rbEchtpaar);
            this.Controls.Add(this.dateTimePickerPersoonlijk);
            this.Controls.Add(this.rbPersoonlijk);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalKinderen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPersoonlijk;
        private System.Windows.Forms.DateTimePicker dateTimePickerPersoonlijk;
        private System.Windows.Forms.DateTimePicker dateTimePickerEchtpaar1;
        private System.Windows.Forms.RadioButton rbEchtpaar;
        private System.Windows.Forms.DateTimePicker dateTimePickerEchtpaar2;
        private System.Windows.Forms.RadioButton rbGezin;
        private System.Windows.Forms.NumericUpDown nudAantalKinderen;
        private System.Windows.Forms.Label labelAantalKinderen;
        private System.Windows.Forms.Button bBereken;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label labelAbonnment;
        private System.Windows.Forms.Label labelPrijs;
        private System.Windows.Forms.Label labelPersoonlijk1;
        private System.Windows.Forms.Label labelEchtpaar1;
    }
}

