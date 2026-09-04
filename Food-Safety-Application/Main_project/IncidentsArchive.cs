using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Main_project.Models;

namespace Main_project
{
    public partial class IncidentsArchive : Form
    {
        public IncidentsArchive()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.IncidentsArchive_Load);
            this.SuspendLayout();
            
            Label titleLabel = new Label() { Text = "Food Safety Incidents Archive", Left = 20, Top = 20, Width = 400, Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold) };
            
            ListBox incidentsListBox = new ListBox() { Name = "IncidentsListBox", Left = 20, Top = 60, Width = 450, Height = 300 };
            
            Label filterLabel = new Label() { Text = "Filter by Status:", Left = 20, Top = 370, Width = 100 };
            ComboBox statusFilterCB = new ComboBox() { Name = "StatusFilterCB", Left = 130, Top = 370, Width = 150 };
            statusFilterCB.Items.Add("All");
            statusFilterCB.Items.Add("Resolved");
            statusFilterCB.Items.Add("Pending");
            statusFilterCB.Items.Add("Investigating");
            statusFilterCB.SelectedIndex = 0;
            statusFilterCB.SelectedIndexChanged += new System.EventHandler(this.StatusFilterCB_SelectedIndexChanged);
            
            Button backBtn = new Button() { Name = "BackBtn", Text = "Back", Left = 410, Top = 370, Width = 60 };
            backBtn.Click += new System.EventHandler(this.BackBtn_Click);

            this.Controls.Add(titleLabel);
            this.Controls.Add(incidentsListBox);
            this.Controls.Add(filterLabel);
            this.Controls.Add(statusFilterCB);
            this.Controls.Add(backBtn);
            
            this.Text = "Incidents Archive";
            this.Size = new System.Drawing.Size(510, 450);
            this.ResumeLayout();
        }

        private void IncidentsArchive_Load(object sender, EventArgs e)
        {
            RefreshIncidentsList("");
        }

        private void RefreshIncidentsList(string filter)
        {
            ListBox incidentsListBox = this.Controls["IncidentsListBox"] as ListBox;
            incidentsListBox.Items.Clear();

            List<Incident> incidents = DatabaseHelper.GetIncidents();
            foreach (Incident incident in incidents)
            {
                if (filter == "All" || incident.Status == filter)
                {
                    incidentsListBox.Items.Add($"[{incident.IncidentDate}] {incident.Title} ({incident.Location}) - Status: {incident.Status}");
                }
            }
        }

        private void StatusFilterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox statusFilterCB = this.Controls["StatusFilterCB"] as ComboBox;
            string selectedFilter = statusFilterCB.SelectedItem?.ToString() ?? "All";
            RefreshIncidentsList(selectedFilter);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Close();
        }
    }
}
