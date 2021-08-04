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
		bool voto_legenda = false;
		bool voto_legenda_G = false;
		bool voto_nulo = false;
		bool voto_branco = false;
		bool prefeito = false;

		private void atualiza_codigo_prefeito()
		{

		}

		private void atualiza_codigo_candidato()
		{
			char[] arr = new char[5];
			arr = codigo_candidato.ToCharArray(0, codigo_candidato.Length);
			numero_label.Visible = false;
			partido_label.Visible = false;
			partido.Visible = false;

			if (codigo_candidato.Length >= 1)
			{
				campo1.Text = arr[0].ToString();
			}
			if (codigo_candidato.Length >= 2)
			{
				campo2.Text = arr[1].ToString();
				numero_label.Visible = true;
				partido_label.Visible = true;
				partido.Visible = true;
				voto_legenda = true;
				partido_correto.Visible = true;
				if (arr[0] == '9' && arr[1] == '1' || arr[1] == '2' || arr[1] == '3' || arr[1] == '4' || arr[1] == '5')
				{
					switch (arr[1].ToString())
					{
						case "1":
							partido.Text = "PEsp";
							pesp_candidatos.Visible = true;
							break;
						case "2":
							partido.Text = "PMus";
							pmus_candidatos.Visible = true;
							break;
						case "3":
							partido.Text = "PProf";
							pprof_candidatos.Visible = true;
							break;
						case "4":
							partido.Text = "PFest";
							pfest_candidatos.Visible = true;
							break;
						case "5":
							partido.Text = "PFolc";
							pfolc_candidatos.Visible = true;
							break;
						default:
							partido.Visible = false;
							voto_legenda = false;
							partido_correto.Visible = false;
							break;
					}

				}
				else
				{
					candidato_inexistente.Visible = true;
					candidato_inexistente.Text = "NÚMERO ERRADO";
					partido_label.Visible = false;
					partido.Visible = false;
					voto_nulo = true;
					voto_legenda = false;
				}
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
				voto_legenda_G = true;
				voto_legenda = false;

				pesp_candidatos.Visible = false;
				pmus_candidatos.Visible = false;
				pprof_candidatos.Visible = false;
				pfest_candidatos.Visible = false;
				pfolc_candidatos.Visible = false;

				if (arr[0].ToString() == "9" && arr[1].ToString() == "1")
				{
					nome_candidato_label.Visible = true;
					nome_candidato.Visible = true;
					switch (arr[4].ToString())
					{
						case "1":
							candidato_inexistente.Visible = false;
							foto_candidato_91001.Visible = true;
							nome_candidato.Text = "Golfe";
							voto_legenda_G = false;
							break;
						case "2":
							candidato_inexistente.Visible = false;
							foto_candidato_91002.Visible = true;
							nome_candidato.Text = "Beisebol";
							voto_legenda_G = false;
							break;
						case "3":
							candidato_inexistente.Visible = false;
							foto_candidato_91003.Visible = true;
							nome_candidato.Text = "Ginástica Artística";
							voto_legenda_G = false;
							break;
						default:
							candidato_inexistente.Visible = true;
							nome_candidato_label.Visible = false;
							nome_candidato.Visible = false;
							break;
					}
				}

				if (arr[0].ToString() == "9" && arr[1].ToString() == "2")
				{
					nome_candidato_label.Visible = true;
					nome_candidato.Visible = true;
					switch (arr[4].ToString())
					{
						case "1":
							candidato_inexistente.Visible = false;
							foto_candidato_92001.Visible = true;
							nome_candidato.Text = "Rock";
							voto_legenda_G = false;
							break;
						case "2":
							candidato_inexistente.Visible = false;
							foto_candidato_92002.Visible = true;
							nome_candidato.Text = "Sertanejo";
							voto_legenda_G = false;
							break;
						case "3":
							candidato_inexistente.Visible = false;
							foto_candidato_92003.Visible = true;
							nome_candidato.Text = "Música Popular Brasileira";
							voto_legenda_G = false;
							break;
						default:
							candidato_inexistente.Visible = true;
							break;
					}
				}

				if (arr[0].ToString() == "9" && arr[1].ToString() == "3")
				{
					nome_candidato_label.Visible = true;
					nome_candidato.Visible = true;
					switch (arr[4].ToString())
					{
						case "1":
							candidato_inexistente.Visible = false;
							foto_candidato_93001.Visible = true;
							nome_candidato.Text = "Astronauta";
							voto_legenda_G = false;
							break;
						case "2":
							candidato_inexistente.Visible = false;
							foto_candidato_93002.Visible = true;
							nome_candidato.Text = "Pintor";
							voto_legenda_G = false;
							break;
						case "3":
							candidato_inexistente.Visible = false;
							foto_candidato_93003.Visible = true;
							nome_candidato.Text = "Enfermeira";
							voto_legenda_G = false;
							break;
						default:
							candidato_inexistente.Visible = true;
							break;
					}
				}

				if (arr[0].ToString() == "9" && arr[1].ToString() == "4")
				{
					nome_candidato_label.Visible = true;
					nome_candidato.Visible = true;
					switch (arr[4].ToString())
					{
						case "1":
							candidato_inexistente.Visible = false;
							foto_candidato_94001.Visible = true;
							nome_candidato.Text = "Páscoa";
							voto_legenda_G = false;
							break;
						case "2":
							candidato_inexistente.Visible = false;
							foto_candidato_94002.Visible = true;
							nome_candidato.Text = "Oktoberfest";
							voto_legenda_G = false;
							break;
						case "3":
							candidato_inexistente.Visible = false;
							foto_candidato_94003.Visible = true;
							nome_candidato.Text = "Reveillon";
							voto_legenda_G = false;
							break;
						default:
							candidato_inexistente.Visible = true;
							break;
					}
				}

				if (arr[0].ToString() == "9" && arr[1].ToString() == "5")
				{
					nome_candidato_label.Visible = true;
					nome_candidato.Visible = true;
					switch (arr[4].ToString())
					{
						case "1":
							candidato_inexistente.Visible = false;
							foto_candidato_95001.Visible = true;
							nome_candidato.Text = "Curupira";
							voto_legenda_G = false;
							break;
						case "2":
							candidato_inexistente.Visible = false;
							foto_candidato_95002.Visible = true;
							nome_candidato.Text = "Cabra Cabriola";
							voto_legenda_G = false;
							break;
						case "3":
							candidato_inexistente.Visible = false;
							foto_candidato_95003.Visible = true;
							voto_legenda_G = false;
							nome_candidato.Text = "Cuca";
							break;
						default:
							candidato_inexistente.Visible = true;
							break;
					}
				}

				//if (arr[0].ToString() == "9" && arr[1].ToString() != "1" || arr[1].ToString() != "2" || arr[1].ToString() != "3" || arr[1].ToString() != "4" || arr[1].ToString() != "5" ||)
				//{

				//}


			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 1);
			if (!prefeito) atualiza_codigo_candidato();
			else atualiza_codigo_prefeito();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 2);
			if (!prefeito) atualiza_codigo_candidato();
			else atualiza_codigo_prefeito();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 3);
			if (!prefeito) atualiza_codigo_candidato();
			else atualiza_codigo_prefeito();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 4);
			if (!prefeito) atualiza_codigo_candidato();
			else atualiza_codigo_prefeito();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 5);
			if (!prefeito) atualiza_codigo_candidato();
			else atualiza_codigo_prefeito();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 6);
			if (!prefeito) atualiza_codigo_candidato();
			else atualiza_codigo_prefeito();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 7);
			if (!prefeito) atualiza_codigo_candidato();
			else atualiza_codigo_prefeito();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 8);
			if (!prefeito) atualiza_codigo_candidato();
			else atualiza_codigo_prefeito();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 9);
			if (!prefeito) atualiza_codigo_candidato();
			else atualiza_codigo_prefeito();
		}

		private void button0_Click(object sender, EventArgs e)
		{
			codigo_candidato = String.Concat(codigo_candidato, 0);
			if (!prefeito) atualiza_codigo_candidato();
			else atualiza_codigo_prefeito();
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
				campo1.BorderStyle = BorderStyle.FixedSingle;
				campo2.BorderStyle = BorderStyle.FixedSingle;
				campo3.BorderStyle = BorderStyle.FixedSingle;
				campo4.BorderStyle = BorderStyle.FixedSingle;
				campo5.BorderStyle = BorderStyle.FixedSingle;
				if (voto_legenda) voto_de_legenda.Visible = true;
				if (voto_legenda_G) voto_legenda_grande.Visible = true;
				if (voto_nulo) voto_nulo_label.Visible = true;
				if (voto_branco) voto_branco_label.Visible = true;
			}

			if (intConta == 1)
			{
				if (codigo_candidato.Length == 0) campo1.BorderStyle = BorderStyle.None;
				if (codigo_candidato.Length == 1) campo2.BorderStyle = BorderStyle.None;
				if (codigo_candidato.Length == 2) campo3.BorderStyle = BorderStyle.None;
				if (codigo_candidato.Length == 3) campo4.BorderStyle = BorderStyle.None;
				if (codigo_candidato.Length == 4) campo5.BorderStyle = BorderStyle.None;
				voto_de_legenda.Visible = false;
				voto_legenda_grande.Visible = false;
				voto_nulo_label.Visible = false;
				voto_branco_label.Visible = false;
			}

			intConta += 1;
			if (intConta > 1)
				intConta = 0;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			numero_label.Visible = false;
			partido_label.Visible = false;
			partido.Visible = false;
			voto_de_legenda.Visible = false;
			partido_correto.Visible = false;
			voto_legenda_G = false;
		}


		private void buttonBranco_Click(object sender, EventArgs e)
		{
			if (codigo_candidato != "") MessageBox.Show("Para Votar em BRANCO, o campo de voto deve estar vazio. Aperte CORRIGE para apagar o campo do voto");
			else
			{
				voto_branco = true;
				partido_correto.Visible = true;
				campo1.Visible = false;
				campo2.Visible = false;
				campo3.Visible = false;
				campo4.Visible = false;
				campo5.Visible = false;
				help_partidos_vereadores.Visible = false;
			}

		}

		private void buttonCorrige_Click(object sender, EventArgs e)
		{
			codigo_candidato = "";
			campo1.Text = "";
			campo2.Text = "";
			campo3.Text = "";
			campo4.Text = "";
			campo5.Text = "";
			campo1.Visible = true;
			campo2.Visible = true;
			campo3.Visible = true;
			campo4.Visible = true;
			campo5.Visible = true;
			numero_label.Visible = false;
			partido_label.Visible = false;
			partido.Visible = false;
			partido_correto.Visible = false;
			voto_legenda = false;
			candidato_inexistente.Visible = false;
			voto_legenda_G = false;
			pesp_candidatos.Visible = false;
			pmus_candidatos.Visible = false;
			pprof_candidatos.Visible = false;
			pfest_candidatos.Visible = false;
			pfolc_candidatos.Visible = false;
			foto_candidato_91001.Visible = false;
			foto_candidato_91002.Visible = false;
			foto_candidato_91003.Visible = false;
			foto_candidato_92001.Visible = false;
			foto_candidato_92002.Visible = false;
			foto_candidato_92003.Visible = false;
			foto_candidato_93001.Visible = false;
			foto_candidato_93002.Visible = false;
			foto_candidato_93003.Visible = false;
			foto_candidato_94001.Visible = false;
			foto_candidato_94002.Visible = false;
			foto_candidato_94003.Visible = false;
			foto_candidato_95001.Visible = false;
			foto_candidato_95002.Visible = false;
			foto_candidato_95003.Visible = false;
			nome_candidato_label.Visible = false;
			nome_candidato.Visible = false;
			candidato_inexistente.Visible = false;
			candidato_inexistente.Text = "CANDIDATO INEXISTENTE";
			voto_nulo = false;
			voto_branco = false;
			help_partidos_vereadores.Visible = true;
		}

		private void campo5_Click(object sender, EventArgs e)
		{

		}

		private void buttonConfirma_Click(object sender, EventArgs e)
		{
			if (codigo_candidato.Length <= 1)
			{
				MessageBox.Show("Para CONFIRMAR é necessário digitar pelo menos o número do partido ou votar em BRANCO.");
			}
			else
			{
				MessageBox.Show("Para CONFIRMAR é necessário digitar pelo menos o número do partido ou votar em BRANCO.");
			}
		}
	}
}
