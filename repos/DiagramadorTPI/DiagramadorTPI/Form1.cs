using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dalssoft.DiagramNet;

namespace DiagramadorTPI
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        private bool cambioDesigner = true;
        public string FileName { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void abrirArchivo() { 
            openFileDialog1.FileName = FileName;
            openFileDialog1.Filter = "JSON(*.json)|*.json|EXCEL(*.xlsx)|*.xlsx|Todos los archivos(*.*)|*.*";
            openFileDialog1.DefaultExt = ".json";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;

                designer1.Open(openFileDialog1.FileName);
            }
        }

        public void guardarArchivo() { 
            saveFileDialog1.FileName = FileName;
            saveFileDialog1.Filter = "JSON(*.json)|*.json|EXCEL(*.xlsx)|*.xlsx|Todos los archivos(*.*)|*.*";
            saveFileDialog1.DefaultExt = ".json";
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                FileName = saveFileDialog1.FileName;
                designer1.Save(saveFileDialog1.FileName);
                Bitmap bmp = new Bitmap(designer1.Width, designer1.Height);
                designer1.DrawToBitmap(bmp, new Rectangle(0, 0, designer1.Width, designer1.Height));
                bmp.Save(saveFileDialog1.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }
        public void agregar(ElementType e) {
            switch (e)
            {
                case ElementType.Rectangle:

                    rectanguloToolStrip.Checked = true;
                    break;
                case ElementType.Elipse:

                    circuloToolStrip.Checked = true;
                    break;
            }

            if (cambioDesigner)
            {
                designer1.Document.Action = DesignerAction.Add;
                designer1.Document.ElementType = e;
            }
        }
        public void borrar() {
            if (cambioDesigner)
                designer1.Document.DeleteSelectedElements();
        }

        public void conectar() {
            if (cambioDesigner)
                designer1.Document.Action = DesignerAction.Connect;
        }

        public void conector(LinkType lt) {
            designer1.Document.LinkType = lt;
            conectar();
        }

        private void deshacerRehacer()
        {

            fondoToolStrip.Enabled = designer1.CanUndo;

            frenteToolStrip.Enabled = designer1.CanRedo;
        }

        private void deshacer()
        {
            if (designer1.CanUndo)
                designer1.Undo();

            deshacerRehacer();
        }

        private void rehacer()
        {
            if (designer1.CanRedo)
                designer1.Redo();

            deshacerRehacer();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirArchivo();
        }

        private void guardarArchivoMenu_Click(object sender, EventArgs e)
        {
            guardarArchivo();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
               this.Close();
        }

        private void abrirToolStrip_Click_1(object sender, EventArgs e)
        {
            abrirArchivo();
        }

        private void guardarToolStrip_Click_1(object sender, EventArgs e)
        {
            guardarArchivo();
        }

        private void cortarToolStrip_Click_1(object sender, EventArgs e)
        {

        }

        private void fondoToolStrip_Click(object sender, EventArgs e)
        {
            deshacer();
        }

        private void frenteToolStrip_Click(object sender, EventArgs e)
        {
            rehacer();
        }

        private void rectanguloToolStrip_Click(object sender, EventArgs e)
        {
            agregar(ElementType.RectangleNode);
        }

        private void circuloToolStrip_Click(object sender, EventArgs e)
        {
            agregar(ElementType.ElipseNode);
        }

        private void borrarToolStrip_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void unirToolStrip_Click(object sender, EventArgs e)
        {
            conector(LinkType.Straight);
        }
    }
}
