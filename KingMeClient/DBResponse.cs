using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingMeClient
{
    public class DBResponse
    {
        public bool error = false;
        public string response = "";
        public string[] list;

        public DBResponse(string resp)
        {
            resp = resp.Trim();
            if (resp.StartsWith("ERRO:"))
            {
                this.error = true;
                this.response = resp.Replace("ERRO:", "").Trim();
                return;
            }

            this.response = resp.Replace("\r\n", "\n");
            this.list = this.response.Split('\n');
        }

        public void ShowError()
        {
            if (!this.error)
                return;

            MessageBox.Show(this.response, "Error");
        }

    }
}
