using atyagin_apteka;
using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matyagin_apteka
{
    public partial class NewApplication : Form
    {
        public NewApplication()
        {
            InitializeComponent();
            using (var db = new Apteka())
            {
                comboBox1.DisplayMember = "medicineName";
                comboBox1.ValueMember = "medicinceId";
                comboBox1.DataSource = db.medicines.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var quantity = (int)numericUpDown1.Value;
            if (quantity <= 0)
            {
                MessageBox.Show("Введите корректное количество");
                return;
            }
            using (var db = new Apteka())
            {
                var application = new applications
                {
                    pharmacyId = UserState.User.pharmacyId,
                    applicationDate = DateTime.Now
                };
                var procurements = new procurements
                {
                    applications = application,
                    medicinceId = (int)comboBox1.SelectedValue,
                    quantity = quantity
                };
                db.applications.Add(application);
                db.procurements.Add(procurements);
                db.SaveChanges();
                MessageBox.Show("Заявка успешно создана");
            }
        }
    }
}
