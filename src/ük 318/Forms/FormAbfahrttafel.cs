using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace ÜK_318.Forms
{
    public partial class FormAbfahrttafel : Form
    {
        public FormAbfahrttafel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lable4_Click(object sender, EventArgs e)
        {

        }
        private readonly ITransport transport = new Transport();
        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            string startStationInput = this.textBoxHaltestelle.Text;


                 Stations Station = this.transport
                .GetStations(startStationInput);


                var id = Station.StationList
                .Select(Value => new RecordGridTabelle(Value.Id))
                .ToString();

                  StationBoardRoot StationBoardRoot = this.transport
                .GetStationBoard(startStationInput, id);


                 var values = StationBoardRoot.Entries
                .Select(Value => new RecordGridTabelleEnde(Value.Name, Value.Category, Value.Number, Value.To, Value.Operator, Value.Stop))
                .ToList();

                 var bindingList = new BindingList<RecordGridTabelleEnde>(values);
                 GridAbfahrttafel.DataSource = bindingList;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private record RecordGridTabelle(string id);

        private record RecordGridTabelleEnde(string name, string category, string number, string To, string Operator, Stop Stop);
    }
}
