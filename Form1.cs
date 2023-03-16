using System.Web;

namespace RelativeImagePaths
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.htmlEditControl1.CSSText = "body {font-family: calibri; font-size: 12pt}";
            this.htmlEditControl1.ImageStorageLocation = AppDomain.CurrentDomain.BaseDirectory + "images";
            this.htmlEditControl1.BaseURL = "file://" + HttpUtility.HtmlEncode(AppDomain.CurrentDomain.BaseDirectory);
            this.htmlEditControl1.UseRelativeURLs = true;

            this.htmlEditControl1.DocumentHTML = "<p>Some testing</p><img src='images/MES_Logo.jpg' />";

        }
    }
}