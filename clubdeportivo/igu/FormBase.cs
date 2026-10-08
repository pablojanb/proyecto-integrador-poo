
namespace clubdeportivo.igu
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.Icon = new Icon(
                new MemoryStream(Properties.Resources.ifts_icon)
            );
        }
    }
}
