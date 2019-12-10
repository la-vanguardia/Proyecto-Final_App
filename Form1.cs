using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;



namespace App_Proyecto
{

    public partial class Form1 : Form
    {

        int Estado=0;
        int Bandera = 0;
        string DatosRecibidos;

        public Form1()
        {
            InitializeComponent();
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            
            string[] PuertosDisponibles = SerialPort.GetPortNames();
            comBox_Puertos.Items.Clear();

            foreach (string puerto_simple in PuertosDisponibles)
            {
                comBox_Puertos.Items.Add(puerto_simple);

            }
            if(comBox_Puertos.Items.Count>0)
            {
                //Conectar_Puerto.Cursor = Cursors.Hand;
                comBox_Puertos.SelectedIndex= 0;
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.PortName = comBox_Puertos.Text;
                MessageBox.Show(comBox_Puertos.Text);

            }







        }

  

    
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

    
     

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

   
        private void Maxim_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized) 

                this.WindowState = FormWindowState.Normal;

            else
                this.WindowState = FormWindowState.Maximized;
               // Maxim.Image = Image.FromFile("C:/Users/Isaia/Desktop/Maxim.png");
            

            if (this.WindowState == FormWindowState.Maximized)
            {
                //Maxim.Image = Image.FromFile("C:/Users/Isaia/Desktop/Minimized.png");


            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if(Panel_Lateral.Visible)
            {


                Panel_Lateral_Animate.HideSync(Panel_Lateral);


            }
            else
            {

                Panel_Lateral_Animate.ShowSync(Panel_Lateral);



            }
            
        }

        private void Cerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel_Lateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel_Top_Paint(object sender, PaintEventArgs e)
        {

            

        }

        private void Panel_Top_DoubleClick(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.Dispose();

            Application.Exit();
            
        }

        private void Panel_Top_DoubleClick_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)

                this.WindowState = FormWindowState.Normal;

            else
                this.WindowState = FormWindowState.Maximized;
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)

                this.WindowState = FormWindowState.Normal;

            else
                this.WindowState = FormWindowState.Maximized;

        }

        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)

                this.WindowState = FormWindowState.Normal;

            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Bandera == 1)
            {

                var seed = Environment.TickCount;
                var random = new Random(seed);

                var value = random.Next(0, 50);
                var value2 = random.Next(10, 50);



                this.chart2.Series["Series1"].Points.AddXY(value, value2);

                this.chart2.Series["Series1"].Color = Color.Red;


                this.chart2.Series["Series2"].Points.AddXY(value + 10, value2 + 20);

                this.chart2.Series["Series2"].Color = Color.Green;
                
            }

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e) //Iniciar gráfico
        {
            Bandera = 1;
       
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e) //Parar gráfico
        {
            
            Bandera = 0;
            AdicionarInfoAlTxt();

        }

        private void chart2_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Conectar_Puerto_Click(object sender, EventArgs e)
        {



            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    serialPort1.Dispose();
                    Conectar_Puerto.color = Color.Blue;

                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message.ToString());
                }


            }
            else
            {

                try
                {
                    
                    serialPort1.Open();
                    Conectar_Puerto.color = Color.Coral;
                    //MessageBox.Show(comBox_Puertos.Text);
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message.ToString());
                }
            }



        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            DatosRecibidos = serialPort1.ReadLine();

            string rutaCompleta = @" C:\Users\Isaia\Desktop\mi archivo.txt";
            string texto = "HOLA DE NUEVO";

            using (StreamWriter file = new StreamWriter(rutaCompleta, true))
            {
                file.WriteLine(texto); //se agrega información al documento

                file.Close();



            }
            }


        void AdicionarInfoAlTxt()
        {
            string rutaCompleta = @" C:\Users\Isaia\Desktop\mi archivo.txt";
            string texto = "HOLA DE NUEVO";

            using (StreamWriter file = new StreamWriter(rutaCompleta, true))
            {
                file.WriteLine(texto); //se agrega información al documento

                file.Close();
            }
        }


    }

        

            

        
    
    }

