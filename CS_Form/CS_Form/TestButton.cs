using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace CS_Form
{
   　public class TestButton : Button

    {
        Form1 _form1;
        TestTextBox _testTextBox;

        /// <summary>
        /// コンストラクタ
        /// クラスを生成したときに呼び出される
        /// </summary>
        public TestButton(Form1 form1, string text, int x, int y, int width, int height)
        {

            _form1 = form1;
            // ClickイベントにOnClick関数を登録
            // ボタンをクリックした時に登録した関数を実行します。
            Text = text;
            Location = new Point(x, y);
            Size = new Size(width, height);
            Click += (sender, e) => _form1.TestButton_Click(this);  // クリック時にTestButton_Clickメソッドを呼び出す
        }


        /// <summary>
        /// ボタンをクリックした際の処理を記述する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="s"></param>
        public void TestButton_Click(TestButton clickedButton)
        {
            // 現在のテキストボックスの内容を保存
            string textBoxText = _testTextBox.Text;

            // ボタンのテキストをテキストボックスに設定
            _testTextBox.Text = clickedButton.Text;

            // テキストボックスの元の内容をボタンに設定
            clickedButton.Text = textBoxText;
        }
    }
}
