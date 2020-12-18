using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spendBezosMoney.Logica
{
    class LogicaAviao : LogicaBase
    {
        private const int itemValue = 400 * 1000000;
        public override void MeuButton_Click(object sender, EventArgs e)
        {
            ItemMoney = itemValue;
            base.MeuButton_Click(sender, e);
        }
    }
}
