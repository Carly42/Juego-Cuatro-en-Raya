﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego4enRaya
{
    public partial class Program : Form
    {
        private Rectangle[] boardColumns;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public Program()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
