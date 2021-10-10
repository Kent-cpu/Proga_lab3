using MathNet.Symbolics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ZedGraph;

namespace Prog_lab_3
{
    public partial class Form1 : Form
    {
        List<Point> minPointList = new List<Point>();
        PointPairList list = new PointPairList();
        double bottomBorder, topBorder, accuracy;
        int count;

        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private int getNumberDecimalPlaces()
        {
            int decimalPlaces = 0;

            for(double i = accuracy; i < 1; i *= 10)
            {
                ++decimalPlaces;
            }
            return decimalPlaces;
        }

        private double calculateValuePoint(double value)
        {
            double result = 0;
            var variables = new Dictionary<string, FloatingPoint> { { "x", value } };
            var formula = Infix.ParseOrThrow(formulaField.Text);
            result = Evaluate.Evaluate(variables, formula).RealValue;
            return result;
        }

        double findMin()
        {
            double PHI = (1 + Math.Sqrt(5)) / 2;

            double x1, x2, a = bottomBorder, b = topBorder;
            while (true)
            {
                x1 = b - (b - a) / PHI;
                x2 = a + (b - a) / PHI;
                if (calculateValuePoint(x1) >= calculateValuePoint(x2))
                {
                    a = x1;
                    minPointList.Add(new Point(x1, calculateValuePoint(x1)));
                }
                else
                {
                    b = x2;
                    minPointList.Add(new Point(x2, calculateValuePoint(x2)));
                }

                if (Math.Abs(b - a) < accuracy)
                {
                    break;
                }
            }
            minPointList.Add(new Point((a + b) / 2, calculateValuePoint((a + b) / 2)));
            return (a + b) / 2;
        }

        private void drawGraph(double xPoint, double yPoint)
        {
            GraphPane mypane = zedGraphControl1.GraphPane;
            mypane.CurveList.Clear();

            mypane.XAxis.MajorGrid.IsVisible = true;
            mypane.XAxis.MinorGrid.IsVisible = true;
            mypane.YAxis.MajorGrid.IsVisible = true;

            LineItem myCurve = mypane.AddCurve("f(x)", list, Color.Blue, SymbolType.None);
            LineItem minPointCurve = mypane.AddCurve("Min point", new double[] { xPoint }, new double[] { yPoint }, Color.DarkRed, SymbolType.Circle);
            minPointCurve.Symbol.Fill.Type = FillType.Solid;

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Environment.Exit(0);
            }).Start();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    Invoke((Action)(() =>
                    {
                        backMinPointBtn.Enabled = false;
                        nextMinPointBtn.Enabled = false;
                        clearFieldBtn.Enabled = false;
                        GraphPane mypane = zedGraphControl1.GraphPane;
                        mypane.CurveList.Clear();
                        zedGraphControl1.AxisChange();
                        zedGraphControl1.Invalidate();
                        answerField.Text = "";
                    }));


                    minPointList.Clear();
                    if (double.TryParse(bottomBorderField.Text, out bottomBorder) && double.TryParse(topBorderField.Text, out topBorder)
                        && double.TryParse(accuracyField.Text, out accuracy) && formulaField.Text.Length > 0)
                    {
                        if (bottomBorder >= topBorder)
                        {
                            MessageBox.Show("Значение a должно быть меньше значения b");
                            return;
                        }
                        else if (accuracy <= 0)
                        {
                            MessageBox.Show("Точность должна быть больше 0");
                            return;
                        }else if (topBorder - bottomBorder < accuracy)
                        {
                            MessageBox.Show("Границы функции меньше точности, измените входные данные");
                            return;
                        }

                        double xMinPoint = findMin();
                        double yMinPoint = calculateValuePoint(xMinPoint);

                        calculationGraphPoints();
                        drawGraph(xMinPoint, yMinPoint);
                        count = minPointList.Count - 1; 

                        Invoke((Action)(() =>
                        {
                            answerField.Text = "x: " + Math.Round(xMinPoint, getNumberDecimalPlaces()).ToString() + " y: " + Math.Round(yMinPoint, getNumberDecimalPlaces()).ToString();
                            backMinPointBtn.Enabled = true;
                            clearFieldBtn.Enabled = true;
                        }));

                    }
                    else
                    {
                        MessageBox.Show("Неверные входные данные");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неверная функция или слишком большие границы");
                }

            }).Start();
        }

        private void clearFieldBtn_Click(object sender, EventArgs e)
        {
            foreach (Control element in Controls)
            {
                if (element is TextBox)
                {
                    ((TextBox)element).Text = null;
                }
            }
        }

        private void nextMinPointBtn_Click(object sender, EventArgs e)
        {
            if (count < minPointList.Count - 1)
            {
                count++;
                drawGraph(minPointList[count].x, minPointList[count].y);
                //label1.Text = Math.Round(minPointList[count].x, 3).ToString();
                //label2.Text = minPointList.Count.ToString();
                //label3.Text = count.ToString();
            }

            if (count >= minPointList.Count - 1)
            {
                nextMinPointBtn.Enabled = false;
            }

            if (count > 0)
            {
                backMinPointBtn.Enabled = true;
            }
        }

        private void backMinPointBtn_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                --count;
                drawGraph(minPointList[count].x, minPointList[count].y);
                //label1.Text = Math.Round(minPointList[count].x, 3).ToString();
                //label2.Text = minPointList.Count.ToString();
                //label3.Text = count.ToString();
            }


            if (count == 0)
            {
                backMinPointBtn.Enabled = false;
            }


            if (count < minPointList.Count - 1)
            {
                nextMinPointBtn.Enabled = true;
            }
        }

        private void calculationGraphPoints()
        {
            list.Clear();
            for (double x = bottomBorder; x < topBorder; x += 0.01)
            {
                try
                {
                    list.Add(x, calculateValuePoint(x));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Слишком большая точность или интервал");
                }
            }
        }

    }
}


class Point
{
    public double x, y;


    public Point()
    {

    }

    public Point(double xKoordinate, double yKoordinate)
    {
        x = xKoordinate;
        y = yKoordinate;
    }
}