using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacienteExercicio
{    
    public class Telefonia
    {
        static Telefonia _telefonia = null;

        public int Valor { get; set; }

        public void Conectar() { }

        public static Telefonia RecuperarTelefonia
        {
            get
            {
                if (_telefonia == null)
                    _telefonia = new Telefonia();

                return _telefonia;
            }
        }

        public Telefonia()
        {
            
        }

    }

    public partial class Form1 : Form
    {
        Telefonia tel;

        public Form1()
        {            
            InitializeComponent();
            tel = Telefonia.RecuperarTelefonia;
            tel.Valor = 10;
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telefonia tel2 = Telefonia.RecuperarTelefonia;

            var form = new Form2();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(new ucDetalhePaciente());

            Telefonia tel3 = Telefonia.RecuperarTelefonia;
        }
    }
}
