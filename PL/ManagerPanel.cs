using BLL;
using Microsoft.EntityFrameworkCore;
using MODELS.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class ManagerPanel : Form
    {
        public ManagerPanel()
        {
            InitializeComponent();
            albumService = new();
        }
        AlbumService albumService;

        private void ManagerPanel_Load(object sender, EventArgs e) //Form yuklenırken datagridview gelsin ve diger istenilenler
        {
            DataGridWiew();
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            albumService = new();
        }

        private void buttonCikis_Click(object sender, EventArgs e) //Uygulamadan cıkıs
        {
            DialogResult result = MessageBox.Show(" Çıkış yapacaksınız, Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        // Form sürükleme islemi için gerekli degisken
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void ManagerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Form  üzerine tiklandiginda gerçeklesen olay.
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ManagerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            // Form üzerinde sürüklendiginde gerçeklesen olay.
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ManagerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            // Form üzerinden kaldırıldıgında gerceklesen olay
            dragging = false;
        }

        private void DataGridWiew()
        {
            // Veritabanından tüm albümleri çeken ve DataGridView'e verileri ata
            dgvAlbumList.DataSource = albumService.GetAllAlbums();
            // Satır başlıklarını gizle



            dgvAlbumList.RowHeadersVisible = false;
            // AlbumId ve Albumler sütunlarını gizle

            dgvAlbumList.Columns["AlbumId"].Visible = false;
            dgvAlbumList.Columns["AlbumManagers"].Visible = false;
            dgvAlbumList.Columns["ModifiedDate"].Visible = false;
            dgvAlbumList.Columns["DeletedDate"].Visible = false;
            dgvAlbumList.Columns["Status"].Visible = false;
            dgvAlbumList.Columns["CreationDate"].Visible = false;

            // Satırların otomatik olarak boyutlandır
            dgvAlbumList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Sütunların otomatik olarak boyutlandır
            dgvAlbumList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvAlbumList_CellClick(object sender, DataGridViewCellEventArgs e) // Tıklanınca grupbox a gelecek verılerın ataması
        {
            buttonUpdate.Enabled = true;
            buttonAdd.Enabled = false;
            buttonDelete.Enabled = true;
            textBoxAlbumName.Text = dgvAlbumList.CurrentRow.Cells[1].Value.ToString();
            textBoxSinger.Text = dgvAlbumList.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerReleaseDate.Value = Convert.ToDateTime(dgvAlbumList.CurrentRow.Cells[3].Value);
            textBoxPrice.Text = dgvAlbumList.CurrentRow.Cells[4].Value.ToString();
            textBoxDiscountRate.Text = dgvAlbumList.CurrentRow.Cells[5].Value.ToString();
            if (dgvAlbumList.CurrentRow.Cells[6].Value.ToString() == "True")
            {
                radioButtonOnSale.Checked = true;
            }
            else
            {
                radioButtonNotSale.Checked = true;
            }
        }
        public static void ClearAllTexBoxes(GroupBox groupBox) //GrupBoxdaki textboxların textlerini sıfırlar
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e) //Veri silme Butonu
        {
            Album album = (Album)dgvAlbumList.CurrentRow.DataBoundItem;
            albumService.Delete(album.AlbumId);
            MessageBox.Show("Albüm başarıyla silindi.");

            DataGridWiew();
            ClearAllTexBoxes(groupBoxAddAlbum); //Silinen akbumun degerlerini textbox, checkbox, vs den silmeler yapıyor
            dateTimePickerReleaseDate.Value = DateTime.Now;
            radioButtonNotSale.Checked = false;
            radioButtonOnSale.Checked = false;
            buttonUpdate.Enabled = false;
            buttonAdd.Enabled = true;
            buttonDelete.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e) //Veri ekleme butonu
        {


            if (string.IsNullOrWhiteSpace(textBoxAlbumName.Text))   // Album adi boşmu kontrolü
            {
                MessageBox.Show("Album adi boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSinger.Text))   // Şarkıcı adi boşmu kontrolü
            {
                MessageBox.Show("Şarkıcı adi boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateTimePickerReleaseDate.Value == null) //tarih secılmez ise bugunun tarihini veriyoruz.
            {
                dateTimePickerReleaseDate.Value = DateTime.Now;
            }

            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))   // Album Fiyatı boşmu kontrolü
            {
                MessageBox.Show("Album fiyati boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            int priceValue;
            bool isNumeric = int.TryParse(textBoxPrice.Text, out priceValue);
            if (!isNumeric || priceValue < 0 || priceValue > 3000)        //Fiyat kontrolü ve numerik değer kontrolü
            {
                MessageBox.Show("Fiyat 0 ile 3000 TL Arasında olmalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int DiscountValue;
            bool isNumericValue = int.TryParse(textBoxDiscountRate.Text, out DiscountValue); //İndirim verisi kontrolu
            if (!isNumericValue)
            {
                MessageBox.Show("Lütfen sayısal bir değer girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DiscountValue < 0 || DiscountValue > 90)
            {
                MessageBox.Show("Indırım oranı 0 - 90 arası olmak zorunda.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Album album = new Album(); //Verileri olusturudumuz albume atıyoruz

            album.AlbumName = textBoxAlbumName.Text;
            album.AlbumSingerGroup = textBoxSinger.Text;
            album.AlbumPrice = Convert.ToDouble(textBoxPrice.Text);
            album.DiscountRate = double.Parse(textBoxDiscountRate.Text);
            album.AlbumReleaseDate = dateTimePickerReleaseDate.Value;

            if (radioButtonOnSale.Checked == true)
            {
                album.IsItOnSale = true;
            }
            else if (radioButtonNotSale.Checked == true)

            {
                album.IsItOnSale = false;
            }
            else
            {
                MessageBox.Show("Lütfen Album Satışda mı Değil mi Seçiniz ?.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            albumService.Add(album); //Database eklıyoruz

            MessageBox.Show("Album Başarılı bir şekilde eklendi.");
            DataGridWiew();
            ClearAllTexBoxes(groupBoxAddAlbum);
            dateTimePickerReleaseDate.Value = DateTime.Now;
            radioButtonNotSale.Checked = false;
            radioButtonOnSale.Checked = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxAlbumName.Text))   // Album adi boşmu kontrolü
            {
                MessageBox.Show("Album adi boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSinger.Text))   // Şarkıcı adi boşmu kontrolü
            {
                MessageBox.Show("Şarkıcı adi boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateTimePickerReleaseDate.Value == null) //tarih secılmez ise bugunun tarihini veriyoruz.
            {
                dateTimePickerReleaseDate.Value = DateTime.Now;
            }

            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))   // Album Fiyatı boşmu kontrolü
            {
                MessageBox.Show("Album fiyatı boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int priceValue;
            bool isNumeric = int.TryParse(textBoxPrice.Text, out priceValue);
            if (!isNumeric || priceValue < 0 || priceValue > 3000)        //Fiyat kontrolü ve numerik değer kontrolü
            {
                MessageBox.Show("Fiyat 0 ile 3000 TL Arasında olmalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int DiscountValue;
            bool isNumericValue = int.TryParse(textBoxDiscountRate.Text, out DiscountValue); //İndirim verisi kontrolu
            if (!isNumericValue)
            {
                MessageBox.Show("Lütfen sayısal bir değer girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DiscountValue < 0 || DiscountValue > 90)
            {
                MessageBox.Show("Indırım oranı 0 - 90 arası olmak zorunda.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Album album = (Album)dgvAlbumList.CurrentRow.DataBoundItem; //Album turunden album olusturyoruz verileri atıyoruz

            album.AlbumSingerGroup = textBoxSinger.Text;
            album.AlbumName = textBoxAlbumName.Text;
            album.AlbumReleaseDate = dateTimePickerReleaseDate.Value;
            album.AlbumPrice = Convert.ToDouble(textBoxPrice.Text);
            album.DiscountRate = double.Parse(textBoxDiscountRate.Text);

            if (radioButtonOnSale.Checked == true)
            {
                album.IsItOnSale = true;
            }
            else if (radioButtonNotSale.Checked == true)

            {
                album.IsItOnSale = false;
            }
            else
            {
                MessageBox.Show("Lütfen Urun Satışta mı değil mi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            albumService.Update(album); //secili album guncelleniyor
            MessageBox.Show("Albüm başarıyla güncellendi.");

            DataGridWiew();
            ClearAllTexBoxes(groupBoxAddAlbum);
            dateTimePickerReleaseDate.Value = DateTime.Now;
            radioButtonNotSale.Checked = false;
            radioButtonOnSale.Checked = false;
            buttonUpdate.Enabled = false;
            buttonAdd.Enabled = true;
            buttonDelete.Enabled = false;

        }

        private void buttonNotSaleAlbumList_Click(object sender, EventArgs e)
        {
            dgvSearchList.DataSource = albumService.GetAlbumsNotSale(); // satısda olmayan albumlerı dgvListesine atıyor.

            dgvSearchList.RowHeadersVisible = false;
            // AlbumId ve Albumler sütunlarını gizle

            dgvSearchList.Columns["AlbumId"].Visible = false;
            dgvSearchList.Columns["AlbumManagers"].Visible = false;
            dgvSearchList.Columns["ModifiedDate"].Visible = false;
            dgvSearchList.Columns["DeletedDate"].Visible = false;
            dgvSearchList.Columns["Status"].Visible = false;
            dgvSearchList.Columns["CreationDate"].Visible = false;
            dgvSearchList.Columns["AlbumReleaseDate"].Visible = false;
            dgvSearchList.Columns["AlbumPrice"].Visible = false;
            dgvSearchList.Columns["DiscountRate"].Visible = false;
            dgvSearchList.Columns["IsItOnSale"].Visible = false;

            dgvSearchList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Sütunların otomatik olarak boyutlandır
            dgvSearchList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void buttonOnSaleAlbumList_Click(object sender, EventArgs e)
        {
            dgvSearchList.DataSource = albumService.GetAlbumsOnSale(); // satısda olan albumlerı dgvListesine atıyor.
        }

        private void buttonGetLastTenAddedAlbums_Click(object sender, EventArgs e)
        {
            dgvSearchList.DataSource = albumService.GetLastTenAddedAlbums(); // sisteme eklenen en son 10 albumu dgvListesine atıyor.
        }

        private void buttonDiscountAlbumLisf_Click(object sender, EventArgs e)
        {
            dgvSearchList.DataSource = albumService.GetAlbumsOnSaleOrderByDiscount(); // indirimdeki albumleri dgvListesine atıyor.
        }

        private void ManagerPanel_MouseClick(object sender, MouseEventArgs e) // formda bir yer tıklanınca secimi kaldırıyor ve diğer istenilen işlemleri yapıyor
        {
            dgvAlbumList.ClearSelection();
            dgvSearchList.ClearSelection();
            buttonAdd.Enabled = true;
            ClearAllTexBoxes(groupBoxAddAlbum);
            dateTimePickerReleaseDate.Value = DateTime.Now;
            radioButtonNotSale.Checked = false;
            radioButtonOnSale.Checked = false;
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                // Eğer girilen karakter sayısal değilse, bunun bir kontrol karakteri olup olmadığını kontrol edin
                if (!char.IsControl(e.KeyChar))
                {
                    // Eğer girilen karakter ne sayısal ne de kontrol karakteri ise, kullanıcıya bir uyarı mesajı gösterin
                    MessageBox.Show("Lütfen sadece sayısal karakterler girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Bu karakterin işlenmesini durdurun (TextBox'a eklenmesini engelleyin)
                    e.Handled = true;
                }
            }
        }

        private void textBoxDiscountRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                // Eğer girilen karakter sayısal değilse, bunun bir kontrol karakteri olup olmadığını kontrol edin
                if (!char.IsControl(e.KeyChar))
                {
                    // Eğer girilen karakter ne sayısal ne de kontrol karakteri ise, kullanıcıya bir uyarı mesajı gösterin
                    MessageBox.Show("Lütfen sadece sayısal karakterler girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Bu karakterin işlenmesini durdurun (TextBox'a eklenmesini engelleyin)
                    e.Handled = true;
                }
            }
        }
    }
}
