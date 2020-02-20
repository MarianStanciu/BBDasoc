using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBDasoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulareTabLayout2();
            var rowCount = 1;
            var columnCount = 6;
            this.tableLayoutPanel1.ColumnCount = columnCount;
            this.tableLayoutPanel1.RowCount = rowCount;

            this.tableLayoutPanel1.ColumnStyles.Clear();
            this.tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i < rowCount; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / rowCount));
            }
            for (int i = 0; i < columnCount; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / columnCount));

            }
            String[] denumiri = new string[5] { "asociatie", "marmota", "elefantul", "maimuta", "marian" };
            int index = 0;
            for (int i = 0; i < rowCount * columnCount; i++)
            {
                var b = new Button();
                //  var b = new ButonMeniuPrincipal();

                // for (int z = 0; z < denumiri.Length ; z++)
                if (index < denumiri.Length)
                {
                    b.Text = denumiri[index++];
                }

                b.Name = string.Format("b_{0}", i + 1);
                b.Click += ApasareButon;
                b.Dock = DockStyle.Fill;
                this.tableLayoutPanel1.Controls.Add(b);
            }
        }

        // metoda comuna pentru click pe butoane ---------------------------------------------------------------------
        public void ApasareButon(object sender, EventArgs e)
        {
            var b = (Button)sender;
            if (b != null)
            {
                switch (b.Text)
                {
                    case ("asociatie"):
                        MessageBox.Show("aaaaaaaaaaaaaaaa");
                        break;
                    case ("marmota"):
                        MessageBox.Show("ooooooooooo");
                        break;
                        // ...
                }
            }

        }
        public void PopulareTabLayout2()
        {
            var rowCount = 1;
            var columnCount = 6;
            this.tableLayoutPanel2.ColumnCount = columnCount;
            this.tableLayoutPanel2.RowCount = rowCount;

            this.tableLayoutPanel2.ColumnStyles.Clear();
            this.tableLayoutPanel2.RowStyles.Clear();
            for (int i = 0; i < rowCount; i++)
            {
                this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / rowCount));
            }
            for (int i = 0; i < columnCount; i++)
            {
                this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / columnCount));

            }
            String[] denumiriTL = new string[5] { "A", "B", "C", "D", "E" };
            int index = 0;
            for (int i = 0; i < rowCount * columnCount; i++)
            {
                var b = new Button();
                //  var b = new ButonMeniuPrincipal();

                // for (int z = 0; z < denumiri.Length ; z++)
                if (index < denumiriTL.Length)
                {
                    b.Text = denumiriTL[index++];
                }
                b.Click += ApasareButonTL2;
                b.Dock = DockStyle.Fill;
                this.tableLayoutPanel2.Controls.Add(b);
            }
        }
            
        public void ApasareButonTL2(object sender, EventArgs e)
        {
            var b = (Button)sender;
            if (b != null)
            {
                switch (b.Text)
                {
                    case ("A"):
                        MessageBox.Show("aaaaaaaaaaaaaaaabbbbbbbbbbbbcccccccccc");
                        break;
                    case ("B"):
                        MessageBox.Show("dddddddddeeeeeeeeeeefffffffffffff");
                        break;
                    case ("C"):
                        MessageBox.Show("gggggggggghhhhhhhhhhhhiiiiiiiiiiii");
                        break;
                }
            }
        }
        }
        
    }
    

    
    
