using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListviewExample
{
    public partial class Form1 : Form
    {
        ListView listView1;
        public Form1()
        {
            InitializeComponent();
            // Создаем новый ListView
            listView1 = new ListView();

            // Зададим размер и местоположение списка на форме
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));

            // Установим табличный режим отображения
            listView1.View = View.Details;

            // Позволим пользователю редактировать поле элемента списка
            listView1.LabelEdit = true;

            // Позволим пользователю перемещать столбцы в табличном режиме
            listView1.AllowColumnReorder = true;

            // Возле каждого элемента списка будет флажок
            listView1.CheckBoxes = true;

            // При выборе элемента списка будет подсвечена вся строка
            listView1.FullRowSelect = true;

            // Отобразим линии сетки в табличном режиме
            listView1.GridLines = true;

            // Установим сортировку элементов в порядке возрастания
            listView1.Sorting = SortOrder.Ascending;

            ListViewItem item1 = new ListViewItem("Желание 1", 1);
            item1.SubItems.Add("200 грн");

            ListViewItem item2 = new ListViewItem("Желание 2", 2);
            item2.SubItems.Add("300 грн");

            ListViewItem item3 = new ListViewItem("Желание 3", 3);
            item3.SubItems.Add("300 грн");

            ListViewItem item4 = new ListViewItem("Желание 4", 4);
            item4.SubItems.Add("500 грн");

            ListViewItem item5 = new ListViewItem("Желание 5", 5);
            item5.SubItems.Add("1500 грн");

            listView1.Columns.Add("Название желания", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Цена", 145, HorizontalAlignment.Left);

            // Добавляем элементы в список
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5 });

            ImageList imageListSmall = new ImageList();

            // Инициализируем списки изображений картинками
            imageListSmall.Images.Add(new Bitmap(Properties.Resources.cat));
            imageListSmall.Images.Add(new Bitmap(Properties.Resources.monkey));
            imageListSmall.Images.Add(new Bitmap(Properties.Resources.pig));
            imageListSmall.Images.Add(new Bitmap(Properties.Resources.raccoon));
            imageListSmall.Images.Add(new Bitmap(Properties.Resources.tree));

            listView1.SmallImageList = imageListSmall;

            // Добавляем ListView в коллекцию элементов управления
            this.Controls.Add(listView1);

            Width = 350; // Ширина формы
            Height = 250; // Высота формы
        }
    }
}
