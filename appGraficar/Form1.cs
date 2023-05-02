using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appGraficar
{
  public partial class Form1 : Form
  {
    OpenFileDialog dialogo = new OpenFileDialog();
    public Form1()
    {
      InitializeComponent();
      lstvDatos.View = View.Details;
    }
    private void btnExaminar_Click(object sender, EventArgs e)
    {
      //listview

      if (dialogo.ShowDialog() != DialogResult.OK)
      {
        return;
      }
      tvJerarquia.Visible = true;
      chart1.Visible = true;
      lstvDatos.Visible = true;
      lstvDatos.Clear();
      string rutaArchivo = dialogo.FileName;
      StreamReader sr = new StreamReader(rutaArchivo, Encoding.GetEncoding(1252));
      string columnas = sr.ReadLine();
      string[] columna = columnas.Split('|');
      for (int i = 0; i < columna.Length; i++)
      {
        lstvDatos.Columns.Add(columna[i]);
      }
      string renglon;
      while ((renglon = sr.ReadLine()) != null)
      {
        string[] datos = renglon.Split('|');
        ListViewItem item = new ListViewItem(datos[0]);
        for (int i = 1; i < datos.Length; i++)
        {
          item.SubItems.Add(datos[i]);
        }
        lstvDatos.Items.Add(item);
      }

      //graficar

      StreamReader dr = new StreamReader(rutaArchivo, Encoding.GetEncoding(1252));
      string x = "";
      int y = 0;
      while ((renglon=dr.ReadLine()) != null)
      {
        string[] datos = renglon.Split('|');
        if (x != datos[0] && x !="")
        {
          chart1.Series[0].Points.AddXY(x, y);
          y = 0;
        }
        x = datos[0];
        y++;
      }
      chart1.Series[0].Points.AddXY(x, y);
      sr.Close();

      //jerarquia
      //LlenarArbol(sr);
    }
    private void LlenarArbol(StreamReader sr)
    {
      string renglon;
      string x = "";
      TreeNode ciudad = new TreeNode();
      TreeNode estado = new TreeNode();
      TreeNode codigoPostal = new TreeNode();
      TreeNode colonia = new TreeNode();
      string cd = "";
      string cp = "";
      while ((renglon = sr.ReadLine()) != null)
      {
        string[] datos = renglon.Split('|');
        if (colonia.Text != datos[1] && x != "")
        {
          if (codigoPostal.Text != datos[0] && ciudad.Text != "")
          {
            if (ciudad.Text != datos[5] && ciudad.Text != "")
            {
              if (estado.Text != datos[4] && estado.Text != "")
              {
                tvJerarquia.Nodes.Add(estado.Text);
                estado = new TreeNode();
              }
            }
            estado.Text = datos[5];
            estado.Nodes.Add(ciudad);
            ciudad = new TreeNode();
          }
          ciudad.Text = datos[1];
          codigoPostal.Nodes.Add(ciudad);
          codigoPostal = new TreeNode();
        }
        codigoPostal.Text = datos[5];
        codigoPostal.Nodes.Add(codigoPostal);
        colonia.Text = datos[0];

      }
    }

  }
}
