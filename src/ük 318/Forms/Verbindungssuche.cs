using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Models;


namespace ÜK_318.Forms
{
    public partial class Verbindungssuche : Form
    {
        private readonly ITransport transport = new Transport();
        private readonly BindingList<string> suggestions = new BindingList<string>();
        public Verbindungssuche()
        {
            InitializeComponent();
            this.listBox1.DataSource = this.suggestions;
            this.listBoxDrop.DataSource = this.suggestions;
        }
        private readonly ITransport Verbindung = new Transport();

       //Die verbindung, name der station
        private void buttonSuche_Click(object sender, EventArgs e)
        {
            //Textbox eingabe speichern
            string StartStationInput = this.textBoxStartstation.Text;
            string EndStationInput = this.textBoxEndstation.Text;

            Connections Connection = this.Verbindung
            .GetConnections(StartStationInput, EndStationInput);

            var values = Connection.ConnectionList
           .Select(x => new ConnectionX(x.To.Station.Name, x.From.Station.Name, x.Duration))
           .ToList();


            var bindingList = new BindingList<ConnectionX>(values);
   
            Grid.DataSource = bindingList;

        
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

        }

        private void textBoxStartstation_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_Mouseclick(object sender, MouseEventArgs e)
        {
            for (var index = 0; index < this.listBox1.Items.Count; index++)
            {
                if (this.listBox1.GetItemRectangle(index).Contains(e.Location))
                {
                    this.textBoxStartstation.Text = this.listBox1.Items[index].ToString();
                }
            }
            this.listBox1.Visible = false;
        }

        private void textBoxStartstation_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxStartstation.Text))
            {
                return;
            }

            string stationQuery = this.textBoxStartstation.Text;

            Stations result = this.transport.GetStations(stationQuery);
            this.suggestions.Clear();
            foreach (var station in result.StationList)
            {
                this.suggestions.Add(station.Name);
            }

            this.listBox1.Visible = true;
        }

        private void listBoxDrop_SelectedIndexChanged(object sender, MouseEventArgs e)
        {
           //
        }
        private void listBoxDrop_Mouseclick(object sender, MouseEventArgs e)
        {
            for (var index = 0; index < this.listBoxDrop.Items.Count; index++)
            {
                if (this.listBoxDrop.GetItemRectangle(index).Contains(e.Location))
                {
                    this.textBoxEndstation.Text = this.listBoxDrop.Items[index].ToString();
                }
            }
            this.listBoxDrop.Visible = false;
        }

        private void textBoxEndstation_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxEndstation.Text))
            {
                return;
            }

            string stationQuery = this.textBoxEndstation.Text;

            Stations result = this.transport.GetStations(stationQuery);
            this.suggestions.Clear();
            foreach (var station in result.StationList)
            {
                this.suggestions.Add(station.Name);
            }

            this.listBoxDrop.Visible = true;
            
        }

        private record ConnectionX(string To, string From, string Duration);
    }
}
