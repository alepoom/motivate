/*
 * Created by SharpDevelop.
 * User: Lab-01
 * Date: 29/7/2024
 * Time: 20:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace motivate_gil
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string[] Frases = {
            "La vida es bella.",
            "Hoy es un gran día.",
            "Nunca dejes de soñar.",
            "El éxito es la suma de pequeños esfuerzos.",
            "La felicidad es una elección.",
            "Cada día es una nueva oportunidad.",
            "Hazlo con pasión o no lo hagas.",
            "matate"
			};
		public MainForm()
		{
			
			InitializeComponent();

		}
		void BTN_motivateClick(object sender, EventArgs e)
		{
            Random random = new Random();
            int indiceAleatorio = random.Next(0,8);
            LBL_frase.Text = (Frases[indiceAleatorio]);
		}
	}
}
