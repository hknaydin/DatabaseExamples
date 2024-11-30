using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.model;
using Test.view;


namespace Test.control
{

    internal class Controller
    {
        MainGUI mainForm;
        List<Kursiyer> kursiyerListesi;
        // Bağlantı nesnesi oluştur
        private SqlConnection db_connect;
        DataTable dataTable;
        public Controller(MainGUI form1)
        {
            this.mainForm = form1;

            initializer();
        }

        public void initializer()
        {
            db_connect = new SqlConnection("server=localhost;database=dukkan;integrated security=True");
            this.mainForm.cmbTableNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // btnConnect'in Click olayına bir metod bağla
            this.mainForm.btnConnect.Click += BtnConnect_Click;
            this.mainForm.btnDisconnect.Click += BtnDisconnect_click;
            this.mainForm.btnDataFetch.Click += BtnDataFetch_Click;
            this.mainForm.btnNewFormWindow.Click += BtnOpenNewFormWindow_Click;
        }

        private void BtnOpenNewFormWindow_Click(object? sender, EventArgs e)
        {
            // Yeni bir SecondGUI formu oluştur
            SecondGUI secondForm = new SecondGUI();


                // İkinci formun dataGridViewSecondForm'una verileri bağla
                secondForm.dataGridViewSecondForm.DataSource = dataTable;
                secondForm.dataGridViewSecondForm.ReadOnly = true;

                // İkinci formun btnSecond olayını bağla
                secondForm.btnSecond.Click += (s, args) =>
                {
                    secondForm.Close(); // Formu kapat
                };

                // İkinci formu göster
                secondForm.Show();
       
        }

        private void BtnDataFetch_Click(object? sender, EventArgs e)
        {
            // Veritabanı bağlantısını kontrol et
            if (db_connect.State == ConnectionState.Closed)
            {
                open_database(); // Bağlantıyı aç
            }
            load_data_to_grid();
        }

        private void BtnDisconnect_click(object? sender, EventArgs e)
        {
            // Butona tıklandığında çalışacak kod
            MessageBox.Show("DisConnect button clicked!");
        }

        private void BtnConnect_Click(object? sender, EventArgs e)
        {
            // Butona tıklandığında çalışacak kod
            MessageBox.Show("Connect button clicked!");
            open_database();
            init_databaseTables();

        }

        private void init_databaseTables()
        {
            try
            {
                // Veritabanındaki tüm tablo isimlerini almak için sorgu
                string query = "SELECT table_name FROM information_schema.tables WHERE table_type = 'BASE TABLE'";

                SqlCommand command = new SqlCommand(query, db_connect);
                SqlDataReader reader = command.ExecuteReader();

                // ComboBox'ı temizle
                this.mainForm.cmbTableNames.Items.Clear();

                // Veritabanındaki tüm tablo isimlerini ComboBox'a ekle
                while (reader.Read())
                {
                    string tableName = reader["table_name"].ToString();
                    this.mainForm.cmbTableNames.Items.Add(tableName);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }

        }

        private void open_database()
        {
            // Bağlantıyı aç
            if (db_connect.State == ConnectionState.Closed)
            {
                db_connect.Open();
            }

        }

        private void load_data_to_grid()
        {
            // ComboBox'tan seçili tabloyu al
            string selectedTable = this.mainForm.cmbTableNames.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedTable))
            {
                MessageBox.Show("Lütfen bir tablo seçin!");
                return;
            }

            SqlDataReader reader = null; // Reader değişkenini burada tanımladık.

