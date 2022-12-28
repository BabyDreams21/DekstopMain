using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hubstaf
{
    public partial class todos : UserControl
    {
        public event EventHandler UserControlClicked;
        public todos()
        {
            InitializeComponent();
            //this.Click += ControlClicked;
            
        }

        private void ControlClicked(EventArgs e)
        {
            UserControlClicked?.Invoke(this, e);
        }


        private string _todo;
        private string _tanggal;
        public int idProject { get; set; }
        public string nameTodo { get; set; }
        public string description { get; set; }
        public string changed { get; set; }
        public int status { get; set; }
        public string todoName
        {
            get { return _todo; }
            set { _todo = value; todo.Text = value; }
        }
        public string Tanggal
        {
            get { return _tanggal; }
            set { _tanggal = value; tanggal.Text = value; }
        }
    }
}
