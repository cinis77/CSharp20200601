using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200714_Kvadratai
{
    public partial class Form1 : Form
    {
        PictureBox SelectedPictureBox;

        Dictionary<char, Action<PictureBox>> MovementStrategy;

        public Form1()
        {
            InitializeComponent();
            MovementStrategy = new Dictionary<char, Action<PictureBox>>()
            {
                { 'w', GoUp },
                { 's', GoDown},
                { 'a', GoLeft },
                { 'd', GoRight }
            };

            GenerateButton.KeyPress += Kvardratas_KeyDown;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            PictureBox kvadratas = new PictureBox();
            kvadratas.BorderStyle = BorderStyle.FixedSingle;
            kvadratas.Size = new Size(15, 15);
            kvadratas.Click += Kvadratas_Click;
            
            kvadratas.Location = new Point(Width / 2, Height / 2);
            Controls.Add(kvadratas);
        }

       

        private void Kvadratas_Click(object sender, EventArgs e)
        {
            if (SelectedPictureBox != null)
            {
                SelectedPictureBox.BackColor = Color.Gray;
            }
            ((PictureBox)sender).BackColor = Color.Green;
            SelectedPictureBox = (PictureBox)sender;
        }

        private void  Kvardratas_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (SelectedPictureBox != null)
            {
                MovementStrategy[e.KeyChar](SelectedPictureBox);
            }
        }

        private void GoUp(PictureBox pic)
        {
            pic.Location =
                        new Point(pic.Location.X,
                        pic.Location.Y - 10);
        }

        private void GoDown(PictureBox pic)
        {
            pic.Location =
                        new Point(pic.Location.X,
                        pic.Location.Y + 10);
        }

        private void GoLeft(PictureBox pic)
        {
            pic.Location =
                        new Point(pic.Location.X - 10,
                        pic.Location.Y);
        }

        private void GoRight(PictureBox pic)
        {
            pic.Location =
                        new Point(pic.Location.X + 10,
                        pic.Location.Y);
        }

        private bool IsThereCollision(Point location)
        {
            foreach (Control item in Controls)
            {
                if (item is PictureBox)
                {
                    
                }
            }

            return false;
        }
    }
}
