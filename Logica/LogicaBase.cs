using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spendBezosMoney.Logica
{
    public class LogicaBase
    {
        public int BezosValueBase { get; set; }
        Button meuButton;
        public Button MeuButton
        {
            get
            {
                return meuButton;
            }
            set
            {
                meuButton = value;
                meuButton.Click += new EventHandler(this.MeuButton_Click);
            }
        }

        public int ItemMoney { get; set; }
        public Label BezosMoney { get; set; }
        private bool Continue { get; set; }

        public virtual void MeuButton_Click(object sender, EventArgs e)
        {
            var bezosActualMoney = Convert.ToInt64(BezosMoney.Text.Split(" ")[0].Substring(1));
            var bezosMoney = (bezosActualMoney - ItemMoney).ToString();
            BezosMoney.Text = "$" + bezosMoney.ToString();

            if (Convert.ToInt64(BezosMoney.Text.Substring(1)) <= 0 && !Continue)
            {
                if (MessageBox.Show("Caramba, você conseguiu gastar todo o dinheiro dele, deseja endivida-lo?", "Encerrar", MessageBoxButtons.YesNo) == DialogResult.No)
                    Application.Exit();
                else
                    Continue = true;
            }  
        }
    }
}
