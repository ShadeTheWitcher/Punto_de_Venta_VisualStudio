using CyberGear16.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberGear16
{
    public partial class FormSeccionVentas : Form
    {
        private readonly BdCybergearContext _context; // DbContext de Entity Framework
        public FormSeccionVentas(BdCybergearContext context)
        {
            InitializeComponent();

            _context = context;
        }


















    }
}
