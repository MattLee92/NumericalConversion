using NumericalConversion.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NumericalConversion.Views
{
    public partial class index : System.Web.UI.Page
    {
        NumConvert test = new NumConvert();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmd_convert_Click(object sender, EventArgs e)
        {
            // Convert the users input to a decimal value
            // then pass to conversion function and return output.
            try
            {
                var input = Decimal.Parse(txt_input.Text);
                if (input >= test.getMax())
                {
                    lbl_error.Text = "Input is to high";
                }
                else if (input < 0)
                {
                    lbl_error.Text = "Input is to low";
                }
                else
                {
                    txt_output.Text = test.convertInput(input);
                    lbl_error.Text = "";
                }

            }
            catch
            {
                txt_output.Text = "";
                lbl_error.Text = "Incorrect input Entered";
            }
        }
    }
}