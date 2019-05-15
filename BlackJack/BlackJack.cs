using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public class BlackJack
    {
        Game m_game;
        Menu m_menu;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BlackJack blackJack = new BlackJack();
        }

        public BlackJack()
        {
            this.m_menu = new Menu(this);
            Application.Run(m_menu);
        }

        public void newGame(int nbPlayer, int nbBot)
        {
                this.m_game = new Game(nbPlayer, nbBot); 
        }
    }
}
