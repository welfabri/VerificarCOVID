using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VerificarCOVID
{
    public partial class Form1 : Form
    {
        private ChromeDriver _driver;
        private readonly string _url = "http://vacinacovid.saobernardo.sp.gov.br/VacinaSBCProd/servlet/inicial"; //"https://www.random.org/integers/?num=1&min=1&max=100000&col=5&base=10&format=html&rnd=new";

        public Form1()
        {
            InitializeComponent();
            ParametrizaComponentes();
            Iniciar();
        }

        private void ParametrizaComponentes()
        {
            if (_driver is not null)
                _driver.Quit();

            var path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            ChromeOptions options = new();
            options.AddArgument($"user-data-dir={path}ChromeDriver\\Cache");
            //options.AddArgument("headless");

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            //service.HideCommandPromptWindow = true;

            _driver = new ChromeDriver(service, options);
        }

        private void Timer1_Tick(object sender, EventArgs e)
            => ProcessaDados();

        private bool AchouIdades(string texto)
        {
            var tb = tbIdades.Text.Split(',');

            for (var i = 0; i < tb.Length; i++)
                if ((!texto.ToUpper().Contains("COMORBIDADE")) 
                && (texto.Contains(tb[i])))
                {
                    texto = "===> ACHOU!!! - " + texto;
                    lblAchouIdade.Visible = true;
                    AdicionaTextBox(texto);
                    return true;
                }

            return false;
        }

        private void LimpaControles()
            => textBox1.Clear();

        private void ProcessaDados()
        {
            try
            {
                var achou = false;

                _driver.Navigate().Refresh();

                List<IWebElement> selectIdades = _driver.FindElements(By.Id("vPUBLICOALVOID")).ToList();

                foreach (var i in selectIdades)
                {
                    var optionsIdade = i.FindElements(By.TagName("option")).ToList();

                    foreach (var o in optionsIdade)
                    {
                        achou = AchouIdades(o.Text);

                        if (achou)
                            break;
                    }
                }

                if (!achou)
                {
                    AdicionaTextBox("");
                    VerificarCOVIDUtil.Flash(this, 1);
                }
                else
                {
                    Parar();
                    VerificarCOVIDUtil.Flash(this);
                }

                BringToFront();
            }
            catch(Exception e)
            {
                AdicionaTextBox(e.Message);
            }
        }

        void AdicionaTextBox(string texto)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                textBox1.Text = textBox1.Text.Insert(0, Environment.NewLine);

            textBox1.Text = textBox1.Text.Insert(0, $"[{DateTime.Now}] " + texto);
        }

        private void ProcessaDados2()
        {
            _driver.Navigate().Refresh();
            var horario = _driver.FindElement(By.ClassName("data"));

            if (horario is not null)
                textBox1.AppendText(horario.Text);
        }

        private void button1_Click(object sender, EventArgs e)
            => Reiniciar();

        private void button2_Click(object sender, EventArgs e)
            => Parar();

        private void Reiniciar()
        {
            Parar();
            Iniciar();
        }

        private void Iniciar()
        {
            try
            {
                LimpaControles();
                AdicionaTextBox("=====> Iniciando...");
                _driver.Navigate().GoToUrl(_url);
                AdicionaTextBox($"=====> Iniciando URL: {_url}");
                timer1.Interval = decimal.ToInt32(edtTempo.Value * 1000) * 60;
                timer1.Enabled = true;
                Timer1_Tick(timer1, null);
            }
            catch(Exception e)
            {
                AdicionaTextBox($"Erro: {e.Message}");
                ParametrizaComponentes();
                AdicionaTextBox("Retentando...");
                Iniciar();
            }
        }

        private void Parar()
        {
            AdicionaTextBox("Parando...");
            timer1.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_driver is not null)
                _driver.Quit();
        }

        private void AbrirBrowser()
        {
            try
            {
                var ps = new System.Diagnostics.ProcessStartInfo(_url)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                System.Diagnostics.Process.Start(ps);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }
}
