using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack; //Paketi dahil ettik burada 
using System.Threading;
using System.Net; //Uygulama çalışırken verileri çeksin dedik 

namespace DepremVeriÇekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false; //Herghangi bir şey istemiyoruz 
            InitializeComponent();
            this.MaximizeBox = false;
            Thread getir = new Thread(BringEarthquake);
            getir.SetApartmentState(ApartmentState.STA); getir.Start();
        }
        private void BringEarthquake() //Geriye değer döndürmededen depremleri getireceğiz 
        {
            WebClient client = new WebClient();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(client.OpenRead("https://deprem.afad.gov.tr/last-earthquakes.html"),Encoding.UTF8);
            //var doc = web.Load("https://deprem.afad.gov.tr/last-earthquakes.html"); //İstek atacağımız url i verdik 

            HtmlNodeCollection td = doc.DocumentNode.SelectNodes("//table[@class='content-table']//tr//td");
            // Çift slaş koyma sebebimiz birden fazla değer seçmek için 
            for (int i = 0; i < td.Count; i += 8)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i / 8].Cells[0].Value = td[i].InnerText;     //Tarih
                dataGridView1.Rows[i / 8].Cells[1].Value = td[i + 1].InnerText; //Enlem 
                dataGridView1.Rows[i / 8].Cells[2].Value = td[i + 2].InnerText; //Boylam    
                dataGridView1.Rows[i / 8].Cells[3].Value = td[i + 3].InnerText;
                dataGridView1.Rows[i / 8].Cells[4].Value = td[i + 4].InnerText;
                dataGridView1.Rows[i / 8].Cells[5].Value = td[i + 5].InnerText;
                dataGridView1.Rows[i / 8].Cells[6].Value = td[i + 6].InnerText;
            }



        }
    }
}
