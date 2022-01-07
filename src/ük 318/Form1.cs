namespace ÜK_318
{
    public partial class Form1 : Form
    {
        
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }
      
        private void ActivateButton(object btnSender)
        {
           
        }
       
        //Eine Methode die für die button damit die ein neues forms aufmachen 
        private void OpenChildForm(Form childForm, object btnSender)
        {

            if (activeForm!= null) 
            { 
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Verbindungssuche(), sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonAbfahrtstafel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAbfahrttafel(), sender);
        }

        private void buttonZugverlauf_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Zugverlauf(), sender);
        }
    }
}