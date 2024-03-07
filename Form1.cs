using System;
using System.Data;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace XML_JSON_dz
{
    public partial class Form1 : Form
    {
        public int id;
        public Form1()
        {
            InitializeComponent();
            ClearInput();
        }
        private void ClearInput() // Очищение полей
        {
            nameLot.Text = string.Empty;
            nameReception.Text = string.Empty;
            sum.Value = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string xmlString = File.ReadAllText(@"..\..\Auction.xml", Encoding.UTF8);
                XmlDocument dom = new XmlDocument();
                dom.LoadXml(xmlString);
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
                TreeNode tNode = new TreeNode();
                tNode = treeView1.Nodes[0];
                this.AddNode(dom.DocumentElement, tNode);
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode) // Проецирование XML файла на дерево
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;

                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    this.AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }
        private void SerializableXML(Lots lots) //Сериализция XML
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Lots));
            using (FileStream fs = new FileStream(@"..\..\Auction.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, lots);
            }

        }
        private Lots DeserializableXML() // Десериализция XML
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Lots));
            using (FileStream fs = new FileStream(@"..\..\Auction.xml", FileMode.OpenOrCreate))
            {
                return (Lots)xmlSerializer.Deserialize(fs);
            }
        }
        private void Add(Lot lot) //Добавление объектов в listView
        {
            ListViewItem listViewItem = new ListViewItem(lot.NameLot);
            listViewItem.Tag = lot;
            listViewLot.Items.Add(listViewItem);
        }
        private void Serialization_Click(object sender, EventArgs e) //Кнопка сериализации
        {
            Lots lots = new Lots();
            foreach (ListViewItem item in listViewLot.Items)
            {
                if (item.Tag != null)
                {
                    lots.LotsList.Add((Lot)item.Tag);
                }
            }
            SerializableXML(lots);
        }

        private void Deserialization_Click(object sender, EventArgs e) //Кнопка десериализации
        {
            ClearInput();
            Lots lots = DeserializableXML();
            foreach (Lot lot in lots.LotsList)
            {
                Add(lot);
            }
            if (File.Exists(@"..\..\Auction.xml")) // если существует данный файл
            {
                DataSet ds = new DataSet(); // создаем новый пустой кэш данных
                ds.ReadXml(@"..\..\Auction.xml"); // записываем в него XML-данные из файла

                foreach (DataRow item in ds.Tables["Lot"].Rows) // Записываем в таблицу
                {
                    int n = table.Rows.Add();
                    table.Rows[n].Cells[0].Value = item["Id"];
                    table.Rows[n].Cells[1].Value = item["NameLot"];
                    table.Rows[n].Cells[2].Value = item["NameReception"];
                    table.Rows[n].Cells[3].Value = item["Sum"];
                    table.Rows[n].Cells[4].Value = item["Time"];
                }
            }
            else
            {
                MessageBox.Show("XML файл не найден.", "Ошибка.");
            }
        }
        private void Btn_Add_Click(object sender, EventArgs e) // Кнопка добавления в таблицу и в лист(Не выполняет сериализацию)
        {
            Lot lot = new Lot(nameLot.Text, nameReception.Text, (int)sum.Value, id++);
            Add(lot);// Добавление в View List
            ClearInput();
            table.Rows.Add(lot.Id, lot.NameLot, lot.NameReception, lot.Sum, lot.Time); // Добавление в таблицу

        }

        private void ListViewLot_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewBand band;
            if (listViewLot.SelectedItems.Count == 1) // Когда выбран элемент в listView
            {
                Lot lot = (Lot)listViewLot.SelectedItems[0].Tag;
                if (lot != null)
                {
                    nameLot.Text = lot.NameLot;
                    nameReception.Text = lot.NameReception;
                    sum.Value = lot.Sum;
                    for (int i = 0; i < listViewLot.Items.Count; i++) // Просмотр только одной строки, выбранного элемента в listView
                    {
                        if (listViewLot.SelectedIndices[0] != i)
                        {
                            band = table.Rows[i];
                            band.Visible = false;
                        }
                    }
                }
            }
            else if (listViewLot.SelectedItems.Count == 0) // Когда не выбран элемент в listView
            {
                ClearInput();
                for (int i = 0; i < listViewLot.Items.Count; i++) // Возвращение всех строк назад
                {
                    band = table.Rows[i];
                    band.Visible = true;
                }
            }
        }
        private void Btn_SerJson(object sender, EventArgs e) // Кнопка сериализации Json
        {
            Lots lots = new Lots();
            foreach (ListViewItem item in listViewLot.Items)
            {
                if (item.Tag != null)
                {
                    lots.LotsList.Add((Lot)item.Tag);
                }
            }
            SerializableJson(lots);
        }
        private void SerializableJson(Lots lots) //Сериализция Json
        {
            try
            {
                using (FileStream fs = new FileStream(@"..\..\AuctionJson.xml", FileMode.OpenOrCreate))
                {
                    JsonSerializer.Serialize(fs, lots);
                }
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Json файл не найден.", "Ошибка.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        private Lots DeserializableJson() // Десериализция Json
        {
            using (FileStream fs = new FileStream(@"..\..\AuctionJson.xml", FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<Lots>(fs);
            }

        }


        private void btn_OpenForm2_Click_1(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            dlg.Show(this);
        }

        private void Btn_DeserJson(object sender, EventArgs e)
        {
            tableForJson.DataSource = DeserializableJson().LotsList;
        }
    }
}
