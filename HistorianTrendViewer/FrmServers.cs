using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HistorianTrendViewer.BL;

namespace HistorianTrendViewer
{
    public interface IFrmServers
    {
        event EventHandler ServerSelected;
        event EventHandler ViewLoaded;

        event EventHandler SaveServerClick;
        event EventHandler RemoveServerClick;
        event EventHandler CloseClick;
        event EventHandler AddServerClick;
        event EventHandler NewServerClick;

        HistorianServer SelectedServer { get; set; }
        string SelectedServerId { get; }

        void LoadServersList(ReadOnlyCollection<HistorianServer> _servers);
        void LoadServerDetails(HistorianServer _server);
        void UpdateList();
    }
//================================================================================================
//================================================================================================
    public partial class FrmServers : Form, IFrmServers
    {
        // реализация интерфейса
        #region IFrmServers

        public event EventHandler ServerSelected;
        public event EventHandler ViewLoaded;
        public event EventHandler SaveServerClick;
        public event EventHandler RemoveServerClick;
        public event EventHandler CloseClick;
        public event EventHandler AddServerClick;
        public event EventHandler NewServerClick;

        public HistorianServer SelectedServer { get; set; }

        public string SelectedServerId
        {
            get { return listBoxServers.SelectedIndex > -1 ? listBoxServers.SelectedValue.ToString(): null; }
        }

        public void LoadServersList(ReadOnlyCollection<HistorianServer> _servers)
        {
            bsServers.DataSource = _servers;
            listBoxServers.DataSource = bsServers;
            listBoxServers.DisplayMember = "Name";
            listBoxServers.ValueMember = "Id";
            //listBoxServers.SelectedIndex = -1;
        }

        public void LoadServerDetails(HistorianServer _server)
        {
            bsSelectedServer.DataSource = _server;
        }

        public void UpdateList()
        {
            bsServers.ResetBindings(false);
        }

        #endregion

        private BindingSource bsServers = new BindingSource();

        public FrmServers()
        {
            InitializeComponent();

            this.Shown += new EventHandler(FrmServers_Shown);
            this.FormClosing += new FormClosingEventHandler(FrmServers_FormClosing);
        }

        private void FrmServers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseClick != null) CloseClick(this, EventArgs.Empty);
        }

        private void FrmServers_Shown(object sender, EventArgs e)
        {
            tBoxServerName.Focus();
        }
        
        private void FrmServers_Load(object sender, EventArgs e)
        {
            if (ViewLoaded != null) ViewLoaded(this, EventArgs.Empty);

            if (listBoxServers.Items.Count > 0)
                listBoxServers.SetSelected(0, true);

        }

        private void listBoxServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = (!string.IsNullOrEmpty(tBoxServerName.Text) && listBoxServers.SelectedIndex == -1) ? true : false;
            btnSave.Enabled = (!string.IsNullOrEmpty(tBoxServerName.Text) && listBoxServers.SelectedIndex > -1) ? true : false;
            
            btnLogOnLogOff.Enabled = (listBoxServers.SelectedIndex > -1) ? true : false;

            if (ServerSelected != null && listBoxServers.SelectedIndex > -1) ServerSelected(this, EventArgs.Empty);
            if (listBoxServers.SelectedIndex == -1) NewServerClick(this, EventArgs.Empty);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (RemoveServerClick != null) RemoveServerClick(this, EventArgs.Empty);
            if (ServerSelected != null) ServerSelected(this, EventArgs.Empty);
        }

        private void chBoxTrustedConnection_CheckedChanged(object sender, EventArgs e)
        {
            tBoxLoginID.Enabled = tBoxPassword.Enabled = (sender as CheckBox).Checked ? false : true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBoxServerName_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = (!string.IsNullOrEmpty((sender as TextBox).Text) && listBoxServers.SelectedIndex == -1) ? true : false;

            btnSave.Enabled = (!string.IsNullOrEmpty((sender as TextBox).Text) && listBoxServers.SelectedIndex > -1) ? true : false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveServerClick != null) SaveServerClick(this, EventArgs.Empty);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddServerClick != null) AddServerClick(this, EventArgs.Empty);

            listBoxServers.SetSelected(listBoxServers.Items.Count - 1, true);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
                listBoxServers.SelectedIndex = -1;
                tBoxServerName.Focus();
        }

        private void btnLogOnLogOff_Click(object sender, EventArgs e)
        {
            //if (hs.GetServerByIndex(listBoxServers.SelectedIndex).CheckConnection())
            //    MessageBox.Show("Подключение прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("Подключение установить не удалось!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
