using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.services
{
    static class MessageBoxService
    {
        /// <summary>
        /// Exibe uma MessageBox na tela atual do usuario
        /// </summary>
        /// <param name="caption">Titulo</param>
        /// <param name="message">Mensagem</param>
        public static void ShowMessage(string caption, string message)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
        }
    }
}
