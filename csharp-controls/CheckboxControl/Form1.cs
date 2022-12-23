using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxControl
{
    public partial class Form1 : Form
    {
        private bool _checkboxDramaEventFlag = false;
        private bool _checkboxActionEventFlag = false;
        private bool _checkboxScienceFictionEventFlag = false;

        public Form1()
        {
            InitializeComponent();

            this.checkboxMovieTypeDrama.MouseEnter += new System.EventHandler(this.checkboxMovieType_MouseEnter);
            this.checkboxMovieTypeDrama.MouseLeave += new System.EventHandler(this.checkboxMovieType_MouseLeave);

            _checkboxDramaEventFlag = true;

            this.checkboxMovieTypeScienceFiction.MouseEnter += new System.EventHandler(this.checkboxMovieType_MouseEnter);
            this.checkboxMovieTypeScienceFiction.MouseLeave += new System.EventHandler(this.checkboxMovieType_MouseLeave);

            _checkboxActionEventFlag = true;
        
            this.checkboxMovieTypeAction.MouseEnter += new System.EventHandler(this.checkboxMovieType_MouseEnter);
            this.checkboxMovieTypeAction.MouseLeave += new System.EventHandler(this.checkboxMovieType_MouseLeave);

            _checkboxScienceFictionEventFlag = true;
    }

        private void checkboxMovieType_MouseEnter(object sender, EventArgs e)
        {
            CheckBox checkboxControl = (CheckBox)sender;
            checkboxControl.ForeColor = Color.Red;

            if(checkboxControl.Name.ToUpper().Contains("DRAMA"))
            {
                if (_checkboxActionEventFlag) {
                    this.checkboxMovieTypeAction.MouseEnter -= new System.EventHandler(this.checkboxMovieType_MouseEnter);
                    this.checkboxMovieTypeAction.MouseLeave -= new System.EventHandler(this.checkboxMovieType_MouseLeave);
                    _checkboxActionEventFlag = false;
                }

            }
            else if (checkboxControl.Name.ToUpper().Contains("SCİENCE"))
            {
                if (!_checkboxActionEventFlag)
                {
                    this.checkboxMovieTypeAction.MouseEnter  += new System.EventHandler(this.checkboxMovieType_MouseEnter);
                    this.checkboxMovieTypeAction.MouseLeave  += new System.EventHandler(this.checkboxMovieType_MouseLeave);
                    _checkboxActionEventFlag = true;
                }
            }
        }

        private void checkboxMovieType_MouseLeave(object sender, EventArgs e)
        {
            CheckBox checkboxControl = (CheckBox)sender;
            checkboxControl.ForeColor = Color.Black;
        }

        private void checkboxMovieTypeDrama_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
