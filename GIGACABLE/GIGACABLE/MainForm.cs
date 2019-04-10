/*
 * Created by SharpDevelop.
 * User: irving
 * Date: 05/04/2019
 * Time: 09:42 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GIGACABLE
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
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            usuario llamada1 = new usuario();
            Tecnico llamada3= new Tecnico();
            
            
            
            

            if (radioButton1.Checked == true)
            {
                llamada1.ShowDialog();
                //llamada1.Show();
                //_ = llamada1.DialogResult == DialogResult.Yes;

            }
            else
            {               
                    llamada3.ShowDialog();
                    //llamada3.Show();
                    // _ = llamada3.DialogResult == DialogResult.Yes;

                
            }
            /* if (llamada1.DialogResult == DialogResult.Yes)
             {

             }*/
        }
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}

          private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
