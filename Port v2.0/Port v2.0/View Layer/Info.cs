using System.Windows.Forms;

namespace Port_v2._0
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cyberguru.ru/microsoft-net/csharp-net/csharp-three-tier-architecture.html?showall=1");
        }
    }
}
