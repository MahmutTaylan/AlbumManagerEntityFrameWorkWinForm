using BLL;
using MODELS.Concrete;
using MODELS.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class CreateManagerScreen : Form
    {
        public CreateManagerScreen()
        {
            InitializeComponent();
            managerService = new();
        }

        ManagerService managerService;

        /// <summary>
        /// Formdaki textbox ve checked olanları sıfırlayan method
        /// </summary>
        public void FormClear()
        {
            textBoxEmail.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxComfirmPassword.Text = string.Empty;
            checkBoxShowPassword.Checked = false;
        }

        /// <summary>
        /// Mail adresi formatını kontrol eden method
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
      
        private void CreateManagerScreen_Load(object sender, EventArgs e)
        {
            // Parola girişi alanları için karakterlerin gizli olması sağlanıyor.
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxComfirmPassword.UseSystemPasswordChar = true;
        }

        // Fare sürükleme işlemi için gerekli değişkenler.
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            // Fare panel üzerine tıklandığında gerçekleşen olay.
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            // Fare panel üzerinde sürüklendiğinde gerçekleşen olay.
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            // Fare panel üzerinden kaldırıldığında gerçekleşen olay.
            dragging = false;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // "checkBoxShowPassword" işaretlendiğinde veya işaret kaldırıldığında gerçekleşen olay.
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxComfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxComfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e) //Formu kapatıyor
        {
            this.Close();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            // E-posta formatını kontrol etmek için düzenli ifade
            string pattern = @"^[\w-\.]+@([\w-]+\.)+com$";
            if (Regex.IsMatch(textBoxEmail.Text, pattern) && !managerService.CheckEmailEntries(textBoxEmail.Text))
            {
                textBoxEmail.BackColor = Color.LightGreen;
            }
            else
            {
                // Metin kutusunun arka plan rengini kırmızı yaparak, formatın yanlış olduğunu göster
                textBoxEmail.BackColor = Color.Salmon;
            }

        }

        private void buttonRegister_Click(object sender, EventArgs e) //Kayıt butonuna basınca 
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))   // Mail boşmu kontrolü
            {
                MessageBox.Show("Email adresi boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
            if (textBoxEmail.BackColor == Color.Salmon)         //arkaplan rengi kırımızı ise hata verir
            {
                MessageBox.Show("Email adresini hatalı formatta girdiniz. (***@***.com) veya Email adresi sisteme zaten kayıtlı ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxName.Text))    //ad boşmu kontrolü
            {
                MessageBox.Show("İsim alanı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int spaceCount = textBoxName.Text.Count(c => c == ' ');     //ad karakter kontrolü
            bool isValidTurkishLettersAndSpaces = Regex.IsMatch(textBoxName.Text, @"^[a-zA-ZığüşöçİĞÜŞÖÇ ]+$");

            if (!isValidTurkishLettersAndSpaces || spaceCount > 2)  //boşluk sayısı kontrolü
            {
                MessageBox.Show("İsim alanı sadece harf (Türkçe harfler dahil) ve en fazla 2 boşluk içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))    //soyad boşluk kontrolü
            {
                MessageBox.Show("Soyadı boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int spaceCount2 = textBoxLastName.Text.Count(c => c == ' ');  //soyad karakter kontrolü
            bool isValidTurkishLettersAndSpaces2 = Regex.IsMatch(textBoxLastName.Text, @"^[a-zA-ZığüşöçİĞÜŞÖÇ ]+$");

            if (!isValidTurkishLettersAndSpaces2 || spaceCount2 > 2)   //boşluk sayısı kontrolü
            {
                MessageBox.Show("\"İsim alanı sadece harf (Türkçe harfler dahil) ve en fazla 2 boşluk içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))    //Şifre bos mu kontrolü
            {
                MessageBox.Show("Şifre alanı boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CheckPasswordCriteria(textBoxPassword.Text)) // Şifre Kontrol
            {
                MessageBox.Show("Şifre en az 8 harfden olusmalı. Bunların en az 2 büyük harf, 3 küçük harf ve 2 özel karakter(!:+*) içermelidir ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxComfirmPassword.Text)) // tekrar şifresi boşluk kontrolü
            {
                MessageBox.Show("Şifre Tekrar alanı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxPassword.Text != textBoxComfirmPassword.Text)  //confirm password ile password eşitliğine bakılır
            {
                MessageBox.Show("2 şifre eşleşmiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Manager manager = new Manager();

            manager.Status = Status.Active;
            manager.Email = textBoxEmail.Text;
            manager.ManagerName = textBoxName.Text;
            manager.ManagerLastName = textBoxLastName.Text;
            manager.Password = Methods.Sha256_hash(textBoxPassword.Text); //Şifre kriptolanıyor ve manager şifresine atanıyor

            managerService.Add(manager); //Yönetici verisi eklendi

            MessageBox.Show("Yönetici Kaydı Başarılı...", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormClear();
        }

        /// <summary>
        /// Gerekli şifre kontrollerini yapan method
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        static bool CheckPasswordCriteria(string password)
        {
            // En az 8 karakter uzunluğunda olmalıdır.
            if (password.Length < 8)
                return false;

            // En az 2 büyük harf içermelidir.
            if (!password.Any(char.IsUpper) || password.Count(char.IsUpper) < 2)
                return false;

            // En az 3 küçük harf içermelidir.
            if (!password.Any(char.IsLower) || password.Count(char.IsLower) < 3)
                return false;

            // ! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 2 tanesi içermelidir.
            string specialCharacters = "!:+*";
            int specialCount = password.Count(c => specialCharacters.Contains(c));
            if (specialCount < 2)
                return false;

            return true;
        }
    }
}
