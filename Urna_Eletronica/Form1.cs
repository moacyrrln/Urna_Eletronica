using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna_Eletronica
{
	public partial class Form1 : Form
	{
		string codigo_candidato = "";
		char[] campo = new char[5];
		int intConta = 0;



		private void atualiza_codigo_candidato()
		{
			char[] arr = new char[5];
			arr = codigo_candidato.ToCharArray(0, codigo_candidato.Length);


			if (codigo_candidato.Length >= 1)
			{
				campo1.Text = arr[0].ToString();
			}
			if (codigo_candidato.Length >= 2)
			{
				campo2.Text = arr[1].ToString();
			}
			if (codigo_candidato.Length >= 3)
			{
				campo3.Text = arr[2].ToString();
			}
			if (codigo_candidato.Length >= 4)
			{
				campo4.Text = arr[3].ToString();
			}
			if (codigo_candidato.Length >= 5)
			{
				campo5.Text = arr[4].ToString();
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 1);
			atualiza_codigo_candidato();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 2);
			atualiza_codigo_candidato();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 3);
			atualiza_codigo_candidato();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 4);
			atualiza_codigo_candidato();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 5);
			atualiza_codigo_candidato();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 6);
			atualiza_codigo_candidato();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 7);
			atualiza_codigo_candidato();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 8);
			atualiza_codigo_candidato();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 9);
			atualiza_codigo_candidato();
		}

		private void button0_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 0);
			atualiza_codigo_candidato();
		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Data_hora.Text = DateTime.Now.ToString();
			
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (intConta == 0)
			{
				campo1.BackColor = Color.Transparent;
				campo2.BackColor = Color.Transparent;
				campo3.BackColor = Color.Transparent;
				campo4.BackColor = Color.Transparent;
				campo5.BackColor = Color.Transparent;
			}

			if (intConta == 1)
			{
				if (codigo_candidato.Length == 0) campo1.BackColor = Color.FromArgb(192, 255, 255);
				if (codigo_candidato.Length == 1) campo2.BackColor = Color.FromArgb(192, 255, 255);
				if (codigo_candidato.Length == 2) campo3.BackColor = Color.FromArgb(192, 255, 255);
				if (codigo_candidato.Length == 3) campo4.BackColor = Color.FromArgb(192, 255, 255);
				if (codigo_candidato.Length == 4) campo5.BackColor = Color.FromArgb(192, 255, 255);
			}

			intConta += 1;
			if (intConta > 1)
				intConta = 0;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}


		private void buttonBranco_Click(object sender, EventArgs e)
		{

		}

		private void buttonCorrige_Click(object sender, EventArgs e)
		{
			codigo_candidato = "";
			campo1.Text = "";
			campo2.Text = "";
			campo3.Text = "";
			campo4.Text = "";
			campo5.Text = "";
		}

		
	}
}
