
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace usuario
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			if(textBox1.Text =="LIZ" && textBox2.Text =="1234")
			{
				MessageBox. Show("bienvenido al sistema");
				
			}
			else 
			
				MessageBox.Show("Acceso Denegado!!!");
			}
		
	}

	}

	

