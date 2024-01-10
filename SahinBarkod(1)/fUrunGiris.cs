using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fUrunGiris : Form
    {
        public fUrunGiris()
        {
            InitializeComponent();
        }
        Barkod1Entities db = new Barkod1Entities();
        private void bstandart5_Click(object sender, EventArgs e)
        {

        }
        public void tbarkodGetir(string barkod)
        {
            if (db.CokluB.Any(a => a.Barkod == barkod))
            {
                int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkod).Select(b => b.Urunid).FirstOrDefault());
                var urun = db.Urun.Where(a => a.Urunid == urunid).SingleOrDefault();
                tUrunAdi.Text = urun.UrunAd;
                tAcıklama.Text = urun.Acıklama;
                cmbUrunGrubu.Text = urun.UrunGrup;
                tAlısFiyati.Text = urun.AlisFiyat.ToString();
                tSatisFiyati.Text = urun.SatisFiyat.ToString();
                tSatisFiyati2.Text = urun.SatisFiyat2.ToString();
                tSatisFiyati3.Text = urun.SatisFiyat3.ToString();
                tSatisFiyati4.Text = urun.SatisFiyat4.ToString();
                tSatisFiyati5.Text = urun.SatisFiyat5.ToString();
                

                tMiktar.Text = urun.Miktar.ToString();
                tKdvOrani.Text = urun.KdvOrani.ToString();
                tUrunid.Text = urun.Urunid.ToString();
                if (urun.Birim == "kg")
                {
                    chUrunTipi.Checked = true;
                }
                else
                {
                    chUrunTipi.Checked = false;
                }

                barkodliste(GetListBarkod());

            }
            else
            {
                MessageBox.Show("Ürün kayıtlı değil.Kaydet");
            }
        }
        public void tbarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tnumeric1.Clear();
                string barkod = tbarkod.Text.Trim();
                if (db.CokluB.Any(a => a.Barkod == barkod))
                {
                    int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkod).Select(b => b.Urunid).FirstOrDefault());
                    var urun = db.Urun.Where(a => a.Urunid == urunid).SingleOrDefault();
                    tUrunAdi.Text = urun.UrunAd;
                    tAcıklama.Text = urun.Acıklama;
                    cmbUrunGrubu.Text = urun.UrunGrup;
                    tAlısFiyati.Text = urun.AlisFiyat.ToString();
                    tSatisFiyati.Text = urun.SatisFiyat.ToString();
                    tSatisFiyati2.Text = urun.SatisFiyat2.ToString();
                    tSatisFiyati3.Text = urun.SatisFiyat3.ToString();
                    tSatisFiyati4.Text = urun.SatisFiyat4.ToString();
                    tSatisFiyati5.Text = urun.SatisFiyat5.ToString();
                    tMiktar.Text = urun.Miktar.ToString();
                    tKdvOrani.Text = urun.KdvOrani.ToString();
                    tUrunid.Text = urun.Urunid.ToString();
                    if (urun.Birim == "kg")
                    {
                        chUrunTipi.Checked = true;
                    }
                    else
                    {
                        chUrunTipi.Checked = false;
                    }

                    barkodliste(GetListBarkod());

                }
                else
                {
                    MessageBox.Show("Ürün kayıtlı değil.Kaydet");
                }
                
            }
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (tbarkod.Text != "" && tUrunAdi.Text != "" && tAlısFiyati.Text != "" && tSatisFiyati.Text != "" && tKdvOrani.Text != "" && tMiktar.Text != "")
            {
                int UrunId = Convert.ToInt32(db.CokluB.Where(x => x.Barkod == tbarkod.Text).Select(s => s.Urunid).FirstOrDefault());
                if (tbarkod.Text.Length < 3)
                {
                    temizle();
                    MessageBox.Show("Id En Az İki Karakter İçermelidir.");
                    return;
                }
                if (db.CokluB.Any(a => a.Barkod == tbarkod.Text))
                {
                    var guncelle = db.Urun.Where(a => a.Urunid == UrunId).SingleOrDefault();
                    guncelle.UrunAd = tUrunAdi.Text;
                    guncelle.UrunGrup = cmbUrunGrubu.Text;
                    guncelle.Acıklama = tAcıklama.Text;
                    guncelle.AlisFiyat = islemler.DoubleYap(tAlısFiyati.Text);
                    guncelle.SatisFiyat = islemler.DoubleYap(tSatisFiyati.Text);
                    guncelle.SatisFiyat2 = islemler.DoubleYap(tSatisFiyati2.Text);
                    guncelle.SatisFiyat3 = islemler.DoubleYap(tSatisFiyati3.Text);
                    guncelle.SatisFiyat4 = islemler.DoubleYap(tSatisFiyati4.Text);
                    guncelle.SatisFiyat5 = islemler.DoubleYap(tSatisFiyati5.Text);
                    guncelle.KdvOrani = Convert.ToInt16(tKdvOrani.Text);
                    guncelle.KdvTutari = Math.Round(islemler.DoubleYap(tSatisFiyati.Text) * Convert.ToInt16(tKdvOrani.Text) / 100, 2);
                    guncelle.Miktar += Convert.ToDouble(tMiktar.Text);
                    guncelle.Onay = true;
                    if (chUrunTipi.Checked)
                    {
                        guncelle.Birim = "kg";
                    }
                    else
                    {
                        guncelle.Birim = "Adet";
                    }

                    guncelle.Tarih = DateTime.Now;
                    guncelle.Kullanci = lkullanici.Text;
                    db.SaveChanges();

                    islemler.StokHareket(tbarkod.Text, tUrunAdi.Text, "Adet", Convert.ToDouble(tMiktar.Text), cmbUrunGrubu.Text, lkullanici.Text);

                    GridUrunler.DataSource = db.Urun.OrderByDescending(a => a.Urunid).Take(20).ToList();
                }
                else
                {
                    Urun urun = new Urun();
                    urun.Barkod = tbarkod.Text;
                    urun.UrunAd = tUrunAdi.Text;
                    urun.UrunGrup = cmbUrunGrubu.Text;
                    urun.Acıklama = tAcıklama.Text;
                    urun.AlisFiyat = islemler.DoubleYap(tAlısFiyati.Text);
                    urun.SatisFiyat = islemler.DoubleYap(tSatisFiyati.Text);
                    urun.SatisFiyat2 = islemler.DoubleYap(tSatisFiyati2.Text);
                    urun.SatisFiyat3 = islemler.DoubleYap(tSatisFiyati3.Text);
                    urun.SatisFiyat4 = islemler.DoubleYap(tSatisFiyati4.Text);
                    urun.SatisFiyat5 = islemler.DoubleYap(tSatisFiyati5.Text);
                    urun.KdvOrani = Convert.ToInt16(tKdvOrani.Text);
                    urun.KdvTutari = Math.Round(islemler.DoubleYap(tSatisFiyati.Text) * Convert.ToInt16(tKdvOrani.Text) / 100, 2);
                    urun.Miktar = Convert.ToDouble(tMiktar.Text);
                    urun.Onay = true;
                    if (chUrunTipi.Checked)
                    {
                        urun.Birim = "kg";
                    }
                    else
                    {
                        urun.Birim = "Adet";
                    }

                    urun.Tarih = DateTime.Now;
                    urun.Kullanci = lkullanici.Text;
                    tUrunid.Text = urun.Urunid.ToString();
                    db.Urun.Add(urun);
                    db.SaveChanges();
                    tUrunid.Text = urun.Urunid.ToString();
                    if (tbarkod.Text.Length == 8)
                    {
                        var ozelbarkod = db.Barkod.First();
                        ozelbarkod.Barkodno += 1;
                        db.SaveChanges();
                    }

                    coklubKayit();
                    barkodliste(GetListBarkod());
                    islemler.StokHareket(tbarkod.Text, tUrunAdi.Text, "Adet", Convert.ToDouble(tMiktar.Text), cmbUrunGrubu.Text, lkullanici.Text);
                    temizle();
                    chUrunTipi.Checked = false;
                    GridUrunler.DataSource = db.Urun.OrderByDescending(a => a.Urunid).Take(20).ToList();
                    islemler.GridDuzenle(GridUrunler);
                }

                MessageBox.Show("Başarıyla Kaydedildi.");


            }
            else
            {
                MessageBox.Show("Bilgi Girişini Kontrol Ediniz.");
                tbarkod.Focus();
            }
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            string urunad = tUrunAra.Text;
            GridUrunler.DataSource = db.Urun.Where(a => a.UrunAd.Contains(urunad)).ToList();
            islemler.GridDuzenle(GridUrunler);

        }

        private void bİptal_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            tbarkod.Text = "";
            tUrunAdi.Text = "";
            tAcıklama.Text = "";
            tAlısFiyati.Text = "0";
            tSatisFiyati.Text = "0";
            tMiktar.Text = "0";
            tKdvOrani.Text = "0";
            tSatisFiyati2.Text = "0";
            tSatisFiyati3.Text = "0";
            tSatisFiyati4.Text = "0";
            tSatisFiyati5.Text = "0";
            listBarkod.DataSource = null;
            tUrunAra.Text = "";
            tUrunid.Text = "";
            tbarkod.Focus();
            chUrunTipi.Checked = false;
            tCok.Text = "";
            tnumeric1.Clear();
        }

        private void fUrunGiris_Load(object sender, EventArgs e)
        {
            tUrunSayisi.Text = db.Urun.Count().ToString();
            GridUrunler.DataSource = db.Urun.OrderByDescending(a => a.Urunid).Take(20).ToList();
            GridUrunler.Columns[0].Width = 85;
            GridUrunler.Columns[1].Width = 85;
            GridUrunler.Columns[2].Width = 250;
            GridUrunler.Columns[3].Width = 85;
            GridUrunler.Columns[4].Width = 85;
            GridUrunler.Columns[5].Width = 85;
            GridUrunler.Columns[7].Width = 85;
            GridUrunler.Columns[7].Width = 80;
            GridUrunler.Columns[17].Width = 75;
            islemler.GridDuzenle(GridUrunler);
            tbarkod.Focus();
            GrupDoldur();


        }

        private void bUrunGrubuEkle_Click(object sender, EventArgs e)
        {
            fUrunGrubuIslemleri f = new fUrunGrubuIslemleri();
            f.ShowDialog();
        }

        private ListBox GetListBarkod()
        {
            return listBarkod;
        }

        private void barkodliste(ListBox listBarkod)
        {

            if (tUrunid.Text != "")
            {
                int tid = Convert.ToInt32(tUrunid.Text);
                listBarkod.DisplayMember = "Barkod";
                listBarkod.ValueMember = "Urunid";
                listBarkod.DataSource = db.CokluB.Where(a => a.Urunid == tid).ToList();
            }
        }
        public void GrupDoldur()
        {
            cmbUrunGrubu.DisplayMember = "UrunGrupAd";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bBarkodOlustur_Click(object sender, EventArgs e)
        {
            var barkodno = db.Barkod.First();
            int karakter = barkodno.Barkodno.ToString().Length;
            string sifirlar = string.Empty;
            for (int i = 0; i < 8 - karakter; i++) // mevcut sayının sağına toplam 8 karakter olacak şekilde 0 koydurucaz
            {
                sifirlar = sifirlar + "0";
            }
            string olusanbarkod = sifirlar + barkodno.Barkodno.ToString();
            tbarkod.Text = olusanbarkod;
            tUrunAdi.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GridUrunler.Rows.Count > 0)
            {
                int urunid = Convert.ToInt32(GridUrunler.CurrentRow.Cells["Urunid"].Value.ToString());
                string urunad = GridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                string barkod = GridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                DialogResult onay = MessageBox.Show(urunad + "Ürünü Silmek İstiyor musunuz?", "Ürün Silme İşlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {


                    //int barkodid = Convert.ToInt32(listBarkod.SelectedValue.ToString());
                    var coklu = db.CokluB.Where(x => x.Urunid == urunid).ToList();

                    db.CokluB.RemoveRange(coklu); // ürün sildiğimde barkodları toplu olarak kaldırır
                    db.SaveChanges();
                    barkodliste(GetListBarkod());

                    var urun = db.Urun.Find(urunid);
                    db.Urun.Remove(urun);
                    db.SaveChanges();
                    if (db.HızlıUrun.Any(x => x.Barkod == barkod))
                    {
                        var hızlıurun = db.HızlıUrun.Where(x => x.Barkod == barkod).SingleOrDefault();
                        hızlıurun.Barkod = "-";
                        hızlıurun.UrunAd = "-";
                        hızlıurun.Fiyat = 0;
                        db.SaveChanges();
                        MessageBox.Show("Ürün Silindi.");
                    }

                    GridUrunler.DataSource = db.Urun.OrderByDescending(a => a.Urunid).Take(20).ToList();
                    islemler.GridDuzenle(GridUrunler);
                    tbarkod.Focus();
                }
            }

        }
        private void cmbUrunGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void bbarkodKaydet_Click(object sender, EventArgs e)
        {
            coklubKayit2();

        }
        private void coklubKayit()
        {
            CokluB cb = new CokluB();
            string barkod = tbarkod.Text.Trim();

            if (db.CokluB.Any(a => a.Barkod == barkod))
            {
                MessageBox.Show("Kayıtlı Barkod.");
            }
            else
            {
                cb.Urunid = Convert.ToInt32(tUrunid.Text);
                cb.Barkod = tbarkod.Text;
                db.CokluB.Add(cb);
                db.SaveChanges();
                barkodliste(GetListBarkod());
            }
        }
        private void coklubKayit2()
        {
            CokluB cb = new CokluB();
            string barkod = tCok.Text.Trim();

            if (db.CokluB.Any(a => a.Barkod == barkod))
            {
                MessageBox.Show("Kayıtlı Barkod.");
            }
            else
            {
                if (tCok.Text != "")
                {
                    cb.Urunid = Convert.ToInt32(tUrunid.Text);
                    cb.Barkod = tCok.Text;
                    db.CokluB.Add(cb);
                    db.SaveChanges();
                    barkodliste(GetListBarkod());
                }
            }
            tCok.Text = "";
        }

        private void bBarkodKaldır_Click(object sender, EventArgs e)
        {
            int barkodid = Convert.ToInt32(listBarkod.SelectedValue.ToString());

            var orjibarkod = db.Urun.Where(x => x.Urunid == barkodid).Select(x => x.Barkod).FirstOrDefault();
            string grupad = listBarkod.Text;
            if (grupad == orjibarkod)
            {
                MessageBox.Show("İlk Barkodu Kaldırmak İçin Lütfen Ürünü Silin.");
                return;
            }
            var bar = db.CokluB.FirstOrDefault(x => x.Barkod == grupad);
            db.CokluB.Remove(bar);
            db.SaveChanges();
            barkodliste(GetListBarkod());


        }

        private void chUrunTipi_CheckedChanged(object sender, EventArgs e)
        {
            if (chUrunTipi.Checked)
            {
                chUrunTipi.Text = "Gramajlı Ürün İşlemi.";
                bBarkodOlustur.Enabled = false;
            }
            else
            {
                chUrunTipi.Text = "Barkodlu Ürün İşlemi.";
                bBarkodOlustur.Enabled = true;
            }
        }

        private void GridUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridUrunler.Rows.Count > 0)
            {
                tUrunid.Text = GridUrunler.CurrentRow.Cells["Urunid"].Value.ToString();
                tbarkod.Text = GridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                tUrunAdi.Text = GridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                tAcıklama.Text = GridUrunler.CurrentRow.Cells["Acıklama"].Value.ToString();
                cmbUrunGrubu.Text = GridUrunler.CurrentRow.Cells["UrunGrup"].Value.ToString();
                tAlısFiyati.Text = GridUrunler.CurrentRow.Cells["AlisFiyat"].Value.ToString();
                tSatisFiyati.Text = GridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString();
                tKdvOrani.Text = GridUrunler.CurrentRow.Cells["KdvOrani"].Value.ToString();
                string birim = GridUrunler.CurrentRow.Cells["Birim"].Value.ToString();
                if (birim == "kg")
                {
                    chUrunTipi.Checked = true;
                }
                else
                {
                    chUrunTipi.Checked = false;
                }
                tMiktar.Text = GridUrunler.CurrentRow.Cells["Miktar"].Value.ToString();
                tSatisFiyati2.Text = GridUrunler.CurrentRow.Cells["SatisFiyat2"].Value.ToString();
                tSatisFiyati3.Text = GridUrunler.CurrentRow.Cells["SatisFiyat3"].Value.ToString();
                tSatisFiyati4.Text = GridUrunler.CurrentRow.Cells["SatisFiyat4"].Value.ToString();
                tSatisFiyati5.Text = GridUrunler.CurrentRow.Cells["SatisFiyat5"].Value.ToString();
                barkodliste(GetListBarkod());
            }
        }

        private void b200_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tCok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                coklubKayit2();
            }
        }

        private void tSatisFiyati_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            if (!(this.tUrunid.Text != ""))
                return;
            int urunid = Convert.ToInt32(this.tUrunid.Text);
            if (MessageBox.Show(this.tUrunAdi.Text + "Ürünü Silmek İstiyor musunuz?", "Ürün Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.db.CokluB.RemoveRange((IEnumerable<CokluB>)this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>)(x => x.Urunid == (int?)urunid)).ToList<CokluB>());
                this.db.SaveChanges();
                this.barkodliste(this.GetListBarkod());
                if (this.db.Urun.Any<Urun>((Expression<Func<Urun, bool>>)(x => x.Urunid == urunid)))
                {
                    Urun entity = this.db.Urun.Find(new object[1]
                    {
            (object) urunid
                    });
                    string barkod = entity.Barkod;
                    if (this.db.HızlıUrun.Any<HızlıUrun>((Expression<Func<HızlıUrun, bool>>)(x => x.Barkod == barkod)))
                    {
                        HızlıUrun hızlıUrun = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>)(x => x.Barkod == barkod)).SingleOrDefault<HızlıUrun>();
                        hızlıUrun.Barkod = "-";
                        hızlıUrun.UrunAd = "-";
                        hızlıUrun.Fiyat = new double?(0.0);
                        this.db.SaveChanges();
                        int num = (int)MessageBox.Show("Ürün Silindi.");
                        ((Form1)Application.OpenForms["Form1"]).HızlıUrunDoldur();
                    }
                    this.db.Urun.Remove(entity);
                    this.db.SaveChanges();
                }
                this.GridUrunler.DataSource = (object)this.db.Urun.OrderByDescending<Urun, int>((Expression<Func<Urun, int>>)(a => a.Urunid)).Take<Urun>(20).ToList<Urun>();
                islemler.GridDuzenle((DataGridView)this.GridUrunler);
                this.temizle();
                this.tbarkod.Focus();
            }
        }

        private void tnumeric1_TextChanged(object sender, EventArgs e)
        {
            tSatisFiyati.Text = tnumeric1.Text;
            tSatisFiyati2.Text = tnumeric1.Text;
            tSatisFiyati3.Text = tnumeric1.Text;
            tSatisFiyati4.Text = tnumeric1.Text;
            tSatisFiyati5.Text = tnumeric1.Text;
        }
    }
}
