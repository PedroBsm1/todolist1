using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todolist1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
           if(txttarefa.Text == "")
            {
                MessageBox.Show("ERRO. Digite a tarefa!");
            }
            else
            { 
            listlist.Items.Add($"{datapicker.Value:d} - {txttarefa.Text}");
            }
        }


        private void datapicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txttarefa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            if (listlist.SelectedItem == null)
            {
                MessageBox.Show("Não tem item selecionado");
            }
            else
            {
                listlist.Items.Remove(listlist.SelectedItem);
            }
        }


        private void toolTip1_Popup_2(object sender, PopupEventArgs e)
            
        {
            
        }
    }
    }

