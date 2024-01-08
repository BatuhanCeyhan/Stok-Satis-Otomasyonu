using Stok.Bussinuss.Abstract;
using Stok.Bussinuss.Concrete;
using Stok.Model.Entity_Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok.WinUI.PersonelIslemleri
{
    public partial class StokIslemleri : UserControl
    {
        IUrunBs urunBs;
        public StokIslemleri(IUrunBs _urunBs)
        {
            urunBs = _urunBs;
            InitializeComponent();
        }

        private void StokIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = urunBs.GetAll(x=>x.Aktif=="Var");
        }

        private void txtAra_Click(object sender, EventArgs e)
        {
            string Aratxt = txtArama.Text.Trim().ToUpper();

            int j = -1;

            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)

            {

                foreach (DataGridViewRow row in dataGridView1.Rows)

                {

                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)

                    {

                        if (cell.Value != null)

                        {

                            if (cell.Value.ToString().ToUpper() == Aratxt)

                            {

                                cell.Style.BackColor = Color.Yellow;

                                j = 0;

                                break;

                            }



                        }

                    }

                }

            }

            if (j == -1)

            {

                MessageBox.Show("Kayıt bulunamadı!", "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
