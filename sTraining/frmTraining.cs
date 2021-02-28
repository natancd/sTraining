using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sTraining
{
    public partial class frmTraining : Form
    {
        List<ListViewItem> masterlist;

        public frmTraining()
        {
            InitializeComponent();
            masterlist = new List<ListViewItem>();
        }

        private void lvwCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Quando o usuário clicar Salvar ou pressionar Enter, verifica se todos os campos estão preenchidos e de acordo com os critérios (strings, números)
        /// e adiciona o cadastro da pessoa, sala a e espaço na listagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnEnter_Click(object sender, EventArgs e)
        {
            //variáveis
            bool isValidFirstName = true;
            bool isValidLastName = true;
            bool isValidPlace = true;
            bool isValidSpace = true;
            bool isValidCapacity = true;            

            // valida os nomes
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("O nome deve ser preenchido!");
                txtFirstName.Focus();
                isValidFirstName = false;
            }

            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("O sobrenome deve ser preenchido!");
                txtLastName.Focus();
                isValidLastName = false;
            }

            // valida a sala do evento
            else if (string.IsNullOrEmpty(txtEvent.Text))
            {
                MessageBox.Show("A sala do evento deve ser preenchida!");
                txtEvent.Focus();
                isValidPlace = false;
            }

            //valida a lotação da sala
            else if (numEventCapacity.Value == 0)
            {
                MessageBox.Show("Capcidade mínima: 1 pessoa");
                numEventCapacity.Select();
                isValidCapacity = false;
            }

            //valida o espaço do café
            else if (string.IsNullOrEmpty(txtSpace.Text))
            {
                MessageBox.Show("O espaço do café deve ser preenchido!");
                txtSpace.Focus();
                isValidSpace = false;
            }

            // cria uma lista para adicionar no listview
            if (isValidFirstName == true && isValidLastName == true && isValidPlace == true && isValidCapacity == true && isValidSpace == true)
            {
                //lista as pessoas criadas
                PersonList();
                
                //limpa os campos para novos inputs
                ClearFields();
            }
        }

        private void lvwPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            //a cada seleçao na lista, informa no campo abaixo (lblResult) do listview as informações da pessoa selecionada
            if (lvwPerson.SelectedIndices.Count <= 0)
            {
                return;
            }
            int index = lvwPerson.SelectedIndices[0];
            if (index >= 0)
            {
                string personName = lvwPerson.Items[index].Text;
                string placeName = lvwPerson.Items[index].SubItems[1].Text;
                string spaceName = lvwPerson.Items[index].SubItems[2].Text;
                lblResult.Text = "A pessoa " + personName + " está na sala " + placeName + "("  + ") no espaço " + spaceName + ".";
                btnEvent.Text = placeName;
                btnSpace.Text = spaceName;
                btnEvent.Visible = true;
                btnSpace.Visible = true;
                lblEventResult.Visible = true;
                lblSpaceResult.Visible = true;
            }
        }
        public void PersonList()
        {
            string person = "";
            string place = "";
            string space = "";
            int roomCapacity = 0;
            person = txtFirstName.Text + " " + txtLastName.Text;
            place = txtEvent.Text;
            roomCapacity = place.Count();
            space = txtSpace.Text;
            ListViewItem list = new ListViewItem();
            list.Text = person;
            list.SubItems.Add(place);
            list.SubItems.Add(space);
                                 
            lvwPerson.Items.Add(list);
            lblResult.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //limpa todos os campos variáveis (textbox, listview e label), questionando antes de confirmar
            const string message = "Você realmente deseja limpar todas as informações? Não será possível recupera-las!";
            var result = MessageBox.Show(message, "Deseja limpar?",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ClearFields();
                lvwPerson.Items.Clear();
            }            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // sai do programa, qustionando antes de confirmar
            const string message = "Você deseja sair do programa? As informações serão perdidas!";
            var result = MessageBox.Show(message, "Deseja sair?",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        /// <summary>
        /// Método para limpar todos os campos variáveis
        /// </summary>
        private void ClearFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEvent.Text = "";
            txtSpace.Text = "";
            numEventCapacity.Value = 0;
            lblResult.Text = "";
            txtFirstName.Focus();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Select();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void btnEvent_Click(object sender, EventArgs e)
        {
            frmEventList eventList = new frmEventList();
            eventList.Text = "Listagem da Sala de Eventos " + btnEvent.Text;
            eventList.ShowDialog();
        }

        public void btnSpace_Click(object sender, EventArgs e)
        {
            frmSpaceList eventList = new frmSpaceList();
            eventList.Text = "Listagem do Espaço de Café " + btnSpace.Text;
            eventList.ShowDialog();
            
        }
    }
}
