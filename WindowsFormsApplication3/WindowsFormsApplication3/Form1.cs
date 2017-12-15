﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public int sum = 0;
        int bet = 0;
        int screen = 0;
        int numPlayers = 1;
        Boolean clickStay = false;
        Boolean clickBet = false;
        List<object[]> players = new List<object[]>();
        public Form1()
        {
           InitializeComponent();
            state();
            LBLtitle.Visible = true;
            BUTstay.Visible = false;
            LBLstupid.Visible = false;
            LBLplayer.Visible = false;


        }
        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void BUT47_Click(object sender, EventArgs e)
        {
            int roll = die47();
            TB47.Text = roll.ToString();
            sum += roll;
            TBsum.Text = sum.ToString();
        }

        private void BUTbet_Click(object sender, EventArgs e)
        {
            updatePlayer(players[0], 2, (int)(NUDbet.Value));
            LBLtitle.Visible = false;
            screen = 2;
            state();
        }

        private void BUTstart_Click(object sender, EventArgs e)
        {
            
            screen = 1;
            state();
        }

        private void BUTbet_Click_1(object sender, EventArgs e)
        {
            bet = (int)NUDbet.Value;
            screen = 2;
            state();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BUTnumplay_Click(object sender, EventArgs e)
        {
            if (TBsingle.Text!="")
            {
                players.Add(newPlayer(TBsingle.Text));
                screen = 2;
                state();
            } 
            else if (TBmulti.Text!="")
            {
                for (int i = 0; i < TBmulti.Lines.Length; i++)
                {
                   players.Add(newPlayer(TBmulti.Lines[i]));
                }
                numPlayers = TBmulti.Lines.Length;
                screen = 2;
                state();
            }
            else
            {
                LBLstupid.Visible = true;
            }
      
        }

        private void BUT18_Click(object sender, EventArgs e)
        {
            int roll = die18();
            TB18.Text = roll.ToString();
            sum += roll;
            TBsum.Text = sum.ToString();
        }

        private void BUTstay_Click(object sender, EventArgs e)
        {
            clickStay = true;
        }
    }
}
