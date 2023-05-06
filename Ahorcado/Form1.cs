using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        char[] palabrasadivinadas;
        char[] palabraseleccionada;
        char[] alfabeto;
        String[] palabras;
        int oportunidades;
        int puntaje = 2; 

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            iniciar_juego(); 
        }

        private void iniciar_juego()
        {
            fichas_abecedario1.Controls.Clear();
            fichas_abecedario1.Enabled = true;
            pic_ahorcado.Image = null;
            BTN_INICIAR.Enabled = false;
            LBL_MENSAJE.Visible = false;
            oportunidades = 0;
            TXT_VIDAS.Text = puntaje.ToString(); 
            TXT_VIDAS.Enabled = false; 
            BTN_INICIAR.Image = Properties.Resources.en_juego;
            palabras = new string[] {"ZEUS","ARES","POSEIDON","HERMES","APOLO","HERA","ARTEMISA","HEFESTO","ATENEA","KRATOS"};
            alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUWXYZ".ToCharArray(); //Toda esta cadena es un conjunto de caracteres que se guardan el el vector alfabeto
            Random palabra_seleccionada1 = new Random();
            int indice_palabra_selecc = palabra_seleccionada1.Next(0,palabras.Length);
            palabraseleccionada = palabras[indice_palabra_selecc].ToUpper().ToCharArray();
            palabrasadivinadas = palabraseleccionada; 
            foreach (char letra_alfabeto in alfabeto) // Coloca el abecedario
            {
                Button btnletra = new Button();
                btnletra.Tag = "";
                btnletra.Text = letra_alfabeto.ToString();
                btnletra.Width = 60;
                btnletra.Height = 40;
                btnletra.ForeColor = Color.Red;
                btnletra.Font = new Font(btnletra.Font.Name,15,FontStyle.Bold);
                btnletra.BackColor = Color.Blue;
                btnletra.Name = letra_alfabeto.ToString();
                fichas_abecedario1.Controls.Add(btnletra); // Siempre va al final 
                btnletra.Click += comparar; //Se asigna una accion
            }

            fl_palabras.Controls.Clear();

            for (int indice_valor_letra = 0; indice_valor_letra < palabraseleccionada.Length; indice_valor_letra++) // Coloca la palabra que se busca
            {
                Button letra = new Button();
                letra.Tag = palabraseleccionada[indice_valor_letra].ToString();
                letra.Width = 46; //Ancho
                letra.Height = 80; //Largo
                letra.ForeColor = Color.BlueViolet; //Color de letra
                letra.Text = "$"; //Simbolo
                letra.Font = new Font(letra.Font.Name, 32, FontStyle.Bold);// Tipo de letra
                letra.BackColor = Color.LightBlue; //Color de fondo
                letra.FlatStyle = FlatStyle.Flat; //Es para apariencia
                letra.Name = "ADIVINADO" + indice_valor_letra.ToString();
                fl_palabras.Controls.Add(letra);
            }
        }

        void comparar(object sender, EventArgs e)
        {
            bool encontrado = false;
            Button btn = (Button)sender; //Se extrae el valor del boton
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.Purple;
            btn.Enabled = false;

            for (int indice_revisar = 0; indice_revisar < palabrasadivinadas.Length; indice_revisar++)
            {
                if (palabrasadivinadas[indice_revisar] == char.Parse(btn.Text)) // Se convierte a carcater y compara 
                {
                    Button tbx = this.Controls.Find("ADIVINADO" + indice_revisar,true).FirstOrDefault() as Button;
                    tbx.Text = palabrasadivinadas[indice_revisar].ToString();
                    palabrasadivinadas[indice_revisar] = '$';
                    encontrado = true;
                    
                }
            }

            bool ganaste = true; // Se declara una variable

            for (int indice_palabra_adivinada = 0; indice_palabra_adivinada < palabrasadivinadas.Length; indice_palabra_adivinada++) // Es para saber si gane
            {
                if (palabrasadivinadas[indice_palabra_adivinada] != '$')
                {
                    ganaste = false; 
                }
            }

            if (ganaste == true)
            {
                MessageBox.Show("FELICIDADES ADIVINASTE LA LETRA", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                puntaje++; 
                BTN_INICIAR.Image = Properties.Resources.jugar;
                BTN_INICIAR.Enabled = true; 
            }

            if (encontrado == false)
            {
                oportunidades += 1;
                pic_ahorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ahorcado" + oportunidades);    //Se extrae la imagen del ahorcado
            }

            if (oportunidades == 10)
            {
                LBL_MENSAJE.Visible = true;
                puntaje--; 

                for (int indice_letras1 = 0; indice_letras1 < palabraseleccionada.Length; indice_letras1++)
                {
                    Button btn_letras = this.Controls.Find("ADIVINADO" + indice_letras1, true).FirstOrDefault() as Button;
                    btn_letras.Text = btn_letras.Tag.ToString(); 
                }

                fichas_abecedario1.Enabled = false;
                BTN_INICIAR.Image = Properties.Resources.jugar;
                BTN_INICIAR.Enabled = true; 
            }

            if (puntaje == 0)
            {
                LBL_MENSAJE.Visible = true;
                MessageBox.Show("SE TE ACABARON LAS VIDAS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit(); 
            }
        }
    }
    //Tarea
} // Inicialmente tiene 2 vidas, si se adivina la palabra se suma una vida, sino se le resta
