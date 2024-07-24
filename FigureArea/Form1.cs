using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(Enum.GetNames(typeof(Figure)));
        }


        public class FigureData
        {
            public Figure Figure { set; get; }
            public int Base { set; get; }
            public int Height { set; get; }
            public FigureData(int pBase, int pHeight, Figure pFigure)
            {
                Base = pBase;
                Height = pHeight;
                Figure = pFigure;
            }
        }


        public string PrintAreaFigure(FigureData fgureData)
        {
            string message = "";
            if (Figure.Square == fgureData.Figure)
            {
                message = "El area del " + fgureData.Figure + " " + fgureData.Base * fgureData.Base;
            }
            if (Figure.Triangle == fgureData.Figure)
            {
                message = "El area del " + fgureData.Figure + " " + (fgureData.Base * fgureData.Height) / 2;
            }
            if (Figure.Rectangle == fgureData.Figure)
            {
                message = "El area del " + fgureData.Figure + " " + fgureData.Base * fgureData.Height;
            }
            return message;
        }


        public enum Figure
        {
            Triangle,
            Square,
            Rectangle
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool state = false;
            state = Enum.TryParse(comboBox1.Text, true, out Figure figure);
            state = int.TryParse(textBox1.Text, out int parameter1);
            state = int.TryParse(textBox2.Text, out int parameter2);
            if (!state) 
            {
                MessageBox.Show("Error en los valores");
                return;
            }
            FigureData square = new FigureData(parameter1, parameter2, figure);
            MessageBox.Show(PrintAreaFigure(square));
            
        }
    }
}