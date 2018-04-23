using DevExpress.Utils.Animation;
using DevExpress.XtraWizard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            comboBoxEdit1.Properties.Items.Add(TransitionType.ClockTransition);
            comboBoxEdit1.Properties.Items.Add(TransitionType.CombTransition);
            comboBoxEdit1.Properties.Items.Add(TransitionType.CoverTransition);
            comboBoxEdit1.Properties.Items.Add(TransitionType.DissolveTransition);
            comboBoxEdit1.Properties.Items.Add(TransitionType.FadeTransition);
            comboBoxEdit1.Properties.Items.Add(TransitionType.PushTransition);
            comboBoxEdit1.Properties.Items.Add(TransitionType.ShapeTransition);
            comboBoxEdit1.Properties.Items.Add(TransitionType.SlideFadeTransition);
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
            wizardControlAnimationHelper1.TransitionType = (TransitionType)comboBoxEdit1.SelectedItem;
        }

    }
}
