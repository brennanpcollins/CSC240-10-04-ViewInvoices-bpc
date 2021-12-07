
namespace CSC240_10_04_ViewInvoices_bpc
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
            reader.Close();
            file.Close();
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
            this.UxViewTitleLabel = new System.Windows.Forms.Label();
            this.UxInvoiceLabel = new System.Windows.Forms.Label();
            this.UxNameLabel = new System.Windows.Forms.Label();
            this.UxAmountLabel = new System.Windows.Forms.Label();
            this.UxInvoiceBox = new System.Windows.Forms.TextBox();
            this.UxNameBox = new System.Windows.Forms.TextBox();
            this.UxAmountBox = new System.Windows.Forms.TextBox();
            this.UxViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UxViewTitleLabel
            // 
            this.UxViewTitleLabel.AutoSize = true;
            this.UxViewTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxViewTitleLabel.Location = new System.Drawing.Point(78, 52);
            this.UxViewTitleLabel.Name = "UxViewTitleLabel";
            this.UxViewTitleLabel.Size = new System.Drawing.Size(299, 90);
            this.UxViewTitleLabel.TabIndex = 0;
            this.UxViewTitleLabel.Text = "Click the button \r\nto view the records.";
            this.UxViewTitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // UxInvoiceLabel
            // 
            this.UxInvoiceLabel.AutoSize = true;
            this.UxInvoiceLabel.Location = new System.Drawing.Point(117, 221);
            this.UxInvoiceLabel.Name = "UxInvoiceLabel";
            this.UxInvoiceLabel.Size = new System.Drawing.Size(90, 32);
            this.UxInvoiceLabel.TabIndex = 1;
            this.UxInvoiceLabel.Text = "Invoice";
            // 
            // UxNameLabel
            // 
            this.UxNameLabel.AutoSize = true;
            this.UxNameLabel.Location = new System.Drawing.Point(117, 312);
            this.UxNameLabel.Name = "UxNameLabel";
            this.UxNameLabel.Size = new System.Drawing.Size(78, 32);
            this.UxNameLabel.TabIndex = 2;
            this.UxNameLabel.Text = "Name";
            // 
            // UxAmountLabel
            // 
            this.UxAmountLabel.AutoSize = true;
            this.UxAmountLabel.Location = new System.Drawing.Point(117, 385);
            this.UxAmountLabel.Name = "UxAmountLabel";
            this.UxAmountLabel.Size = new System.Drawing.Size(100, 32);
            this.UxAmountLabel.TabIndex = 3;
            this.UxAmountLabel.Text = "Amount";
            // 
            // UxInvoiceBox
            // 
            this.UxInvoiceBox.Location = new System.Drawing.Point(304, 221);
            this.UxInvoiceBox.Name = "UxInvoiceBox";
            this.UxInvoiceBox.Size = new System.Drawing.Size(200, 39);
            this.UxInvoiceBox.TabIndex = 4;
            // 
            // UxNameBox
            // 
            this.UxNameBox.Location = new System.Drawing.Point(304, 305);
            this.UxNameBox.Name = "UxNameBox";
            this.UxNameBox.Size = new System.Drawing.Size(200, 39);
            this.UxNameBox.TabIndex = 5;
            // 
            // UxAmountBox
            // 
            this.UxAmountBox.Location = new System.Drawing.Point(304, 382);
            this.UxAmountBox.Name = "UxAmountBox";
            this.UxAmountBox.Size = new System.Drawing.Size(200, 39);
            this.UxAmountBox.TabIndex = 6;
            // 
            // UxViewButton
            // 
            this.UxViewButton.Location = new System.Drawing.Point(551, 95);
            this.UxViewButton.Name = "UxViewButton";
            this.UxViewButton.Size = new System.Drawing.Size(190, 46);
            this.UxViewButton.TabIndex = 7;
            this.UxViewButton.Text = "View Records";
            this.UxViewButton.UseVisualStyleBackColor = true;
            this.UxViewButton.Click += new System.EventHandler(this.UxViewButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 656);
            this.Controls.Add(this.UxViewButton);
            this.Controls.Add(this.UxAmountBox);
            this.Controls.Add(this.UxNameBox);
            this.Controls.Add(this.UxInvoiceBox);
            this.Controls.Add(this.UxAmountLabel);
            this.Controls.Add(this.UxNameLabel);
            this.Controls.Add(this.UxInvoiceLabel);
            this.Controls.Add(this.UxViewTitleLabel);
            this.Name = "Form1";
            this.Text = "Invoice Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UxViewTitleLabel;
        private System.Windows.Forms.Label UxInvoiceLabel;
        private System.Windows.Forms.Label UxNameLabel;
        private System.Windows.Forms.Label UxAmountLabel;
        private System.Windows.Forms.TextBox UxInvoiceBox;
        private System.Windows.Forms.TextBox UxNameBox;
        private System.Windows.Forms.TextBox UxAmountBox;
        private System.Windows.Forms.Button UxViewButton;
    }
}

