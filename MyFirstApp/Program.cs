using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    #region MessageBoxes


    //static class Program
    //{
    //    static DialogResult getDialogResult()
    //    {
    //        DialogResult result;
    //        string message = "Window displaying a text message";
    //        //result = MessageBox.Show(message);
    //        string caption = "C# Programming";

    //        //result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel);

    //        result = MessageBox.Show(message, caption, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);


    //        return result;
    //    }

    //    /// <summary>
    //    /// The main entry point for the application.
    //    /// </summary>
    //    [STAThread]
    //    static void Main()
    //    {
    //        //Application.EnableVisualStyles();
    //        //Application.SetCompatibleTextRenderingDefault(false);
    //        //Application.Run(new Form1());

    //        //var result=getDialogResult();

    //        //if (result == DialogResult.OK)
    //        //{
    //        //    MessageBox.Show("You clicked to OK");
    //        //}
    //        //else if (result == DialogResult.Cancel)
    //        //{
    //        //    MessageBox.Show("You clicked to Cancel");
    //        //}

    //        var result = getDialogResult();
    //        if (result == DialogResult.Abort)
    //        {
    //            MessageBox.Show("Abort");
    //        }
    //        else if (result == DialogResult.Ignore)
    //        {
    //            MessageBox.Show("Ignore");
    //        }
    //        else if (result == DialogResult.Retry)
    //        {
    //            MessageBox.Show("Retry");
    //        }



    //    }
    //}
    #endregion

    #region Form and Controls
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
    #endregion
}
