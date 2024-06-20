namespace PL
{
    partial class ManagerPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCikis = new Button();
            dgvAlbumList = new DataGridView();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            radioButtonOnSale = new RadioButton();
            radioButtonNotSale = new RadioButton();
            textBoxAlbumName = new TextBox();
            label1 = new Label();
            labelSingerGroup = new Label();
            textBoxSinger = new TextBox();
            dateTimePickerReleaseDate = new DateTimePicker();
            labelReleaseDate = new Label();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            labelDiscount = new Label();
            textBoxDiscountRate = new TextBox();
            groupBoxAddAlbum = new GroupBox();
            labelAlbumNameText = new Label();
            dgvSearchList = new DataGridView();
            labelSearchList = new Label();
            buttonNotSaleAlbumList = new Button();
            buttonOnSaleAlbumList = new Button();
            buttonGetLastTenAddedAlbums = new Button();
            buttonDiscountAlbumLisf = new Button();
            button1 = new Button();
            groupBoxSearchCriteria = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvAlbumList).BeginInit();
            groupBoxAddAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchList).BeginInit();
            groupBoxSearchCriteria.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCikis
            // 
            buttonCikis.BackColor = Color.IndianRed;
            buttonCikis.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonCikis.Location = new Point(903, 510);
            buttonCikis.Name = "buttonCikis";
            buttonCikis.Size = new Size(207, 117);
            buttonCikis.TabIndex = 0;
            buttonCikis.Text = "ÇIKIŞ";
            buttonCikis.UseVisualStyleBackColor = false;
            buttonCikis.Click += buttonCikis_Click;
            // 
            // dgvAlbumList
            // 
            dgvAlbumList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbumList.Location = new Point(12, 32);
            dgvAlbumList.Name = "dgvAlbumList";
            dgvAlbumList.RowHeadersWidth = 51;
            dgvAlbumList.Size = new Size(700, 263);
            dgvAlbumList.TabIndex = 1;
            dgvAlbumList.CellClick += dgvAlbumList_CellClick;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Orange;
            buttonUpdate.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonUpdate.Location = new Point(882, 301);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(108, 29);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.LightGreen;
            buttonAdd.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonAdd.Location = new Point(730, 301);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(119, 29);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Ekle";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonDelete.Location = new Point(1011, 301);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(101, 29);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // radioButtonOnSale
            // 
            radioButtonOnSale.AutoSize = true;
            radioButtonOnSale.Location = new Point(117, 245);
            radioButtonOnSale.Name = "radioButtonOnSale";
            radioButtonOnSale.Size = new Size(82, 26);
            radioButtonOnSale.TabIndex = 5;
            radioButtonOnSale.TabStop = true;
            radioButtonOnSale.Text = "Satışta";
            radioButtonOnSale.UseVisualStyleBackColor = true;
            // 
            // radioButtonNotSale
            // 
            radioButtonNotSale.AutoSize = true;
            radioButtonNotSale.Location = new Point(253, 245);
            radioButtonNotSale.Name = "radioButtonNotSale";
            radioButtonNotSale.Size = new Size(124, 26);
            radioButtonNotSale.TabIndex = 6;
            radioButtonNotSale.TabStop = true;
            radioButtonNotSale.Text = "Satışta Değil";
            radioButtonNotSale.UseVisualStyleBackColor = true;
            // 
            // textBoxAlbumName
            // 
            textBoxAlbumName.Location = new Point(117, 32);
            textBoxAlbumName.Name = "textBoxAlbumName";
            textBoxAlbumName.Size = new Size(250, 28);
            textBoxAlbumName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 38);
            label1.Name = "label1";
            label1.Size = new Size(92, 22);
            label1.TabIndex = 8;
            label1.Text = "Albüm Adı:";
            // 
            // labelSingerGroup
            // 
            labelSingerGroup.AutoSize = true;
            labelSingerGroup.Location = new Point(6, 73);
            labelSingerGroup.Name = "labelSingerGroup";
            labelSingerGroup.Size = new Size(107, 22);
            labelSingerGroup.TabIndex = 9;
            labelSingerGroup.Text = "Şarkıcı/Grup:";
            // 
            // textBoxSinger
            // 
            textBoxSinger.Location = new Point(117, 69);
            textBoxSinger.Name = "textBoxSinger";
            textBoxSinger.Size = new Size(250, 28);
            textBoxSinger.TabIndex = 10;
            // 
            // dateTimePickerReleaseDate
            // 
            dateTimePickerReleaseDate.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dateTimePickerReleaseDate.Location = new Point(117, 111);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(250, 26);
            dateTimePickerReleaseDate.TabIndex = 11;
            // 
            // labelReleaseDate
            // 
            labelReleaseDate.AutoSize = true;
            labelReleaseDate.Location = new Point(19, 115);
            labelReleaseDate.Name = "labelReleaseDate";
            labelReleaseDate.Size = new Size(98, 22);
            labelReleaseDate.TabIndex = 12;
            labelReleaseDate.Text = "Çıkış Tarihi:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(58, 156);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(53, 22);
            labelPrice.TabIndex = 13;
            labelPrice.Text = "Fiyat:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(117, 153);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(250, 28);
            textBoxPrice.TabIndex = 14;
            textBoxPrice.KeyPress += textBoxPrice_KeyPress;
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(4, 202);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(115, 22);
            labelDiscount.TabIndex = 15;
            labelDiscount.Text = "İndirim Oranı:";
            // 
            // textBoxDiscountRate
            // 
            textBoxDiscountRate.Location = new Point(117, 199);
            textBoxDiscountRate.Name = "textBoxDiscountRate";
            textBoxDiscountRate.Size = new Size(250, 28);
            textBoxDiscountRate.TabIndex = 16;
            textBoxDiscountRate.KeyPress += textBoxDiscountRate_KeyPress;
            // 
            // groupBoxAddAlbum
            // 
            groupBoxAddAlbum.BackColor = SystemColors.ActiveCaption;
            groupBoxAddAlbum.Controls.Add(label1);
            groupBoxAddAlbum.Controls.Add(textBoxDiscountRate);
            groupBoxAddAlbum.Controls.Add(radioButtonOnSale);
            groupBoxAddAlbum.Controls.Add(labelDiscount);
            groupBoxAddAlbum.Controls.Add(radioButtonNotSale);
            groupBoxAddAlbum.Controls.Add(textBoxPrice);
            groupBoxAddAlbum.Controls.Add(textBoxAlbumName);
            groupBoxAddAlbum.Controls.Add(labelPrice);
            groupBoxAddAlbum.Controls.Add(labelSingerGroup);
            groupBoxAddAlbum.Controls.Add(labelReleaseDate);
            groupBoxAddAlbum.Controls.Add(textBoxSinger);
            groupBoxAddAlbum.Controls.Add(dateTimePickerReleaseDate);
            groupBoxAddAlbum.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic);
            groupBoxAddAlbum.Location = new Point(730, 12);
            groupBoxAddAlbum.Name = "groupBoxAddAlbum";
            groupBoxAddAlbum.Size = new Size(380, 283);
            groupBoxAddAlbum.TabIndex = 17;
            groupBoxAddAlbum.TabStop = false;
            groupBoxAddAlbum.Text = "Album Ekle";
            // 
            // labelAlbumNameText
            // 
            labelAlbumNameText.AutoSize = true;
            labelAlbumNameText.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAlbumNameText.Location = new Point(12, 0);
            labelAlbumNameText.Name = "labelAlbumNameText";
            labelAlbumNameText.Size = new Size(181, 29);
            labelAlbumNameText.TabIndex = 19;
            labelAlbumNameText.Text = "ALBUM LISTESI";
            // 
            // dgvSearchList
            // 
            dgvSearchList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchList.Location = new Point(12, 353);
            dgvSearchList.Name = "dgvSearchList";
            dgvSearchList.RowHeadersWidth = 51;
            dgvSearchList.Size = new Size(457, 274);
            dgvSearchList.TabIndex = 20;
            // 
            // labelSearchList
            // 
            labelSearchList.AutoSize = true;
            labelSearchList.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelSearchList.Location = new Point(12, 318);
            labelSearchList.Name = "labelSearchList";
            labelSearchList.Size = new Size(207, 29);
            labelSearchList.TabIndex = 21;
            labelSearchList.Text = "ARAMA LISTELERİ";
            // 
            // buttonNotSaleAlbumList
            // 
            buttonNotSaleAlbumList.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonNotSaleAlbumList.Location = new Point(13, 27);
            buttonNotSaleAlbumList.Name = "buttonNotSaleAlbumList";
            buttonNotSaleAlbumList.Size = new Size(363, 45);
            buttonNotSaleAlbumList.TabIndex = 22;
            buttonNotSaleAlbumList.Text = "Satışı Durmuş Albümler";
            buttonNotSaleAlbumList.UseVisualStyleBackColor = true;
            buttonNotSaleAlbumList.Click += buttonNotSaleAlbumList_Click;
            // 
            // buttonOnSaleAlbumList
            // 
            buttonOnSaleAlbumList.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonOnSaleAlbumList.Location = new Point(13, 94);
            buttonOnSaleAlbumList.Name = "buttonOnSaleAlbumList";
            buttonOnSaleAlbumList.Size = new Size(364, 46);
            buttonOnSaleAlbumList.TabIndex = 23;
            buttonOnSaleAlbumList.Text = "Satışı Devam Eden Albümler";
            buttonOnSaleAlbumList.UseVisualStyleBackColor = true;
            buttonOnSaleAlbumList.Click += buttonOnSaleAlbumList_Click;
            // 
            // buttonGetLastTenAddedAlbums
            // 
            buttonGetLastTenAddedAlbums.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonGetLastTenAddedAlbums.Location = new Point(13, 157);
            buttonGetLastTenAddedAlbums.Name = "buttonGetLastTenAddedAlbums";
            buttonGetLastTenAddedAlbums.Size = new Size(364, 46);
            buttonGetLastTenAddedAlbums.TabIndex = 24;
            buttonGetLastTenAddedAlbums.Text = "Sisteme Eklenen En son 10 Albüm";
            buttonGetLastTenAddedAlbums.UseVisualStyleBackColor = true;
            buttonGetLastTenAddedAlbums.Click += buttonGetLastTenAddedAlbums_Click;
            // 
            // buttonDiscountAlbumLisf
            // 
            buttonDiscountAlbumLisf.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonDiscountAlbumLisf.Location = new Point(13, 219);
            buttonDiscountAlbumLisf.Name = "buttonDiscountAlbumLisf";
            buttonDiscountAlbumLisf.Size = new Size(363, 46);
            buttonDiscountAlbumLisf.TabIndex = 25;
            buttonDiscountAlbumLisf.Text = "İndirimdeki Albümler";
            buttonDiscountAlbumLisf.UseVisualStyleBackColor = true;
            buttonDiscountAlbumLisf.Click += buttonDiscountAlbumLisf_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(475, 353);
            button1.Name = "button1";
            button1.Size = new Size(20, 274);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBoxSearchCriteria
            // 
            groupBoxSearchCriteria.BackColor = SystemColors.ActiveBorder;
            groupBoxSearchCriteria.Controls.Add(buttonNotSaleAlbumList);
            groupBoxSearchCriteria.Controls.Add(buttonOnSaleAlbumList);
            groupBoxSearchCriteria.Controls.Add(buttonGetLastTenAddedAlbums);
            groupBoxSearchCriteria.Controls.Add(buttonDiscountAlbumLisf);
            groupBoxSearchCriteria.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBoxSearchCriteria.Location = new Point(515, 353);
            groupBoxSearchCriteria.Name = "groupBoxSearchCriteria";
            groupBoxSearchCriteria.Size = new Size(382, 271);
            groupBoxSearchCriteria.TabIndex = 27;
            groupBoxSearchCriteria.TabStop = false;
            groupBoxSearchCriteria.Text = "Arama Kriterleri";
            // 
            // ManagerPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 636);
            Controls.Add(groupBoxSearchCriteria);
            Controls.Add(button1);
            Controls.Add(labelSearchList);
            Controls.Add(dgvSearchList);
            Controls.Add(labelAlbumNameText);
            Controls.Add(groupBoxAddAlbum);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(buttonUpdate);
            Controls.Add(dgvAlbumList);
            Controls.Add(buttonCikis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerPanel";
            Load += ManagerPanel_Load;
            MouseClick += ManagerPanel_MouseClick;
            MouseDown += ManagerPanel_MouseDown;
            MouseMove += ManagerPanel_MouseMove;
            MouseUp += ManagerPanel_MouseUp;
            ((System.ComponentModel.ISupportInitialize)dgvAlbumList).EndInit();
            groupBoxAddAlbum.ResumeLayout(false);
            groupBoxAddAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchList).EndInit();
            groupBoxSearchCriteria.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCikis;
        private DataGridView dgvAlbumList;
        private Button buttonUpdate;
        private Button buttonAdd;
        private Button buttonDelete;
        private RadioButton radioButtonOnSale;
        private RadioButton radioButtonNotSale;
        private TextBox textBoxAlbumName;
        private Label label1;
        private Label labelSingerGroup;
        private TextBox textBoxSinger;
        private DateTimePicker dateTimePickerReleaseDate;
        private Label labelReleaseDate;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Label labelDiscount;
        private TextBox textBoxDiscountRate;
        private GroupBox groupBoxAddAlbum;
        private Label labelAlbumNameText;
        private DataGridView dgvSearchList;
        private Label labelSearchList;
        private Button buttonNotSaleAlbumList;
        private Button buttonOnSaleAlbumList;
        private Button buttonGetLastTenAddedAlbums;
        private Button buttonDiscountAlbumLisf;
        private Button button1;
        private GroupBox groupBoxSearchCriteria;
    }
}