            try
            {
                string query = $"SELECT * FROM {selectedTable}"; // Seçilen tablonun tüm verilerini al

                SqlCommand command = new SqlCommand(query, db_connect);
                reader = command.ExecuteReader(); // ExecuteReader'ı burada çağırıyoruz

                // Verileri dinamik olarak uygun modele yüklemek için bir liste oluşturuluyor
                var dataList = new List<object>();

                // Eğer tablo tamamen boşsa sütun adlarını al
                DataTable schemaTable = reader.GetSchemaTable();

                if (reader.HasRows)
                {
                    // Veri varsa, satırları okuyarak ilgili modelle eşleştir
                    while (reader.Read())
                    {
                        if (selectedTable == "GUIDTest")
                        {
                            var guidtest = new GUIDTest
                            {
                                Numara = (int)reader["numara"],
                                Isim = reader["isim"].ToString()
                            };
                            dataList.Add(guidtest);
                        }
                        else if (selectedTable == "tbKursiyer")
                        {
                            var kursiyer = new Kursiyer
                            {
                                Isim = reader["isim"].ToString(),
                                Soyad = reader["soyad"].ToString(),
                                Telefon = reader["telefon"].ToString()
                            };
                            dataList.Add(kursiyer);
                        }
                        else if (selectedTable == "tblDoviz")
                        {
                            var doviz = new Doviz
                            {
                                DovizKod = reader["dovizKod"].ToString(),
                                DovizAd = reader["dovizAd"].ToString(),
                                DovizOran = reader["dovizOran"] != DBNull.Value ? (double)reader["dovizOran"] : 0
                            };
                            dataList.Add(doviz);
                        }
                        else if (selectedTable == "tblEliste")
                        {
                            var eliste = new Eliste
                            {
                                Email = reader["email"].ToString(),
                                IsActive = reader["isActive"] != DBNull.Value && (bool)reader["isActive"]
                            };
                            dataList.Add(eliste);
                        }
                        else if (selectedTable == "tblEtc")
                        {
                            var etc = new Etc
                            {
                                EtcID = reader["etcID"].ToString(),
                                EtcText = reader["etcText"].ToString(),
                                EtcNumber = reader["etcNumber"] != DBNull.Value ? (int)reader["etcNumber"] : 0,
                                Desc = reader["desc"].ToString()
                            };
                            dataList.Add(etc);
                        }
                        else if (selectedTable == "tblGorus")
                        {
                            var gorus = new TblGorus
                            {
                                GorusKod = (int)reader["gorusKod"],
                                UrunKod = (int)reader["urunKod"],
                                KullaniciKod = (int)reader["kullaniciKod"],
                                Baslik = reader["baslik"].ToString(),
                                Icerik = reader["icerik"].ToString(),
                                Ip = reader["ip"].ToString(),
                                AktifMi = reader["aktifMi"] != DBNull.Value && (bool)reader["aktifMi"],
                                Tarih = reader["tarih"] != DBNull.Value ? (DateTime)reader["tarih"] : default,
                                Katilan = (int)reader["katilan"],
                                Katilmayan = (int)reader["katilmayan"]
                            };
                            dataList.Add(gorus);
                        }
                        else if (selectedTable == "tblHesap")
                        {
                            var hesap = new TblHesap
                            {
                                HesapNo = (int)reader["hesapNo"],
                                Isim = reader["isim"].ToString(),
                                Soyad = reader["soyad"].ToString(),
                                Sube = reader["sube"].ToString(),
                                Bakiye = reader["bakiye"] != DBNull.Value ? (decimal)reader["bakiye"] : 0
                            };
                            dataList.Add(hesap);
                        }
                        else if (selectedTable == "tblIcerik")
                        {
                            var icerik = new TblIcerik
                            {
                                IcerikKod = (int)reader["icerikKod"],
                                CatID = (int)reader["catID"],
                                Title = reader["title"].ToString(),
                                Spot = reader["spot"].ToString(),
                                Body = reader["body"].ToString(),
                                ShownDate = reader["shownDate"] != DBNull.Value ? (DateTime)reader["shownDate"] : null,
                                Statu = reader["statu"].ToString(),
                                FrPage = reader["frPage"] != DBNull.Value && (bool)reader["frPage"],
                                DeadLine = reader["deadLine"] != DBNull.Value ? (DateTime)reader["deadLine"] : null,
                                AdminID = (int)reader["adminID"],
                                Puan = (int)reader["puan"],
                                Oylama = (int)reader["oylama"],
                                PageView = (int)reader["pageView"],
                                ParentId = (int)reader["parentid"],
                                Rank = (int)reader["rank"],
                                CtxtLevel = (int)reader["ctxtLevel"]
                            };
                            dataList.Add(icerik);
                        }
                    }
                }
                else
                {
                    // Eğer tablo tamamen boşsa, sadece sütun bilgilerini göster
                    var columnNames = schemaTable.AsEnumerable()
                                                 .Select(row => row["ColumnName"].ToString())
                                                 .ToList();

                    var emptyRow = new Dictionary<string, string>();
                    foreach (var columnName in columnNames)
                    {
                        emptyRow[columnName] = null;
                    }

                    dataList.Add(emptyRow);
                }

                reader.Close();

                // DataGridView'e listeyi bağla
                this.mainForm.dataGridViewTables.DataSource = dataList;
                this.mainForm.dataGridViewTables.ReadOnly = true;

                dataTable = ConvertListToDataTable(dataList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
        }

        private DataTable ConvertListToDataTable(List<object> list)
        {
            DataTable table = new DataTable();

            if (list == null || !list.Any())
            {
                MessageBox.Show("Liste boş, dönüştürme işlemi yapılamıyor!");
                return table;
            }

            var firstObj = list.FirstOrDefault();
            if (firstObj == null)
            {
                MessageBox.Show("Liste içerisinde geçerli bir veri bulunamadı!");
                return table;
            }

            if (list.Select(o => o.GetType()).Distinct().Count() > 1)
            {
                MessageBox.Show("Liste içinde birden fazla türde nesne var. Dönüştürme yapılamıyor!");
                return table;
            }

            try
            {
                foreach (var prop in firstObj.GetType().GetProperties())
                {
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }

                foreach (var obj in list)
                {
                    if (obj == null)
                    {
                        MessageBox.Show("Liste içinde boş bir nesne bulundu. İşlem durduruldu.");
                        continue;
                    }

                    var row = table.NewRow();
                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        row[prop.Name] = prop.GetValue(obj) ?? DBNull.Value;
                    }
                    table.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dönüştürme sırasında bir hata oluştu: {ex.Message}");
            }

            return table;
        }

    }

}
