using System.ComponentModel;

namespace cSharpWindowsForms._04._19
{
  partial class UcMain
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(329, 287);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(547, 404);
      this.label1.TabIndex = 0;
      this.label1.Text = "Content UserControl";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // UcMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.label1);
      this.Name = "UcMain";
      this.Size = new System.Drawing.Size(1320, 1288);
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;

    #endregion
  }
}