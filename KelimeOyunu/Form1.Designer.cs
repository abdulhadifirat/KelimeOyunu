namespace KelimeOyunu
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
            btnSec = new Button();
            flwSehir = new FlowLayoutPanel();
            flwAlfabe = new FlowLayoutPanel();
            lblHak = new Label();
            lblDogru = new Label();
            SuspendLayout();
            // 
            // btnSec
            // 
            btnSec.Location = new Point(12, 12);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(291, 58);
            btnSec.TabIndex = 0;
            btnSec.Text = "Kelime Seç ve Başla";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // flwSehir
            // 
            flwSehir.Location = new Point(12, 86);
            flwSehir.Name = "flwSehir";
            flwSehir.Size = new Size(824, 117);
            flwSehir.TabIndex = 1;
            // 
            // flwAlfabe
            // 
            flwAlfabe.Location = new Point(12, 209);
            flwAlfabe.Name = "flwAlfabe";
            flwAlfabe.Size = new Size(824, 229);
            flwAlfabe.TabIndex = 2;
            // 
            // lblHak
            // 
            lblHak.Location = new Point(380, 12);
            lblHak.Name = "lblHak";
            lblHak.Size = new Size(127, 42);
            lblHak.TabIndex = 3;
            lblHak.Text = "Kalan Hak Sayısı";
            // 
            // lblDogru
            // 
            lblDogru.Location = new Point(616, 12);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(118, 42);
            lblDogru.TabIndex = 4;
            lblDogru.Text = "Doğru Sayısı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 471);
            Controls.Add(lblDogru);
            Controls.Add(lblHak);
            Controls.Add(flwAlfabe);
            Controls.Add(flwSehir);
            Controls.Add(btnSec);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSec;
        private FlowLayoutPanel flwSehir;
        private FlowLayoutPanel flwAlfabe;
        private Label lblHak;
        private Label lblDogru;
    }
}
