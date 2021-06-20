using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace W101RLauncher.Methods
{
    public static class Datatable
    {
        public static void WriteData(IReadOnlyList<TextBox> list, bool password)
        {
            //Create datatable
            var data = new DataTable("Data");
            
            //Add columns
            data.Columns.Add("ServerIP", typeof(string));
            data.Columns.Add("Username", typeof(string));
            data.Columns.Add("AlphaKey", typeof(string));
            data.Columns.Add("Password", typeof(string));
            
            //Add a row
            var dataRow = data.NewRow();
            dataRow["ServerIP"] = list[0].Text;
            dataRow["Username"] = list[1].Text;
            dataRow["Alphakey"] = list[2].Text;
            if (password)
            {
                dataRow["Password"] = list[3].Text;
            }
            else
            {
                dataRow["Password"] = "";
            }
            data.Rows.Add(dataRow);
            
            //Write to xml
            data.WriteXml("data.xml");
        }
        
        public static void WriteSettings(bool password, bool launcher)
        {
            //Create datatable
            var settings = new DataTable("Settings");
            
            //Add columns
            settings.Columns.Add("KeepLauncherOpen", typeof(bool));
            settings.Columns.Add("SavePassword", typeof(bool));
            
            //Add a row
            var settingsRow = settings.NewRow();
            settingsRow["KeepLauncherOpen"] = launcher;
            settingsRow["SavePassword"] = password;
            settings.Rows.Add(settingsRow);
            
            //Write to xml
            settings.WriteXml("settings.xml");
        }

        public static void WritePassword()
        {
            var data = ReadData();
            data.Rows[0]["Password"] = "";
            data.WriteXml("data.xml");
        }

        public static DataTable ReadData()
        {
            //Create datatable
            if (!File.Exists("data.xml")) return null;
            var data = new DataTable("Data");
            
            //Add columns
            data.Columns.Add("ServerIP", typeof(string));
            data.Columns.Add("Username", typeof(string));
            data.Columns.Add("AlphaKey", typeof(string));
            data.Columns.Add("Password", typeof(string));
            
            //Read the xml
            data.ReadXml("data.xml");
            return data;
        }
        
        public static DataTable ReadSettings()
        {
            //Create datatable
            if (!File.Exists("settings.xml")) return null;
            var settings = new DataTable("Settings");
            
            //Add columns
            settings.Columns.Add("KeepLauncherOpen", typeof(bool));
            settings.Columns.Add("SavePassword", typeof(bool));
            
            //Read the xml
            settings.ReadXml("settings.xml");
            return settings;
        }
    }
}