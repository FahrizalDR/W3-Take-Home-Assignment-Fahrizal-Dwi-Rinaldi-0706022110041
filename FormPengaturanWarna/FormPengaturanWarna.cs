using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPengaturanWarna
{
    public partial class FormPengaturanWarna : Form
    {
        public FormPengaturanWarna()
        {
            InitializeComponent();
        }

        Font Mengecil = new Font("Segoe UI", 10);
        Font Membesar = new Font("Segoe UI", 30);
        Font Normal = new Font("Segoe UI", 20);

        private void ButtonProses_Click(object sender, EventArgs e)
        {                       
            if (TextBoxInputData.Text.Substring(0,4).ToUpper() == "ISI:")            
                LabelHasil.Text = TextBoxInputData.Text.Substring(4);            
            else if (TextBoxInputData.Text.ToUpper() == "SHOWN")            
                LabelHasil.Show();            
            else if (TextBoxInputData.Text.ToUpper() == "HIDE")            
                LabelHasil.Hide();            
            else if (TextBoxInputData.Text.Substring(0, 6).ToUpper() == "WARNA:")
            {
                if (TextBoxInputData.Text.Substring(6).ToUpper() == "DEFAULT")                
                    LabelHasil.ForeColor = Color.Black;                
                else if (TextBoxInputData.Text.Substring(6).ToUpper() == "MERAH")                
                    LabelHasil.ForeColor = Color.Red;                
                else if (TextBoxInputData.Text.Substring(6).ToUpper() == "KUNING")                
                    LabelHasil.ForeColor = Color.Yellow;                
                else if (TextBoxInputData.Text.Substring(6).ToUpper() == "HIJAU")                
                    LabelHasil.ForeColor = Color.Green;                
                else if (TextBoxInputData.Text.Substring(6).ToUpper() == "BIRU")                
                    LabelHasil.ForeColor = Color.Blue;                
            }  
            else if (TextBoxInputData.Text.ToUpper() == "RESTART")
            {
                LabelHasil.Text = "[EMPTY]";
                LabelHasil.ForeColor = Color.Black;
                LabelHasil.Font = Normal;
            }
            else if (TextBoxInputData.Text.ToUpper() == "BESARKAN")           
                LabelHasil.Font = Membesar;            
            else if (TextBoxInputData.Text.ToUpper() == "KECILKAN")            
                LabelHasil.Font = Mengecil;                       
            else
                MessageBox.Show("Syntax Tidak Terdaftar!", "Terjadi Kesalahan");
        }        
    }
}
