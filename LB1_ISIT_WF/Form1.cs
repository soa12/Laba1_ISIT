using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1_ISIT_WF
{
    public partial class Form1 : Form
    {
        public double score = 0;
        public string result;
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            MethodResult();
        }



        public double AddScore(double _score, double n)
        {
            return _score + n;
        }

        private void MethodResult()
        {
            ///////////////////////////1
            if (radioBtn1_1.Checked)
            {
                score = AddScore(score, 1);
            }
            if (radioBtn1_2.Checked)
            {
                score = AddScore(score, 0.5);
            }
            if (radioBtn1_3.Checked)
            {
                score = AddScore(score, 0.25);
            }
            ///////////////////////////1


            ///////////////////////////2
            if (radioBtn2_1.Checked)
            {
                score = AddScore(score, 0);
            }

            if (radioBtn2_2.Checked)
            {
                score = AddScore(score, 0.2);
            }
            if (radioBtn2_3.Checked)
            {
                score = AddScore(score, 1);
            }
            ///////////////////////////2


            ///////////////////////////3
            if (radioBtn3_1.Checked)
            {
                score = AddScore(score, 0.4);
            }

            if (radioBtn3_2.Checked)
            {
                score = AddScore(score, 1);
            }
            if (radioBtn3_3.Checked)
            {
                score = AddScore(score, 0.2);
            }
            ///////////////////////////3

            
            ///////////////////////////4
            if (radioBtn4_1.Checked)
            {
                score = AddScore(score, 0.5);
            }

            if (radioBtn4_2.Checked)
            {
                score = AddScore(score, 1);
            }
            if (radioBtn4_3.Checked)
            {
                score = AddScore(score, 0.1);
            }
            ///////////////////////////4


            ///////////////////////////5
            if (radioBtn5_1.Checked)
            {
                score = AddScore(score, 0.4);
            }

            if (radioBtn5_2.Checked)
            {
                score = AddScore(score, 0);
            }
            if (radioBtn5_3.Checked)
            {
                score = AddScore(score, 0.2);
            }
            ///////////////////////////5


            ///////////////////////////6
            if (radioBtn6_1.Checked)
            {
                score = AddScore(score, 0.6);
            }
            if (radioBtn6_2.Checked)
            {
                score = AddScore(score, 0.8);
            }
            if (radioBtn6_3.Checked)
            {
                score = AddScore(score, 0);
            }
            ///////////////////////////6

            
            ///////////////////////////7
            if (radioBtn7_1.Checked)
            {
                score = AddScore(score, 1);
            }
            if (radioBtn7_2.Checked)
            {
                score = AddScore(score, 0.5);
            }
            if (radioBtn7_3.Checked)
            {
                score = AddScore(score, 1);
            }
            ///////////////////////////7

            
            ///////////////////////////8
            if (radioBtn8_1.Checked)
            {
                score = AddScore(score, 0.2);
            }
            if (radioBtn8_2.Checked)
            {
                score = AddScore(score, 0.6);
            }
            if (radioBtn8_3.Checked)
            {
                score = AddScore(score, 0.2);
            }
            ///////////////////////////8

            result = MethodShowResult(score);
            MessageBox.Show(result);
        }

        private string MethodShowResult(double score)
        {
            /*Стиральная машина-полуавтомат 0-2
           Стиральная машина-автомат 6-10
           Активаторная стиральная машина 4,5-6
           Стиральная машина типа Малютка 2- 4,5
           Пузырьковая стиральная машина 10-12*/

            if (score < 2)
            {
                return "Вы здоровы как бык";
            }
            else
            {
                if (score < 4.5)
                {
                    return "Как вы еще не умерли";
                }
                else
                {
                    if (score < 6)
                    {
                        return "Вам срочно нужно к врачу";
                    }
                    else
                    {
                        if (score < 10)
                        {
                            return "Вам уже ничего не поможет";
                        }
                        else
                        {
                            return "Покупайте гроб";
                        }
                    }
                }
            }
        }
    }
}
