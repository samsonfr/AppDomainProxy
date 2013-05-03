namespace HostApplication
{
  partial class FrmMain
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
      this.cboAssemblyName = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cboClassName = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtParameter = new System.Windows.Forms.TextBox();
      this.lblOutput = new System.Windows.Forms.Label();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.cmdExecute = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(109, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Component to create:";
      // 
      // cboAssemblyName
      // 
      this.cboAssemblyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.cboAssemblyName.FormattingEnabled = true;
      this.cboAssemblyName.Items.AddRange(new object[] {
            "PluginA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
            "PluginB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"});
      this.cboAssemblyName.Location = new System.Drawing.Point(15, 25);
      this.cboAssemblyName.Name = "cboAssemblyName";
      this.cboAssemblyName.Size = new System.Drawing.Size(549, 21);
      this.cboAssemblyName.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Class Name:";
      // 
      // cboClassName
      // 
      this.cboClassName.FormattingEnabled = true;
      this.cboClassName.Items.AddRange(new object[] {
            "PluginA.ClassA",
            "PluginB.ClassB"});
      this.cboClassName.Location = new System.Drawing.Point(15, 65);
      this.cboClassName.Name = "cboClassName";
      this.cboClassName.Size = new System.Drawing.Size(549, 21);
      this.cboClassName.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 89);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(58, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Parameter:";
      // 
      // txtParameter
      // 
      this.txtParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtParameter.Location = new System.Drawing.Point(15, 105);
      this.txtParameter.Name = "txtParameter";
      this.txtParameter.Size = new System.Drawing.Size(549, 20);
      this.txtParameter.TabIndex = 5;
      this.txtParameter.Text = "Hello, World";
      // 
      // lblOutput
      // 
      this.lblOutput.AutoSize = true;
      this.lblOutput.Location = new System.Drawing.Point(12, 128);
      this.lblOutput.Name = "lblOutput";
      this.lblOutput.Size = new System.Drawing.Size(42, 13);
      this.lblOutput.TabIndex = 6;
      this.lblOutput.Text = "Output:";
      // 
      // txtOutput
      // 
      this.txtOutput.Location = new System.Drawing.Point(15, 144);
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.Size = new System.Drawing.Size(549, 20);
      this.txtOutput.TabIndex = 7;
      // 
      // cmdExecute
      // 
      this.cmdExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdExecute.Location = new System.Drawing.Point(489, 170);
      this.cmdExecute.Name = "cmdExecute";
      this.cmdExecute.Size = new System.Drawing.Size(75, 23);
      this.cmdExecute.TabIndex = 8;
      this.cmdExecute.Text = "Execute";
      this.cmdExecute.UseVisualStyleBackColor = true;
      this.cmdExecute.Click += new System.EventHandler(this.cmdExecute_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(576, 197);
      this.Controls.Add(this.cmdExecute);
      this.Controls.Add(this.txtOutput);
      this.Controls.Add(this.lblOutput);
      this.Controls.Add(this.txtParameter);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.cboClassName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cboAssemblyName);
      this.Controls.Add(this.label1);
      this.Name = "FrmMain";
      this.Text = "AppDomainProxy Test";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cboAssemblyName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cboClassName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtParameter;
    private System.Windows.Forms.Label lblOutput;
    private System.Windows.Forms.TextBox txtOutput;
    private System.Windows.Forms.Button cmdExecute;
  }
}

