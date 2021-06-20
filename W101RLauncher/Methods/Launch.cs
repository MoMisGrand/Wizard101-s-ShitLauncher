using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using W101RLauncher.Forms;

namespace W101RLauncher.Methods
{
    public static class Launch
    {
        public static void Wizard101(List<TextBox> list, bool password)
        {
            var flag = false;
            var split = list[0].Text.Split(':');
            
            try
            {
                flag = Authentication.ServerAuthentication(split[0], split[1], list[1].Text, list[3].Text,
                    list[2].Text);
            }
            catch
            {
                var errorIpFormat = new PopupForm(Properties.Resources.error_ipformat);
                errorIpFormat.ShowDialog();
                GC.Collect();
            }

            if (!flag) return;
            var wiz = new ProcessStartInfo
            {
                FileName = "WizardGraphicalClient.exe",
                WorkingDirectory = @"",
                Arguments = "-L " + "" + " " + "" + " -U .... " + list[1].Text
            };
            try
            {
                Process.Start(wiz);
                Datatable.WriteData(list, password);
            }
            catch
            {
                var errorLocated = new PopupForm(Properties.Resources.error_located);
                errorLocated.ShowDialog();
                GC.Collect();
            }
        }
    }
}