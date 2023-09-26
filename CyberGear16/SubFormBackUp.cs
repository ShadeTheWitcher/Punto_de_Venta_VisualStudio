using CyberGear16.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class SubFormBackUp : Form
    {
        private readonly BdCybergearContext _context; // DbContext de Entity Framework

        public SubFormBackUp(BdCybergearContext context)
        {
            InitializeComponent();
            _context = context;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
