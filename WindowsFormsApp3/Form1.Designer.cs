namespace WindowsFormsApp3
{
  partial class Form1
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
      this.Button3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Button3
      // 
      this.Button3.Location = new System.Drawing.Point(797, 12);
      this.Button3.Name = "Button3";
      this.Button3.Size = new System.Drawing.Size(75, 23);
      this.Button3.TabIndex = 0;
      this.Button3.Text = "Button3";
      this.Button3.UseVisualStyleBackColor = true;
      this.Button3.Click += new System.EventHandler(this.Button3_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(884, 560);
      this.Controls.Add(this.Button3);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button Button3;
    }
}

