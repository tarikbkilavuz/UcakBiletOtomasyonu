using UcakBiletOtomasyonu.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += HavayoluListele;
        }

        HavayoluServis _havayoluServis = new HavayoluServis();
        UcusServis _ucusServis = new UcusServis();
        List<string> occupiedKoltuk = new List<string>();
        string secilenKoltuk;
        int secilen_ucus;

        private void HavayoluListele(object sender, EventArgs e)
        {
            var havayollari = _ucusServis.GetAll();
            cb_havayolusirketi.DataSource = havayollari.Select(Havayolu => Havayolu.HavayoluSirketi).ToList();
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            if (cb_havayolusirketi.SelectedItem != null) 
            {
                tabControl1.SelectedTab = tabPage2;
                HavayoluListele(sender, e);
            }
            else
            {
                MessageBox.Show("Lütfen bir havayolu şirketi seçin.");
            }
           
        }


        private void UcuslariListele(object sender, EventArgs e)
        {
            
            string HavayoluSirketi = cb_havayolusirketi.SelectedItem.ToString();
            lb_HavayoluSirketi.Text = HavayoluSirketi;
            var ucuslar = _ucusServis.HavayoluListele(HavayoluSirketi);
            dgv_ucus.Rows.Clear();
            foreach (var Ucus in ucuslar)
            {
                dgv_ucus.Rows.Add(Ucus.UcusId, Ucus.UcakId, Ucus.Tarih);
            }
        }

        private void lb_HavayoluSirketi_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ucus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int idColumnIndex = 0;
            int ClickedRowIndex = e.RowIndex;

            DataGridViewRow selectedRow = dgv_ucus.Rows[ClickedRowIndex];

            if (selectedRow.Cells[idColumnIndex].Value != null)
            {
                secilen_ucus = Convert.ToInt32(selectedRow.Cells[idColumnIndex].Value);
                tabControl1.SelectedTab = tabPage3;
                tabPage3_Click(null, null);
            }
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            int rowCount = 5;
            int columnCount = 10;
            

            const int KoltukGap = 5;
            const int KoltukWidth = 50;
            const int KoltukHeight = 50;

            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ".ToCharArray();
            int totalWidth = columnCount * (KoltukWidth + KoltukGap);
            int totalHeight = rowCount * (KoltukHeight + KoltukGap);
            int startX = (ClientSize.Width - totalWidth) / 2;
            int startY = (ClientSize.Height - totalHeight) / 2;
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    Button btnKoltuk = new Button();
                    btnKoltuk.Cursor = Cursors.Hand;
                    btnKoltuk.Name = $"btnSeat_{letters[row]}{col + 1}";
                    btnKoltuk.Text = $"{letters[row]}{col + 1}";
                    if (occupiedKoltuk.Contains(btnKoltuk.Text))
                    {
                        btnKoltuk.BackColor = Color.Red;
                        btnKoltuk.ForeColor = Color.White;
                    }

                    btnKoltuk.Width = KoltukWidth;
                    btnKoltuk.Height = KoltukHeight;
                    btnKoltuk.Left = startX + col * (KoltukWidth + KoltukGap);
                    btnKoltuk.Top = startY + row * (KoltukHeight + KoltukGap);

                    btnKoltuk.Click += BtnKoltuk_Click;
                    tabPage3.Controls.Add(btnKoltuk);
                }
                
             }
           
        }
        private void BtnKoltuk_Click(object sender, EventArgs e)
        {
            string KoltukAdi = ((Button)sender).Name;
            string KoltukNo = KoltukAdi.Substring(KoltukAdi.IndexOf('_') + 1);


            if (occupiedKoltuk.Contains(KoltukNo))
            {
                MessageBox.Show("Koltuk Dolu");
                return;
            }
            secilenKoltuk = KoltukNo;

            label2.Text = $"Seçilen Koltuk: {secilenKoltuk}";
        }

        private void btn_KoltukOnayla_Click(object sender, EventArgs e)
        {
            if (secilen_ucus != 0 && secilenKoltuk != null)
            {
                RezervasyonAyrıntıları(secilen_ucus, secilenKoltuk);
            }
            else
            {
                MessageBox.Show("Lütfen bir ucuş ve koltuk seçin.");
            }
        }

        public void RezervasyonAyrıntıları(int selectedUcus, string selectedKoltuk)
        {
            var selectedUcusDetails = _ucusServis.GetUcusDetailsBasedOnUcusId(selectedUcus);
            var HavayoluDetails = _ucusServis.GetHavayoluDetailsBasedOnHavayoluId(selectedHavayoluDetails.HavayoluId);

            string rezervasyonOzeti = $"Havayolu: {HavayoluDetails.HavayoluSirketi}\n" +
                                       $"Tarih: {selectedUcusDetails.Tarih}\n" +
                                       $"Koltuk: {selectedKoltuk}";

            MessageBox.Show(rezervasyonOzeti, "Bilet Detayları", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cb_havayolusirketi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
   
}


