using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BracketSeeder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] seeded;

        private void btnRandomSeed_Click(object sender, EventArgs e)
        {
            string[] names = new string[getNoParticipants()];
            seeded = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                if (i < txtSeeds.Lines.Length)
                {
                    names[i] = txtSeeds.Lines[i];
                }
                else
                {
                    names[i] = "-";
                }
            }
            Random rnd = new Random();
            seeded = names.OrderBy(x => rnd.Next()).ToArray();
            txtSeeds.Lines = seeded;
        }



        public int getNoParticipants()
        {
            return (int)Math.Pow(2, Math.Ceiling(Math.Log(txtSeeds.Lines.Length, 2)));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if(seeded.Length > 0)
                File.WriteAllLines(saveFileDialog1.FileName, seeded);
        }
    }
}
