using System;
using System.Windows.Forms;

class Arguments
{
    private static readonly string APP_NAME = "Arguments";
    static void Main(string[] args)
    {
        if(args == null || args.Length == 0)
        {
            MessageBox.Show("No arguments", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        } else
        {
            string msg = "";
            for (int i = 0; i < args.Length; ++i)
            {
                msg += (i + 1) + ". " + args[i] + Environment.NewLine;
            }
            MessageBox.Show(msg, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
