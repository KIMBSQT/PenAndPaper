﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_r_layeh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool changed = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                if (checkBox2.Checked)
                {
                    changed = true;
                    checkBox2.Checked = false;
                }
                if (checkBox3.Checked)
                {
                    changed = true;
                    checkBox3.Checked = false;
                }
                if (checkBox4.Checked)
                {
                    changed = true;
                    checkBox4.Checked = false;
                }
                if (checkBox5.Checked)
                {
                    changed = true;
                    checkBox5.Checked = false;
                }
            }
            else
            {
                changed = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                if (checkBox1.Checked)
                {
                    changed = true;
                    checkBox1.Checked = false;
                }
                if (checkBox3.Checked)
                {
                    changed = true;
                    checkBox3.Checked = false;
                }
                if (checkBox4.Checked)
                {
                    changed = true;
                    checkBox4.Checked = false;
                }
                if (checkBox5.Checked)
                {
                    changed = true;
                    checkBox5.Checked = false;
                }
            }
            else
            {
                changed = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                if (checkBox1.Checked)
                {
                    changed = true;
                    checkBox1.Checked = false;
                }
                if (checkBox2.Checked)
                {
                    changed = true;
                    checkBox2.Checked = false;
                }
                if (checkBox4.Checked)
                {
                    changed = true;
                    checkBox4.Checked = false;
                }
                if (checkBox5.Checked)
                {
                    changed = true;
                    checkBox5.Checked = false;
                }
            }
            else
            {
                changed = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                if (checkBox1.Checked)
                {
                    changed = true;
                    checkBox1.Checked = false;
                }
                if (checkBox2.Checked)
                {
                    changed = true;
                    checkBox2.Checked = false;
                }
                if (checkBox3.Checked)
                {
                    changed = true;
                    checkBox3.Checked = false;
                }
                if (checkBox5.Checked)
                {
                    changed = true;
                    checkBox5.Checked = false;
                }
            }
            else
            {
                changed = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                if (checkBox1.Checked)
                {
                    changed = true;
                    checkBox1.Checked = false;
                }
                if (checkBox2.Checked)
                {
                    changed = true;
                    checkBox2.Checked = false;
                }
                if (checkBox4.Checked)
                {
                    changed = true;
                    checkBox4.Checked = false;
                }
                if (checkBox3.Checked)
                {
                    changed = true;
                    checkBox3.Checked = false;
                }
            }
            else
            {
                changed = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
