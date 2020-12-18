using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spendBezosMoney.Logica
{
    class LogicaHamburguer : LogicaBase
    {
        public override void MeuButton_Click(object sender, EventArgs e)
        {
            ItemMoney = 300;
            base.MeuButton_Click(sender, e);
        }
    }
}
