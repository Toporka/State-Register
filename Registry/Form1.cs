using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry
{
    public partial class Registry : Form
    {
        List<Trader> traders = new List<Trader>()
        {
            new Trader("Покачалов", "Никита", "Саныч",
                "123456789012", "1234567890123", "-"),
            new Trader("Афанасьев", "Влад", "Палыч",
                "098765432109", "0987654321098", "@"),
        };
        List<Entity> entities = new List<Entity>()
        {
            new Entity("Бурдинский", "Егор", "Михалыч",
                "112233445566", "1122334455667", "&"),
            new Entity("Разгулов", "Александр", "Сергич",
                "665544332211", "6655443322110", "-"),
        };
        public Registry()
        {
            InitializeComponent();
            INN_OGRN.SelectedItem = "ИНН";
            errorWrData.SetError(WriteData, "Поле должно быть заполнено.");
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            Loading.PerformStep();
            if (Loading.Value == 100)
            {
                labSearch.Visible = false;
                Loading.Visible = false;
                timerLoading.Enabled = false;
                INN_OGRN.Enabled = true;
                WriteData.Enabled = true;
                LegalEntity.Enabled = true;
                SoleTrader.Enabled = true;
                butGetReq.Enabled = true;
                CheckSign.Enabled = true;
                Print.Enabled = true;
                SaveDoc.Enabled = true;

                Datas.Items.Clear();

                if (INN_OGRN.Text == "ИНН" & LegalEntity.Checked)
                    foreach (var item in entities)
                        SearchEntity(item, item.inn);
                else if (INN_OGRN.Text == "ОГРН" & LegalEntity.Checked)
                    foreach (var item in entities)
                        SearchEntity(item, item.ogrn);
                else if (INN_OGRN.Text == "ИНН" & SoleTrader.Checked)
                    foreach (var item in traders)
                        SearchTrader(item, item.inn);
                else if (INN_OGRN.Text == "ОГРН" & SoleTrader.Checked)
                    foreach (var item in traders)
                        SearchTrader(item, item.ogrn);

                if (Datas.Items.Count == 0)
                    Datas.Items.Add("Совпадений не найдено.");
            }
        }

        private void butGetReq_Click(object sender, EventArgs e)
        {
            if (errorWrData.GetError(WriteData) == "")
            {
                Datas.Items.Clear();
                Loading.Value = 0;

                INN_OGRN.Enabled = false;
                WriteData.Enabled = false;
                LegalEntity.Enabled = false;
                SoleTrader.Enabled = false;
                butGetReq.Enabled = false;
                CheckSign.Enabled = false;
                Print.Enabled = false;
                SaveDoc.Enabled = false;
                labSearch.Visible = true;
                Loading.Visible = true;
                timerLoading.Enabled = true;
                timerLoading.Tick += timerLoading_Tick;
            }
        }
        private void SearchEntity(Entity item, string item_str)
        {
            if (WriteData.Text == item_str)
                Datas.Items.AddRange(new string[] { item.surname,
                    item.name, item.middle_name, item.inn, item.ogrn, item.sign});
        }
        private void SearchTrader(Trader item, string item_str)
        {
            if (WriteData.Text == item_str)
                Datas.Items.AddRange(new string[] { item.surname,
                    item.name, item.middle_name, item.inn, item.ogrn, item.sign});
        }

        private void WriteData_Validating(object sender, CancelEventArgs e)
        {
            if (WriteData.Text == "")
                errorWrData.SetError(WriteData, "Поле должно быть заполнено.");
            else
                errorWrData.Clear();
        }

        private void CheckSign_Click(object sender, EventArgs e)
        {
            if (Datas.Items.Count < 2)
                errorSign.SetError(CheckSign, ".Подпись может быть проверена " +
                    "лишь при нахождении определённой личности");
            else if ((string)Datas.Items[5] == "-")
            {
                MessageBox.Show("Подпись некорректна.");
                errorSign.Clear();
            }
            else
            {
                MessageBox.Show("Подпись корректна.");
                errorSign.Clear();
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (Datas.Items.Count < 2)
                errorPrint.SetError(Print, ".Печать может быть проведена " +
                    "лишь при нахождении определённой личности");
            else
            {
                MessageBox.Show("Данные отправлены на печать.");
                errorPrint.Clear();
            }
        }

        private void SaveDoc_Click(object sender, EventArgs e)
        {
            if (Datas.Items.Count < 2)
                errorSave.SetError(SaveDoc, ".Запись в файл может быть проведена " +
                    "лишь при нахождении определённой личности");
            else
            {
                string[] new_datas = new string[Datas.Items.Count];
                for (int i = 0; i < Datas.Items.Count; i++)
                    new_datas[i] = (string)Datas.Items[i];
                File.WriteAllLines(@"Humans.txt", new_datas);

                MessageBox.Show("Запись в файл проведена успешно.");
                errorSave.Clear();
            }
        }
    }
}
