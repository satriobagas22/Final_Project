namespace WindowsFormsApp2
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
            this.panelUtama = new System.Windows.Forms.Panel();
            this.flowDrinks = new System.Windows.Forms.FlowLayoutPanel();
            this.flowFoods = new System.Windows.Forms.FlowLayoutPanel();
            this.segment2 = new System.Windows.Forms.Label();
            this.segment1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.namacafe = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelTagihan = new System.Windows.Forms.Label();
            this.labelBarang = new System.Windows.Forms.Label();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.panelUtama.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUtama
            // 
            this.panelUtama.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelUtama.Controls.Add(this.flowDrinks);
            this.panelUtama.Controls.Add(this.flowFoods);
            this.panelUtama.Controls.Add(this.segment2);
            this.panelUtama.Controls.Add(this.segment1);
            this.panelUtama.Controls.Add(this.panelHeader);
            this.panelUtama.Controls.Add(this.panelFooter);
            this.panelUtama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUtama.Location = new System.Drawing.Point(0, 0);
            this.panelUtama.Name = "panelUtama";
            this.panelUtama.Size = new System.Drawing.Size(359, 628);
            this.panelUtama.TabIndex = 0;
            // 
            // flowDrinks
            // 
            this.flowDrinks.AutoScroll = true;
            this.flowDrinks.Location = new System.Drawing.Point(-1, 353);
            this.flowDrinks.Name = "flowDrinks";
            this.flowDrinks.Size = new System.Drawing.Size(362, 164);
            this.flowDrinks.TabIndex = 6;
            this.flowDrinks.WrapContents = false;
            // 
            // flowFoods
            // 
            this.flowFoods.AutoScroll = true;
            this.flowFoods.Location = new System.Drawing.Point(0, 131);
            this.flowFoods.Name = "flowFoods";
            this.flowFoods.Size = new System.Drawing.Size(359, 161);
            this.flowFoods.TabIndex = 5;
            this.flowFoods.WrapContents = false;
            // 
            // segment2
            // 
            this.segment2.AutoSize = true;
            this.segment2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.segment2.Font = new System.Drawing.Font("Sans Serif Collection", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segment2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.segment2.Location = new System.Drawing.Point(4, 284);
            this.segment2.Name = "segment2";
            this.segment2.Size = new System.Drawing.Size(144, 91);
            this.segment2.TabIndex = 3;
            this.segment2.Text = "DRINKS";
            // 
            // segment1
            // 
            this.segment1.AutoSize = true;
            this.segment1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.segment1.Font = new System.Drawing.Font("Sans Serif Collection", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segment1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.segment1.Location = new System.Drawing.Point(5, 75);
            this.segment1.Name = "segment1";
            this.segment1.Size = new System.Drawing.Size(135, 91);
            this.segment1.TabIndex = 2;
            this.segment1.Text = "FOODS";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelHeader.Controls.Add(this.namacafe);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(359, 74);
            this.panelHeader.TabIndex = 1;
            // 
            // namacafe
            // 
            this.namacafe.AutoSize = true;
            this.namacafe.Font = new System.Drawing.Font("Sans Serif Collection", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namacafe.Location = new System.Drawing.Point(47, 0);
            this.namacafe.Name = "namacafe";
            this.namacafe.Size = new System.Drawing.Size(281, 109);
            this.namacafe.TabIndex = 0;
            this.namacafe.Text = "Kopi dan Kamu";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelFooter.Controls.Add(this.labelTagihan);
            this.panelFooter.Controls.Add(this.labelBarang);
            this.panelFooter.Controls.Add(this.buttonPayment);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 523);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(359, 105);
            this.panelFooter.TabIndex = 0;
            // 
            // labelTagihan
            // 
            this.labelTagihan.AutoSize = true;
            this.labelTagihan.Location = new System.Drawing.Point(209, 46);
            this.labelTagihan.Name = "labelTagihan";
            this.labelTagihan.Size = new System.Drawing.Size(35, 13);
            this.labelTagihan.TabIndex = 2;
            this.labelTagihan.Text = "label1";
            // 
            // labelBarang
            // 
            this.labelBarang.AutoSize = true;
            this.labelBarang.Location = new System.Drawing.Point(64, 46);
            this.labelBarang.Name = "labelBarang";
            this.labelBarang.Size = new System.Drawing.Size(35, 13);
            this.labelBarang.TabIndex = 1;
            this.labelBarang.Text = "label1";
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPayment.Location = new System.Drawing.Point(27, 32);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(301, 41);
            this.buttonPayment.TabIndex = 0;
            this.buttonPayment.Text = "button1";
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 628);
            this.Controls.Add(this.panelUtama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelUtama.ResumeLayout(false);
            this.panelUtama.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUtama;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label namacafe;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.FlowLayoutPanel flowFoods;
        private System.Windows.Forms.FlowLayoutPanel flowDrinks;
        private System.Windows.Forms.Label segment2;
        private System.Windows.Forms.Label segment1;
        private System.Windows.Forms.Label labelTagihan;
        private System.Windows.Forms.Label labelBarang;
        private System.Windows.Forms.Button buttonPayment;
    }
}

