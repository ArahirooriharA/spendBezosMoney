using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spendBezosMoney.Logica
{
    class LogicaCasa : LogicaBase
    {
        private const int ItemValue = 150 * 1000 * 1000;
        public override void MeuButton_Click(object sender, EventArgs e)
        {
            ItemMoney = ItemValue;
            base.MeuButton_Click(sender, e);
        }
    }
}
