namespace Piekarnie
{
    partial class OknoZamowienia
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
            label1 = new Label();
            inpPodmiot = new ComboBox();
            inpStatus = new ComboBox();
            inpData = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            dataGridViewProdukty = new DataGridView();
            label4 = new Label();
            btnDodaj = new Button();
            btnEdytuj = new Button();
            btnUsun = new Button();
            ID = new DataGridViewTextBoxColumn();
            Nazwa = new DataGridViewTextBoxColumn();
            Ilosc = new DataGridViewTextBoxColumn();
            Cena = new DataGridViewTextBoxColumn();
            Wartosc = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdukty).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 15);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Podmiot:";
            // 
            // inpPodmiot
            // 
            inpPodmiot.FormattingEnabled = true;
            inpPodmiot.Location = new Point(113, 12);
            inpPodmiot.Name = "inpPodmiot";
            inpPodmiot.Size = new Size(694, 23);
            inpPodmiot.TabIndex = 1;
            inpPodmiot.DropDown += inpPodmiot_DropDown;
            // 
            // inpStatus
            // 
            inpStatus.FormattingEnabled = true;
            inpStatus.Location = new Point(113, 41);
            inpStatus.Name = "inpStatus";
            inpStatus.Size = new Size(149, 23);
            inpStatus.TabIndex = 2;
            inpStatus.DropDown += inpStatus_DropDown;
            // 
            // inpData
            // 
            inpData.Location = new Point(378, 41);
            inpData.Name = "inpData";
            inpData.Size = new Size(200, 23);
            inpData.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 44);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 44);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Data:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnZapisz);
            panel1.Controls.Add(btnAnuluj);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 404);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 51);
            panel1.TabIndex = 6;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(740, 16);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(75, 23);
            btnZapisz.TabIndex = 8;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(12, 16);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(75, 23);
            btnAnuluj.TabIndex = 7;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProdukty
            // 
            dataGridViewProdukty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdukty.Columns.AddRange(new DataGridViewColumn[] { ID, Nazwa, Ilosc, Cena, Wartosc });
            dataGridViewProdukty.Location = new Point(113, 120);
            dataGridViewProdukty.Name = "dataGridViewProdukty";
            dataGridViewProdukty.RowTemplate.Height = 25;
            dataGridViewProdukty.Size = new Size(694, 238);
            dataGridViewProdukty.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 120);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 8;
            label4.Text = "Produkty:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(113, 364);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Location = new Point(194, 364);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(75, 23);
            btnEdytuj.TabIndex = 5;
            btnEdytuj.Text = "Edytuj";
            btnEdytuj.UseVisualStyleBackColor = true;
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(275, 364);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(75, 23);
            btnUsun.TabIndex = 6;
            btnUsun.Text = "Usuń";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Nazwa
            // 
            Nazwa.DataPropertyName = "Nazwa";
            Nazwa.HeaderText = "Produkt";
            Nazwa.Name = "Nazwa";
            Nazwa.ReadOnly = true;
            Nazwa.Width = 300;
            // 
            // Ilosc
            // 
            Ilosc.DataPropertyName = "ilosc";
            Ilosc.HeaderText = "Ilość";
            Ilosc.Name = "Ilosc";
            Ilosc.ReadOnly = true;
            // 
            // Cena
            // 
            Cena.DataPropertyName = "cena";
            Cena.HeaderText = "Cena";
            Cena.Name = "Cena";
            Cena.ReadOnly = true;
            // 
            // Wartosc
            // 
            Wartosc.DataPropertyName = "wartosc";
            Wartosc.HeaderText = "Wartość";
            Wartosc.Name = "Wartosc";
            Wartosc.ReadOnly = true;
            // 
            // OknoZamowienia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAnuluj;
            ClientSize = new Size(827, 455);
            ControlBox = false;
            Controls.Add(btnUsun);
            Controls.Add(btnEdytuj);
            Controls.Add(btnDodaj);
            Controls.Add(label4);
            Controls.Add(dataGridViewProdukty);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inpData);
            Controls.Add(inpStatus);
            Controls.Add(inpPodmiot);
            Controls.Add(label1);
            MaximumSize = new Size(843, 494);
            MinimumSize = new Size(843, 494);
            Name = "OknoZamowienia";
            Text = "Zamówienie";
            Shown += OknoZamowienia_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdukty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox inpPodmiot;
        private ComboBox inpStatus;
        private DateTimePicker inpData;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button btnZapisz;
        private Button btnAnuluj;
        private DataGridView dataGridViewProdukty;
        private Label label4;
        private Button btnDodaj;
        private Button btnEdytuj;
        private Button btnUsun;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nazwa;
        private DataGridViewTextBoxColumn Ilosc;
        private DataGridViewTextBoxColumn Cena;
        private DataGridViewTextBoxColumn Wartosc;
    }
}