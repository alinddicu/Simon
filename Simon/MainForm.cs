using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    /* Description: 
     * 
     * Four colored buttons light up in a specific pattern. 
     * After displaying the pattern, the player must repeat the pattern by clicking the buttons in proper order. 
     * The pattern gets longer each time the player completes the pattern. 
     * If the player presses a wrong button, the game ends. 
     * 
     * http://inventwithpython.com/blog/2012/02/20/i-need-practice-programming-49-ideas-for-game-clones-to-code/
     * 
     */
    public partial class MainForm : Form
    {
        public MainForm()
        {
            StartPosition= FormStartPosition.CenterScreen;
            InitializeComponent();
        }
    }
}
