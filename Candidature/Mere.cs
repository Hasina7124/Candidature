﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candidature
{
    public partial class Mere : Form
    {
        public Mere()
        {
            InitializeComponent();
            Navigation navigation = new Navigation(new Acceuil(), conteneur);
        }
    }
}
