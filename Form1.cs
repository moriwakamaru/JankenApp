using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace じゃんけんアプリ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int computer = new Random().Next(3);
            label1.Text = new Referee().Decision(computer, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int computer = new Random().Next(3);
            label1.Text = new Referee().Decision(computer, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int computer = new Random().Next(3);
            label1.Text = new Referee().Decision(computer, 2);
        }
    }
    public class Referee
    {
       private string[] hand = { "グー", "チョキ", "パー" };

        public  string Decision(int computer,int user)
        {
            string msg= "コンピューターは、" + hand[computer] + "。";
            if (computer == user)
            {
                msg = msg + "引き分け。";
            }
            else if(computer==0&&user==1)
            {
                msg = msg + "あなたの負け。";
            }
            else if(computer==1&&user==2)
            {
                msg = msg + "あなたの負け。";
            }
            else if(computer==2&&user==0)
            {
                msg = msg + "あなたの勝ち。";
            }
            else
            {
                msg = msg + "あなたの勝ち。";
            }
            return msg;
            
        }
    }
}
