using BLL;
using Microsoft.VisualBasic.ApplicationServices;
using MODELS.Concrete;
using MODELS.Enums;

namespace PL
{
    public partial class ManagerLoginScreen : Form
    {
        public ManagerLoginScreen()
        {
            InitializeComponent();
            managerService = new();
        }

        ManagerService managerService;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int control = 0;

            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPassword.Text)) //Bos deger kontrolu
            {
                MessageBox.Show("Kullanici adi veya Sifre Bos birakilamaz", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Tüm kullanicilari kontrol et
            foreach (Manager ma in managerService.GetAll())
            {
                //kullanici bilgisi kontrolü yapiliyor. parola databasedeki gibi sifreli hale cevrilip kontrol ediliyor.
                if (ma.Email == textBoxEmail.Text && ma.Password == Methods.Sha256_hash(textBoxPassword.Text) && ma.Status != Status.Passive)
                {
                    // Yonetici Panel formunu baslat, bu formu gizle
                    ManagerPanel managerPanelForm = new ManagerPanel();
                    managerPanelForm.Show();
                    control = 1;
                    this.Hide();
                }
            }

            if (control == 0) // Kontrol degiskeni hala 0 ise, yanlis kullanici girisi
            {
                MessageBox.Show("Hatali Giris Yaptiniz.", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBoxEmail.Text = string.Empty;
                textBoxPassword.Text = string.Empty;
            }
        }

        private void buttonCreateNewManager_Click(object sender, EventArgs e) //Yönetici olusturma ekran?na geçi?
        {
            CreateManagerScreen createForm = new CreateManagerScreen();
            this.Hide();
            createForm.ShowDialog();
            this.Show();
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close(); // formu kapat

        }

        // Fare sürükleme islemi için gerekli degisken
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            // Fare panel üzerine tiklandiginda gerçeklesen olay.
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            // Fare panel üzerinde sürüklendiginde gerçeklesen olay.
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            // Fare panel üzerinden kald?r?ld?g?nda gerceklesen olay
            dragging = false;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)  // "checkBoxShowPassword" i?aretlendi?inde veya i?aret kald?r?ld???nda gerçekle?en olay.
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void ManagerLoginScreen_Load_1(object sender, EventArgs e)
        {
            textBoxEmail.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            checkBoxShowPassword.Checked = false;
            textBoxPassword.UseSystemPasswordChar = true; //Parola * seklinde göster...
        }
    }
}
