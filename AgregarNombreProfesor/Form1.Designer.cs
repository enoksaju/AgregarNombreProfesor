namespace AgregarNombreProfesor
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.btnAgregar = new System.Windows.Forms.Button();
      this.txtFileName = new System.Windows.Forms.TextBox();
      this.btnAddFile = new System.Windows.Forms.Button();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnAgregar
      // 
      this.btnAgregar.Location = new System.Drawing.Point(281, 90);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(104, 34);
      this.btnAgregar.TabIndex = 0;
      this.btnAgregar.Text = "Procesar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
      // 
      // txtFileName
      // 
      this.txtFileName.Location = new System.Drawing.Point(12, 25);
      this.txtFileName.Name = "txtFileName";
      this.txtFileName.ReadOnly = true;
      this.txtFileName.Size = new System.Drawing.Size(316, 20);
      this.txtFileName.TabIndex = 1;
      // 
      // btnAddFile
      // 
      this.btnAddFile.Location = new System.Drawing.Point(334, 25);
      this.btnAddFile.Name = "btnAddFile";
      this.btnAddFile.Size = new System.Drawing.Size(51, 20);
      this.btnAddFile.TabIndex = 2;
      this.btnAddFile.Text = "Abrir";
      this.btnAddFile.UseVisualStyleBackColor = true;
      this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
      // 
      // openFileDialog
      // 
      this.openFileDialog.FileName = "openFileDialog";
      this.openFileDialog.Filter = "PDF  File|*.pdf";
      this.openFileDialog.Title = "Abrir PDF de Boletas";
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(12, 64);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(316, 20);
      this.txtNombre.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Archivo PDF:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Nombre:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(391, 130);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.btnAddFile);
      this.Controls.Add(this.txtFileName);
      this.Controls.Add(this.btnAgregar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.Text = "Agregar nombre  a boletas";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.TextBox txtFileName;
    private System.Windows.Forms.Button btnAddFile;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

