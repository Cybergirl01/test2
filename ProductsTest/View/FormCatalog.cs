using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProductsTest
{
    public partial class FormCatalog : Form
    {
        public FormCatalog()
        {
            InitializeComponent();
        }
        Exam_Test_2DataSet.CatalogDataTable catalogs;
        byte min, max;
        string search;
        string path = Directory.GetCurrentDirectory() + Convert.ToString('\\');
        int sort;
        int countselect, countproduct;
        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = comboBoxSort.SelectedIndex;      //Новое направление
            SearchSortTable(min, max, search);     //Обновить таблицу
        }

        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxDiscount.SelectedIndex; //Позиция диапазона
            switch (index)
            {
                case 0:
                    min = 0;
                    max = 100;
                    break;
                case 1:
                    min = 0;
                    max = 10;
                    break;
                case 2:
                    min = 11;
                    max = 14;
                    break;
                case 3:
                    min = 15;
                    max = 100;
                    break;
            }
            SearchSortTable(min, max, search);     //Обновить таблицу
        }

        private void FormCatalog_Load(object sender, EventArgs e)
        {
           var catalogs = catalogTableAdapter.GetData().ToList();
            countproduct=countselect = catalogs.Count;
            min = 0;
            max = 100;
            search = "";
            sort = 0;
            SearchSortTable(min, max, search);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            search = textBoxSearch.Text;    //Новая строка для поиска
            SearchSortTable(min, max, search); //Обновить таблицу
        }

        private void SearchSortTable(byte min, byte max, string search)
        {
            if (sort == 1)
            {
                catalogs = catalogTableAdapter.GetDataByASC(search, min, max);
            }
            else
            {
                catalogs = catalogTableAdapter.GetDataByDESC(search, min, max);
            }
            countselect = catalogs.Count;
            flowLayoutPanelCatalog.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelCatalog.AutoScroll = true;
            flowLayoutPanelCatalog.WrapContents = false;
            flowLayoutPanelCatalog.Font = new Font(FontFamily.GenericSansSerif, 12);
            flowLayoutPanelCatalog.Controls.Clear();
            string info;
            Panel panel;
            TextBox productinfo;
            PictureBox pictureProduct;
            foreach (var item in catalogs)
            {
                panel = new Panel();
                panel.Size = new Size(flowLayoutPanelCatalog.Width, 150);
                pictureProduct = new PictureBox();
                pictureProduct.Size = new Size(panel.Width / 5, panel.Height);
                pictureProduct.Location = new Point(0, 0);
                pictureProduct.SizeMode = PictureBoxSizeMode.Zoom;
                if (item.PhotoProduct == "")
                {
                    pictureProduct.Image = Properties.Resources.Picture;
                }
                else
                {
                    pictureProduct.Load(path + item.PhotoProduct);
                }
                panel.Controls.Add(pictureProduct);
                productinfo = new TextBox();
                productinfo.Multiline = true;
                productinfo.Location = new Point(pictureProduct.Width + 5, 0);
                productinfo.ScrollBars = ScrollBars.Both;
                productinfo.Size = new Size(3 * flowLayoutPanelCatalog.Width / 5, panel.Height);
                info = "";
                decimal sale = item.Discount;
                double cost = (double)item.Cost;
                double costSale = cost - cost * Convert.ToDouble(sale) / 100.0;
                info += "Название товара: " + item.Name + Environment.NewLine;
                info += "Категория: " + item.Title + Environment.NewLine;
                info += "Цена без скидки: " + item.Cost + Environment.NewLine;
                info += "Скидка: " + item.Discount + Environment.NewLine;
                info += "Цена со скидкой: " + costSale + Environment.NewLine;
                productinfo.Text = info;
                if(sale > 15)
                {
                    productinfo.BackColor = Color.FromArgb(0, 255, 0);
                }
                else
                {
                    productinfo.BackColor = Color.FromArgb(255, 255, 255);
                }
                panel.Controls.Add(productinfo);
                flowLayoutPanelCatalog.Controls.Add(panel);

            }
            labelCount.Text = "Выбрано: " + countselect + " из " + countproduct;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
