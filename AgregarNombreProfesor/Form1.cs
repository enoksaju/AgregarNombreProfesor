using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AgregarNombreProfesor
{
  public partial class Form1 : Form
  {

    public Form1()
    {
      InitializeComponent();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtFileName.Text.Trim() == string.Empty) throw new Exception("No se indico el archivo");
        if (txtNombre.Text.Trim() == string.Empty) throw new Exception("No se indico el Nombre");

        var pathin = txtFileName.Text;
        var pathout = Path.Combine(Path.GetDirectoryName(txtFileName.Text), Path.GetFileNameWithoutExtension(txtFileName.Text) + "_withName.pdf");

        PdfReader reader = new PdfReader(pathin);
        PdfStamper stamper = new PdfStamper(reader, new FileStream(pathout, FileMode.Create));
        //  PdfContentByte pbover = stamper.GetOverContent(1);

        var pharse = new Phrase(txtNombre.Text, new iTextSharp.text.Font(FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL)));
        for (var i = 1; i <= reader.NumberOfPages; i++)
        {
          var par = i % 2;
          if (par != 0)
          {
            PdfContentByte pbunder = stamper.GetOverContent(i);
            ColumnText.ShowTextAligned(pbunder, Element.ALIGN_CENTER, pharse, 460, 488, 0);
          }
        }
        stamper.Close();
        MessageBox.Show(this, "Se completo la accion correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Process.Start(pathout);
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnAddFile_Click(object sender, EventArgs e)
    {
      if (openFileDialog.ShowDialog() != DialogResult.OK) return;
      txtFileName.Text = openFileDialog.FileName;
    }
  }
}
