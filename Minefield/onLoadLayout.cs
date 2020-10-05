using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Minefield
{
    class onLoadLayout
    {
        public void onLoadLayoutFunc(Panel panel)     //https://stackoverflow.com/questions/11551079/programmatically-adding-label-to-windows-form-length-of-label
        {
            int i = 1;
            int x = 0;
            int y = 0;

            while(i < 401)
            {
                Label lblGrid = new Label();
                lblGrid.Name = "lblGrid" + i;
                if(x + 20 < 381)
                {
                    lblGrid.Location = new Point(x, y);
                    x = x + 20;
                }
                else
                {
                    y = y + 20;
                    x = 0;
                    lblGrid.Location = new Point(x, y);
                }
                lblGrid.Size = new Size(20, 20);
                lblGrid.BackColor = Color.SkyBlue;
                lblGrid.TabIndex = 0;
                panel.Controls.Add(lblGrid);
                i++;
            }
        }
    }
}