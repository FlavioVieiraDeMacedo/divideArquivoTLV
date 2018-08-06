using DivideEmTLV.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivideEmTLV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Botao para pegar o caminho
        private void btn_getPath_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog1.FileName;
                try
                {
                    txt_Path.Text = file;
                }
                catch (IOException)
                {
                    MessageBox.Show("Erro no caminho para o arquivo");
                }
            }
        }

        #endregion

        private void btnBreak_Click(object sender, EventArgs e)
        {
            if (txt_Content.Text != ""|| txt_Content.Text != null)
            {
                Arquivo a = new Arquivo();
                a.Break_TLV_File(txt_Content.Text,txt_FinalCardTag.Text,txtBeginBodyTag.Text,txtAplicationLength1.Text,txtAplicationLength2.Text, txt_Save_Path.Text,txtPathTags.Text);
                MessageBox.Show("Show, acabou!!");
            }
            else
            {
                MessageBox.Show("Erro!!");
            }
            
        }

        private void btnBreakFile_Click(object sender, EventArgs e)
        {
            Arquivo a = new Arquivo();
            var texto = a.GetFileAndJoinTags(txt_Path.Text);
            texto = a.askToHex(texto);
            a.Break_TLV_File(texto, txt_FinalCardTag.Text, txtBeginBodyTag.Text, txtAplicationLength1.Text, txtAplicationLength2.Text,txt_Save_Path.Text, txtPathTags.Text);
            MessageBox.Show("Show, acabou!!");
        }

        private void btn_getFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                string file = folderBrowserDialog1.SelectedPath;
                try
                {
                    txt_Save_Path.Text = file;
                }
                catch (IOException)
                {
                }
            }
        }

        private void btn_GetPathTags_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    txtPathTags.Text = file;
                }
                catch (IOException)
                {
                    MessageBox.Show("Erro no caminho para o arquivo");
                }
            }
        }
    }


}
