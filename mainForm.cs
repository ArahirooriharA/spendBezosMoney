using spendBezosMoney.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spendBezosMoney
{
    public partial class mainForm : Form
    {
        LogicaAviao logicaAviao = null;
        LogicaGuitarra logicaGuitarra = null;
        LogicaJeans logicaJeans = null;
        LogicaCasa logicaCasa = null;
        LogicaIphone logicaIphone = null;
        LogicaCarro logicaCarro = null;
        LogicaHamburguer logicaHamburguer = null;
        LogicaTerno logicaTerno = null;
        public mainForm()
        {
            InitializeComponent();
            logicaAviao = new LogicaAviao { BezosMoney = bezosMoney , MeuButton = btnAviao};
            logicaGuitarra = new LogicaGuitarra { BezosMoney = bezosMoney, MeuButton = btnGuitarra };
            logicaCarro = new LogicaCarro { BezosMoney = bezosMoney, MeuButton = btnCarro };
            logicaHamburguer = new LogicaHamburguer { BezosMoney = bezosMoney, MeuButton = btnBurguer };
            logicaIphone = new LogicaIphone { BezosMoney = bezosMoney, MeuButton = btnIphone };
            logicaJeans = new LogicaJeans { BezosMoney = bezosMoney, MeuButton = btnJeans };
            logicaCasa = new LogicaCasa { BezosMoney = bezosMoney, MeuButton = btnCasa };
            logicaTerno = new LogicaTerno { BezosMoney = bezosMoney, MeuButton = btnTerno };
        }

    }
}
