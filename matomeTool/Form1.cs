using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.IO;

namespace matomeTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel_text.Visible = false;
        }

        public class Matome
        {
            public string rawtext = "";
            public List<ParsedText> ptext = new List<ParsedText>();
            public int resNum = 0;
            public int line_size = 19;
            public List<short> lines = new List<short>();
            public List<RichTextBox> tbs = new List<RichTextBox>();
            public List<CheckBox> cbs = new List<CheckBox>();
            public List<bool> rightPanelViewChecked = new List<bool>();
            public bool leftDispFlag = true; //true→rawtext, false→ptext
            public string anonymous = "";
            public string utfResult = "";
            public Dictionary<string, string> registeredIDcolor = new Dictionary<string, string>();
            public Dictionary<string, string> registeredIDother = new Dictionary<string, string>();
            public Dictionary<int, string> registeredCommentColor = new Dictionary<int, string>();
            public Dictionary<int, string> registeredCommentSize = new Dictionary<int, string>();
            public Dictionary<int, string> registeredCommentOther = new Dictionary<int, string>();
        }

        [Serializable()]
        public class SerializableMatome
        {
            public string rawtext = "";
            public List<ParsedText> ptext = new List<ParsedText>();
            public int resNum = 0;
            public int line_size = 19;
            public List<short> lines = new List<short>();
            public List<bool> rightPanelViewChecked = new List<bool>();
            public bool leftDispFlag = true; //true→rawtext, false→ptext
            public string anonymous = "";
            public string utfResult = "";
            public Dictionary<string, string> registeredIDcolor = new Dictionary<string, string>();
            public Dictionary<string, string> registeredIDother = new Dictionary<string, string>();
            public Dictionary<int, string> registeredCommentColor = new Dictionary<int, string>();
            public Dictionary<int, string> registeredCommentSize = new Dictionary<int, string>();
            public Dictionary<int, string> registeredCommentOther = new Dictionary<int, string>();
        }

        [Serializable()]
        public class ParsedText
        {
            public string name = "";
            public string mailAddr = "";
            public string postTime = "";
            public string id = "";
            public string comment = "";
            public List<int> response = new List<int>();

            public ParsedText() { }

            public string toString()
            {
                string br2newLine = comment.Replace(" <br> ", Environment.NewLine);
                string str = "名前:" + name + "[" + mailAddr + "] 投稿日:" + postTime + " ID:" + id + Environment.NewLine + br2newLine;
                return str;
            }

            public string toHTMLstring()
            {
                string newLine = Environment.NewLine;
                string tabSpace = "    ";
                string str = String.Concat("<div class=\"kakikomiHeader\">", newLine, tabSpace
                    , "名前:<span class=\"name\">"
                   , name, "</span>[", mailAddr, "] 投稿日:", postTime
                   , " ID:<span class=\"kakikomiID\">", id, "</span>", newLine, "</div>", newLine
                   , "<div class=\"kakikomiComment\">", newLine, tabSpace, comment, newLine, "</div>"
                   , newLine, newLine);
                return str;
            }

            public string getName(){ return name; }
            public string getMailAddr() { return mailAddr; }
            public string getPostTime() { return postTime; }
            public string getId() { return id; }
            public string getComment() { return comment; }
        }
        Matome mtm = new Matome();

        Dictionary<string, string> IDcolorList = new Dictionary<string, string>()
        {
            {"red", "redID" },
            {"blue", "blueID" },
            {"green", "greenID" },
            {"pink", "pinkID" },
            {"yellow", "yellowID" },
            {"black", "blackID" }
        };
        Dictionary<string, string> otherList = new Dictionary<string, string>()
        {
            {"none", "none" },
            {"bold", "bold" },
            {"italic", "italic" },
            {"bold&italic", "bold_italic" }
        };
        Dictionary<string, string> commmentColorList = new Dictionary<string, string>()
        {
            {"red", "redComment" },
            {"blue", "blueComment" },
            {"green", "greenComment" },
            {"pink", "pinkComment" },
            {"yellow", "yellowComment" },
            {"black", "blackComment" }
        };
        Dictionary<string, string> commmentSizeList = new Dictionary<string, string>()
        {
            {"medium", "mediumComment" },
            {"large", "largeComment" },
            {"x-large", "x-largeComment" },
            {"xx-large", "xx-largeComment" },
            {"small", "smallComment" },
            {"x-small", "x-smallComment" }
        };

        public string getHTMLtext()
        {
            string htmltext = "";
            string append = "";
            string idClassCode = "";
            string commentClassCode = "";
            for(int j = 0; j < mtm.resNum; j++)
            {
                idClassCode = "";
                commentClassCode = "";
                mtm.anonymous = "";
                if (mtm.rightPanelViewChecked[j])
                {
                    if(mtm.registeredIDcolor.ContainsKey(mtm.ptext[j].id))
                    {
                        idClassCode = String.Concat(idClassCode, " ", IDcolorList[mtm.registeredIDcolor[mtm.ptext[j].id]]);
                    }
                    if (mtm.registeredIDother.ContainsKey(mtm.ptext[j].id))
                    {
                        idClassCode = String.Concat(idClassCode, " ", otherList[mtm.registeredIDother[mtm.ptext[j].id]]);
                    }
                    if (mtm.registeredCommentColor.ContainsKey(j))
                    {
                        commentClassCode = String.Concat(commentClassCode, " ", commmentColorList[mtm.registeredCommentColor[j]]);
                    }
                    if (mtm.registeredCommentSize.ContainsKey(j))
                    {
                        commentClassCode = String.Concat(commentClassCode, " ", commmentSizeList[mtm.registeredCommentSize[j]]);
                    }
                    if (mtm.registeredCommentOther.ContainsKey(j))
                    {
                        commentClassCode = String.Concat(commentClassCode, " ", otherList[mtm.registeredCommentOther[j]]);
                    }
                    if(mtm.ptext[j].name == tbox_anonymous.Text)
                    {
                        mtm.anonymous = " anonymous";
                    }
                    string newLine = Environment.NewLine;
                    string tabSpace = "    ";
                    append = String.Concat("<div class=\"kakikomiHeader\">", 
                        newLine, tabSpace, 
                        j+1 ," 名前:<span class=\"name", mtm.anonymous, "\">", mtm.ptext[j].name, "</span>[", mtm.ptext[j].mailAddr, "] 投稿日:" + mtm.ptext[j].postTime, 
                        " ID:<span class=\"kakikomiID ", idClassCode, "\">", mtm.ptext[j].id, "</span>", 
                        newLine, 
                        "</div>", 
                        newLine, 
                        "<div class=\"kakikomiComment", commentClassCode, "\">", 
                        newLine, tabSpace,
                        mtm.ptext[j].comment,
                        newLine,
                        "</div>",
                        newLine, "<br><br><br>", newLine, newLine);
                    htmltext = String.Concat(htmltext, append);
                }
            }
            mtm.utfResult = SjisToUtf8(htmltext);            
            return mtm.utfResult;
        }

        // Shift-JIS -> UTF-8 変換（BOMなし）
        static string SjisToUtf8(string sjis)
        {
            // Shift-JIS -> UTF-8 変換（byte形）
            byte[] bytesData = System.Text.Encoding.UTF8.GetBytes(sjis);

            // string型に変換したい場合はこんな感じに
            Encoding utf8Enc = Encoding.GetEncoding("UTF-8");
            string utf = utf8Enc.GetString(bytesData);

            return utf;
        }

        private void btn_interpret_Click(object sender, EventArgs e)
        {
            mtm.rawtext = tbox_rawText.Text;
            clearAll();
            tbox_rawText.Text = mtm.rawtext;
            string s_b = "<b>";
            string s_bb = "</b>";
            string s_kakko = "<>";
            string s_id = "ID:";
            string s_lf = Environment.NewLine;
            int pos, p_bb, p_kakko, p_kakko2, p_kakko3, p_kakko4, p_id;
            pos = p_bb = p_kakko = p_kakko2 = p_kakko3 = p_kakko4 = p_id = 0;
            int tmppos = 0;
            int i = 0;

            p_bb = mtm.rawtext.IndexOf(s_bb, 0);
            p_kakko = mtm.rawtext.IndexOf(s_kakko, 0);
            if(p_bb > -1)
            {
                while (pos >= 0)
                {
                    //</b>を探す
                    p_bb = mtm.rawtext.IndexOf(s_bb, pos);
                    //</b>の後の<>を探す
                    p_kakko = mtm.rawtext.IndexOf(s_kakko, p_bb + s_bb.Length);
                    p_kakko2 = mtm.rawtext.IndexOf(s_kakko, p_kakko + s_kakko.Length);
                    //ID:　を探す
                    p_id = mtm.rawtext.IndexOf(s_id, p_bb + s_kakko.Length);
                    //ID: の後の<>を探す
                    p_kakko3 = mtm.rawtext.IndexOf(s_kakko, p_id);
                    //書き込み内容の後の<>を探す
                    p_kakko4 = mtm.rawtext.IndexOf(s_kakko, p_kakko3 + s_kakko.Length);

                    ParsedText kakikomi = new ParsedText();
                    if (i == 0)
                    {
                        kakikomi.name = mtm.rawtext.Substring(pos, p_bb - pos - 1);
                    }
                    else
                    {
                        kakikomi.name = mtm.rawtext.Substring(pos + 1, p_bb - pos - 2);
                    }

                    pos = mtm.rawtext.IndexOf("\n", p_kakko4);
                    kakikomi.mailAddr = mtm.rawtext.Substring(p_kakko + s_kakko.Length, p_kakko2 - p_kakko - s_kakko.Length);
                    kakikomi.postTime = mtm.rawtext.Substring(p_id - 27, 26);
                    kakikomi.id = mtm.rawtext.Substring(p_id + 3, p_kakko3 - p_id - 3);
                    kakikomi.comment = mtm.rawtext.Substring(p_kakko3 + s_kakko.Length + 1,
                        p_kakko4 - 2 - (p_kakko3 + s_kakko.Length));
                    mtm.ptext.Add(kakikomi);

                    if (pos == tmppos) break;
                    tmppos = pos;
                    i++;
                }
            }else if(p_kakko > -1)
            {
                while (pos >= 0)
                {
                    //<>を探す
                    p_kakko = mtm.rawtext.IndexOf(s_kakko, pos);
                    //<>の後の<>を探す
                    p_kakko2 = mtm.rawtext.IndexOf(s_kakko, p_kakko + s_kakko.Length);
                    //ID:　を探す
                    p_id = mtm.rawtext.IndexOf(s_id, p_kakko2 + s_kakko.Length);
                    //ID: の後の<>を探す
                    p_kakko3 = mtm.rawtext.IndexOf(s_kakko, p_id);
                    //書き込み内容の後の<>を探す
                    p_kakko4 = mtm.rawtext.IndexOf(s_kakko, p_kakko3 + s_kakko.Length);

                    ParsedText kakikomi = new ParsedText();
                    if (i == 0)
                    {
                        kakikomi.name = mtm.rawtext.Substring(pos, p_kakko - pos);
                    }
                    else
                    {
                        kakikomi.name = mtm.rawtext.Substring(pos + 1, p_kakko - pos - 1);
                    }
                    pos = mtm.rawtext.IndexOf("\n", p_kakko4);
                    kakikomi.mailAddr = mtm.rawtext.Substring(p_kakko + s_kakko.Length, p_kakko2 - p_kakko - s_kakko.Length);
                    kakikomi.postTime = mtm.rawtext.Substring(p_id - 26, 25);
                    kakikomi.id = mtm.rawtext.Substring(p_id + 3, p_kakko3 - p_id - 3);
                    kakikomi.comment = mtm.rawtext.Substring(p_kakko3 + s_kakko.Length + 1,
                        p_kakko4 - 2 - (p_kakko3 + s_kakko.Length));
                    mtm.ptext.Add(kakikomi);
                    if (pos == tmppos) break;
                    tmppos = pos;
                    i++;
                }
            }
            else
            {
                MessageBox.Show("</b>または<>が含まれる文章を入力してください。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //書き込み内容の行数を調べる
            mtm.resNum = mtm.ptext.Count();
            int posi = 0;
            byte exist = 0;
            short brNum = -1;
            for (int j = 0; j < mtm.resNum; j++)
            {
                exist = 0;
                posi = 1;
                brNum = -1;
                while (posi > 0)
                {
                    brNum++;
                    posi = mtm.ptext[j].comment.IndexOf("<br>", posi + exist * 4);
                    exist = 1;
                }
                brNum++;
                mtm.lines.Add(brNum);
            }

            //レス返信&gt;&gt;を探して処理する
            processGt();

            //PanelにTextboxを追加して内容を書き込む,panel_checkboxにcheckboxを生成
            mkCboxAndTbox();

            //rightPanelViewの配列の長さを設定
            for(int j = 0; j < mtm.resNum; j++)
            {
                mtm.rightPanelViewChecked.Add(false);
            }
            leftDispChange();
        }

        public void processGt()
        {
            string s_gt = "&gt;&gt;";
            string s_aBegin = "<a href";
            string s_aEnd = "</a>";
            int p_gt = 0;
            int p_aBegin = 0;
            int p_aEnd = 0;
            string comment;
            string resNumstr;   //レス番（18-19とかだったら19になる）
            String resNumOriginal;  //レス番（18-19とかだったら18-19になる）
            int replyNum = 0;   //resNumstrをint型に変換した変数
            for (int j = 0; j < mtm.resNum; j++)
            {
                comment = mtm.ptext[j].comment;
                while ((p_aBegin = comment.IndexOf(s_aBegin, 0)) > -1)
                {
                    p_gt = comment.IndexOf(s_gt, p_aBegin);
                    p_aEnd = comment.IndexOf(s_aEnd, p_gt);
                    resNumstr = comment.Substring(p_gt + s_gt.Length, p_aEnd - p_gt - s_gt.Length);
                    resNumOriginal = resNumstr;
                    int p_bar = resNumstr.IndexOf("-", 0);
                    while (p_bar != -1)
                    {
                        resNumstr = resNumstr.Substring(p_bar + 1, resNumstr.Length - p_bar - 1);
                        p_bar = resNumstr.IndexOf("-", 0);
                    }
                    int p_comma = resNumstr.IndexOf(",", 0);
                    while (p_comma != -1)
                    {
                        resNumstr = resNumstr.Substring(p_comma + 1, resNumstr.Length - p_comma - 1);
                        p_comma = resNumstr.IndexOf("-", 0);
                    }
                    replyNum = int.Parse(resNumstr);
                    comment = comment.Insert(p_aEnd + s_aEnd.Length, ">>" + resNumOriginal);
                    comment = comment.Remove(p_aBegin, p_aEnd + s_aEnd.Length - p_aBegin);
                    mtm.ptext[j].response.Add(replyNum);
                }
                mtm.ptext[j].comment = comment;
                p_gt = 0;
                p_aBegin = 0;
                p_aEnd = 0;
            }
        }

        public void mkCboxAndTbox()
        {
            int size_checkbox = 30;
            int textBoxWidth = 525;
            mtm.tbs.Clear();
            mtm.cbs.Clear();
            mtm.tbs.Add(mkTextbox(3, 3, textBoxWidth, (1 + mtm.lines[0]) * mtm.line_size, 0));
            mtm.cbs.Add(mkCheckbox(3 + 550, 3, size_checkbox, size_checkbox, 0));
            mtm.tbs[0].Text = mtm.ptext[0].toString();
            int sum_height = 3 + (1 + mtm.lines[0]) * mtm.line_size;
            for (int j = 1; j < mtm.resNum; j++)
            {
                mtm.tbs.Add(mkTextbox(3, 3 + 3 + sum_height, textBoxWidth, (1 + mtm.lines[j]) * mtm.line_size, j));
                mtm.cbs.Add(mkCheckbox(3 + 550, 3 + 3 + sum_height, size_checkbox, size_checkbox, j));
                mtm.tbs[j].Text = mtm.ptext[j].toString();
                sum_height += 3 + (1 + mtm.lines[j]) * mtm.line_size;
            }
        }

        private RichTextBox mkTextbox(int left, int top, int width, int height, int index)
        {
            RichTextBox tb = new RichTextBox();
            tb.Left = left;
            tb.Top = top;
            tb.Width = width;
            tb.Height = height;
            tb.Name = "tbs" + index.ToString();
            panel_text.Controls.Add(tb);

            return tb;
        }
        private CheckBox mkCheckbox(int left, int top, int width, int height, int index)
        {
            CheckBox cb = new CheckBox();
            cb.Left = left;
            cb.Top = top;
            cb.Width = width;
            cb.Height = height;
            cb.Name = "cbs" + index.ToString();
            panel_text.Controls.Add(cb);

            return cb;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            leftDispChange();
        }

        public void leftDispChange()
        {
            if (mtm.leftDispFlag)
            {
                panel_text.Visible = true;
            }
            else
            {
                tbox_rawText.Text = mtm.rawtext;
                panel_text.Visible = false;
            }
            mtm.leftDispFlag = !mtm.leftDispFlag;
        }

        private void btn_allSelect_Click(object sender, EventArgs e)
        {
            //すべてにチェックが入っていたらすべてfalseにする。それ以外の場合は全選択する
            int checkedNum = 0;
            for(int j = 0; j < mtm.resNum; j++)
            {
                if (mtm.cbs[j].Checked) { checkedNum++; }
            }
            if(checkedNum < mtm.resNum)
            {
                for (int j = 0; j < mtm.resNum; j++)
                {
                    mtm.cbs[j].Checked = true;
                }
            }
            else
            {
                for (int j = 0; j < mtm.resNum; j++)
                {
                    mtm.cbs[j].Checked = false;
                }
            }
        }

        //全反映ボタン
        private void btn_reflect_Click(object sender, EventArgs e)
        {
            for(int j = 0; j < mtm.resNum; j++)
            {
                if (mtm.cbs[j].Checked)
                {
                    mtm.rightPanelViewChecked[j] = true;
                }
                else
                {
                    mtm.rightPanelViewChecked[j] = false;
                }
            }
            tbox_view.Text = getHTMLtext();
        }

        //追加ボタン
        private void btn_add_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < mtm.resNum; j++)
            {
                mtm.rightPanelViewChecked[j] = mtm.rightPanelViewChecked[j] || mtm.cbs[j].Checked;
            }

            tbox_view.Text = getHTMLtext();
        }

        //削除ボタン
        private void btn_delete_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < mtm.resNum; j++)
            {
                mtm.rightPanelViewChecked[j] = mtm.rightPanelViewChecked[j] && !mtm.cbs[j].Checked;
            }
            tbox_view.Text = getHTMLtext();
        }

        //id登録ボタン
        private void btn_idControll_Click(object sender, EventArgs e)
        {
            try
            {
                mtm.registeredIDcolor[tbox_idControll.Text] = cbox_idColor.SelectedItem.ToString();
            }catch(NullReferenceException)
            {
                mtm.registeredIDcolor[tbox_idControll.Text] = "blackID";
            }
            try
            {
                mtm.registeredIDother[tbox_idControll.Text] = cbox_idOther.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                mtm.registeredIDother[tbox_idControll.Text] = "none";
            }
            tbox_view.Text = getHTMLtext();
        }

        //テキスト装飾実行ボタン
        private void btn_commentControll_Click(object sender, EventArgs e)
        {
            int k;
            if (Int32.TryParse(tbox_commentControll.Text, out k))
            {
                try
                {
                    mtm.registeredCommentColor[k-1] = cbox_commentColor.SelectedItem.ToString();

                }
                catch (NullReferenceException)
                {
                    //空白とかだったら黒色
                    mtm.registeredCommentColor[k-1] = "black";
                }
                try
                {
                    mtm.registeredCommentSize[k-1] = cbox_commentSize.SelectedItem.ToString();
                }
                catch (NullReferenceException)
                {
                    //空白とかだったら中サイズ
                    mtm.registeredCommentSize[k-1] = "medium";
                }
                try
                {
                    mtm.registeredCommentOther[k-1] = cbox_commentOther.SelectedItem.ToString();
                }
                catch (NullReferenceException)
                {
                    //太字、斜体はなし
                    mtm.registeredCommentOther[k-1] = "none";
                }
            }
            else { createMessageBox();}
            tbox_view.Text = getHTMLtext();

            void createMessageBox()
            {
                MessageBox.Show("レス番は半角数字のみを入力してください。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_anonymous_Click(object sender, EventArgs e)
        {
            tbox_view.Text = getHTMLtext();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        /*************************************************************************
         * 全部消して左側の範囲を起動直後と同じにする
         * **********************************************************************/
        public void clearAll()
        {
            for (int i = 0; i < mtm.resNum; i++)
            {
                Control[] ctrl = this.Controls.Find("tbs" + i.ToString(), true);
                ctrl[0].Dispose();
                ctrl = this.Controls.Find("cbs" + i.ToString(), true);
                ctrl[0].Dispose();
            }
            mtm.tbs.Clear();
            mtm.cbs.Clear();
            mtm.resNum = 0;
            mtm.leftDispFlag = true;
            mtm.ptext = new List<ParsedText>();
            tbox_rawText.Text = "";
            tbox_view.Text = "";
            panel_text.Visible = false;
        }

        private void btn_saveHTML_Click(object sender, EventArgs e)
        {
            //SaveFileDialogクラスのインスタンスを作成
            SaveFileDialog sfd = new SaveFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            sfd.FileName = "";
            //はじめに表示されるフォルダを指定する
            sfd.InitialDirectory = @"./";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            sfd.Filter = "HTMLファイル(*.html;*.htm)|*.html;*.htm|テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            sfd.FilterIndex = 2;
            //タイトルを設定する
            sfd.Title = "保存先のファイルを選択してください";

            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、
                //選択された名前で新しいファイルを作成し、
                //読み書きアクセス許可でそのファイルを開く。
                //既存のファイルが選択されたときはデータが消える恐れあり。
                System.IO.Stream stream;
                stream = sfd.OpenFile();
                if (stream != null)
                {
                    //ファイルに書き込む
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(stream);
                    sw.Write(mtm.utfResult);
                    //閉じる
                    sw.Close();
                    stream.Close();
                }
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void savemtmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialogクラスのインスタンスを作成
            SaveFileDialog sfd = new SaveFileDialog();
            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            sfd.FileName = "";
            //はじめに表示されるフォルダを指定する
            sfd.InitialDirectory = @"./";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            sfd.Filter = "matomeファイル(*.mtm)|*.mtm|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            sfd.FilterIndex = 1;
            //タイトルを設定する
            sfd.Title = "保存先のファイルを選択してください";

            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、
                //選択された名前で新しいファイルを作成し、
                //読み書きアクセス許可でそのファイルを開く。
                //既存のファイルが選択されたときはデータが消える恐れあり。
                System.IO.Stream stream;
                stream = sfd.OpenFile();
                if (stream != null)
                {
                    //ファイルに書き込む
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(stream);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(stream, mkSerializableClass());
                    //閉じる
                    sw.Close();
                    stream.Close();
                }
            }
        }

        private void savehtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialogクラスのインスタンスを作成
            SaveFileDialog sfd = new SaveFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            sfd.FileName = "";
            //はじめに表示されるフォルダを指定する
            sfd.InitialDirectory = @"./";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            sfd.Filter = "HTMLファイル(*.html;*.htm)|*.html;*.htm|テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            sfd.FilterIndex = 2;
            //タイトルを設定する
            sfd.Title = "保存先のファイルを選択してください";

            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、
                //選択された名前で新しいファイルを作成し、
                //読み書きアクセス許可でそのファイルを開く。
                //既存のファイルが選択されたときはデータが消える恐れあり。
                System.IO.Stream stream;
                stream = sfd.OpenFile();
                if (stream != null)
                {
                    //ファイルに書き込む
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(stream);
                    sw.Write(mtm.utfResult);
                    //閉じる
                    sw.Close();
                    stream.Close();
                }
            }
        }

        public SerializableMatome mkSerializableClass()
        {
            SerializableMatome s_mtm = new SerializableMatome();
            s_mtm.rawtext                = mtm.rawtext               ;
            s_mtm.ptext                  = mtm.ptext                 ;
            s_mtm.resNum                 = mtm.resNum                ;
            s_mtm.line_size              = mtm.line_size             ;
            s_mtm.lines                  = mtm.lines                 ;
            s_mtm.rightPanelViewChecked  = mtm.rightPanelViewChecked ;
            s_mtm.leftDispFlag           = mtm.leftDispFlag          ;
            s_mtm.anonymous              = mtm.anonymous             ;
            s_mtm.utfResult              = mtm.utfResult             ;
            s_mtm.registeredIDcolor      = mtm.registeredIDcolor     ;
            s_mtm.registeredIDother      = mtm.registeredIDother     ;
            s_mtm.registeredCommentColor = mtm.registeredCommentColor;
            s_mtm.registeredCommentSize  = mtm.registeredCommentSize ;
            s_mtm.registeredCommentOther = mtm.registeredCommentOther;
            return s_mtm;
        }

        private void openmatomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = @".\";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter = "MATOMEファイル(*.mtm)|*.mtm|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイルを読み取り専用で開く
                System.IO.Stream stream;
                stream = ofd.OpenFile();
                if (stream != null)
                {
                    clearAll();
                    //内容を読み込み、表示する
                    System.IO.StreamReader sr = new System.IO.StreamReader(stream);
                    BinaryFormatter f = new BinaryFormatter();
                    SerializableMatome s_mtm = (SerializableMatome)f.Deserialize(stream);
                    mkMatomeFromS_mtm(s_mtm);
                    //閉じる
                    sr.Close();
                    stream.Close();
                    update();
                }
            }
        }

        public void mkMatomeFromS_mtm(SerializableMatome s_mtm)
        {
            mtm.rawtext                = s_mtm.rawtext               ;
            mtm.ptext                  = s_mtm.ptext                 ;
            mtm.resNum                 = s_mtm.resNum                ;
            mtm.line_size              = s_mtm.line_size             ;
            mtm.lines                  = s_mtm.lines                 ;
            mtm.rightPanelViewChecked  = s_mtm.rightPanelViewChecked ;
            mtm.leftDispFlag           = s_mtm.leftDispFlag          ;
            mtm.anonymous              = s_mtm.anonymous             ;
            mtm.utfResult              = s_mtm.utfResult             ;
            mtm.registeredIDcolor      = s_mtm.registeredIDcolor     ;
            mtm.registeredIDother      = s_mtm.registeredIDother     ;
            mtm.registeredCommentColor = s_mtm.registeredCommentColor;
            mtm.registeredCommentSize  = s_mtm.registeredCommentSize ;
            mtm.registeredCommentOther = s_mtm.registeredCommentOther;
            mkCboxAndTbox();
            return;
        }

        public void update()
        {
            tbox_rawText.Text = mtm.rawtext;
            mkCboxAndTbox();
            tbox_view.Text = getHTMLtext();
        }

        /*****************************************************************************
         * オブジェクトをファイルに保存するためのテストコード
         * ***************************************************************************/
        [Serializable()]
        public class TestClass
        {
            private string _message;
            private int _number;

            public string Message
            {
                get { return _message; }
                set { _message = value; }
            }
            public int Number
            {
                get { return _number; }
                set { _number = value; }
            }

            public TestClass(string str, int num)
            {
                _message = str;
                _number = num;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //保存先のファイル名
            string fileName = ".\\test.obj";

            //TestClassオブジェクトを作成
            TestClass obj1 = new TestClass("テストです。", 123);

            //オブジェクトの内容をファイルに保存する
            SaveToBinaryFile(obj1, fileName);
        }

        public static void SaveToBinaryFile(object obj, string path)
        {
            FileStream fs = new FileStream(path,
                FileMode.Create,
                FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            //シリアル化して書き込む
            bf.Serialize(fs, obj);
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = ".\\test.obj";
            //オブジェクトの内容をファイルから読み込み復元する
            TestClass obj2 = (TestClass)LoadFromBinaryFile(fileName);

            //読み込んだオブジェクトの内容を表示
            Console.WriteLine(obj2.Message);
            Console.WriteLine(obj2.Number);

            Console.ReadLine();
        }

        public static object LoadFromBinaryFile(string path)
        {
            FileStream fs = new FileStream(path,
                FileMode.Open,
                FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();
            //読み込んで逆シリアル化する
            object obj = f.Deserialize(fs);
            fs.Close();

            return obj;
        }

        private void opendatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAll();
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            ofd.InitialDirectory = @".\";
            ofd.Filter = "datファイル(*.dat)|*.dat|すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.Title = "開くファイルを選択してください";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.Stream stream;
                stream = ofd.OpenFile();
                if (stream != null)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(stream, System.Text.Encoding.GetEncoding("shift_jis"));
                    tbox_rawText.Text = SjisToUtf8(sr.ReadToEnd().TrimEnd());
                    //閉じる
                    sr.Close();
                    stream.Close();
                }
            }
        }
    }
}
