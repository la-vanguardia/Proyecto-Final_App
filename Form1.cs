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
using Newtonsoft.Json;




namespace App_Proyecto
{

    public partial class Form1 : Form
    {

        int Estado=0;
        int Bandera = 0;
        public string DatosRecibidos;
        

        public Form1()
        {
            InitializeComponent();
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarUART();
            PasoBox.Text = "1";
            AlturaBox.Text = "1";
            RepeticionesBox.Text = "1";
        

            string json = @"{
                               'CPU': 'Intel',
                               'PSU': '500W',
                               'Drives': [
                                 'DVD read/writer'
                                 /*(broken)*/,
                                 '500 gigabyte hard drive',
                                 '200 gigabype hard drive'
                               ]
                            }";

            JsonObjeto(json);







        }


        #region No se usa

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

    
     

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

   
        private void Maxim_Click(object sender, EventArgs e)
        {

            
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

        private void chart2_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        #endregion

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
            serialPort1.Close();
            serialPort1.Dispose();
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
            

         
            
        }

        private void Panel_Top_DoubleClick_1(object sender, EventArgs e)
        {
            Maxim();

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

            Maxim();

        }

        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Maxim();
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

            FuncionGraficar();

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e) //Iniciar gráfico
        {
            EnviarUART("Start");
           
            labelTempRestR.Visible = true;

            Bandera = 1;
       
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e) //Parar gráfico
        {

            EnviarUART("Stop");
            Bandera = 0;
            

        }

        

        private void Conectar_Puerto_Click(object sender, EventArgs e)
        {
            ConexionUART();

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            DatosRecibidos = serialPort1.ReadLine();
            

            string json = @"{
             'CPU': 'Intel',
                'PSU': '500W',
                'Drives': [
                 'DVD read/writer'
                 /*(broken)*/,
                 '500 gigabyte hard drive',
                 '200 gigabype hard drive'
                                        ]
                                            }";

            JsonObjeto(json);

            Console.WriteLine(DatosRecibidos);
            

        }


        void AdicionarInfoAlTxt()
        {
            string rutaCompleta = @" D:\Isaias\Escritorio\mi archivo.txt";
            string texto = "HOLA DE NUEVO";

            using (StreamWriter file = new StreamWriter(rutaCompleta, true))
            {
                file.WriteLine(texto); //se agrega información al documento

                file.Close();
            }
        }


        void Clasificar (string DatosSeparados)
        {
         


        }

        void ConfigurarUART()
        {

            string[] PuertosDisponibles = SerialPort.GetPortNames();
            comBox_Puertos.Items.Clear();

            foreach (string puerto_simple in PuertosDisponibles)
            {
                comBox_Puertos.Items.Add(puerto_simple);

            }
            if (comBox_Puertos.Items.Count > 0)
            {
                
                comBox_Puertos.SelectedIndex = 0;
                serialPort1.BaudRate = 19200;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.PortName = comBox_Puertos.Text;



            }


        }

        void ConexionUART()
        {


            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    serialPort1.Dispose();
                    ConectarPuerto.ButtonText = "CONECTAR";

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
                    serialPort1.DiscardOutBuffer();
                    serialPort1.DiscardInBuffer();
                    ConectarPuerto.ButtonText = "DESCONECTAR";

                    //MessageBox.Show(comBox_Puertos.Text);
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message.ToString());
                }
            }







        }

        void FuncionGraficar()
        {

            if (Bandera == 1)
            {

                var seed = Environment.TickCount;
                var random = new Random(seed);

                var value = random.Next(0, 50);
                var value2 = random.Next(10, 50);


                for (double i=0; i < 10; i=i+0.20)
                {
                   
                    this.chart9.Series["Series1"].Points.AddXY(i, 1);



                    this.chart9.Series["Series1"].Color = Color.Red;

                   
                }

                


                this.chart9.Series["Series2"].Points.AddXY(10.1, 1);

                this.chart9.Series["Series2"].Color = Color.Green;

            }




        }

        void Maxim()
        {

            if (this.WindowState == FormWindowState.Maximized)

                this.WindowState = FormWindowState.Normal;

            else
                this.WindowState = FormWindowState.Maximized;




        }

        void JsonObjeto(string json)
        {

            var JDatos = JsonConvert.DeserializeObject<dynamic>(json);

            Console.WriteLine(JDatos.CPU);


        }

        private void ConectarPuerto_Click(object sender, EventArgs e)
        {
            ConexionUART();
        }


        void EnviarUART (string DataOUT)
        {


            string JsonOUT = DataOUT + ',' + PasoBox.Text + ',' + AlturaBox.Text + ',' + RepeticionesBox.Text;

            Console.WriteLine(JsonOUT);

            //serialPort1.WriteLine(JsonOUT);

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }


   




}

