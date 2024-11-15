using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;

        TestTextBox _testTextBox;
        public Form1()
        {
            InitializeComponent();

            string[] strs =
        {
         "あか",
         "あお",
         "きいろ",
         "みどり",
         "くろ",
         "しろ",
         "ちゃいろ",
         "ぴんく",
         "むらさき",
         "きみどり",
        };

            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(this, strs[i], (i % 5) * 100, (i / 5) * 100, 100, 100);

                Controls.Add(testButton);

                _testTextBox = new TestTextBox("テキストボックスです",10,400,500,100);
                Controls.Add(_testTextBox);
            }
            _testLabel = new TestLabel("ラベルデス", 10, 300, 100, 500);
            Controls.Add(_testLabel);
        }
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }
    }
}
