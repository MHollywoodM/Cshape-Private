using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string url = "http://121.42.54.31:8080/sysman/dic/zone/list/v1";
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton_Commit_Click(object sender, EventArgs e)
        {
            this.textEdit_Result.Text = HttpService.HttpServiceLogic.Post2(new Uri(this.textEdit_Uri.Text), this.textEdit_Para.Text);
        }

        private void simpleButton_Reset_Click(object sender, EventArgs e)
        {
            MsgBase _base1=getzoneCode(0);
            StringBuilder sb = new StringBuilder();
            foreach (var item1 in _base1.data)
            {
                sb.Append("{\"name\":\"" + item1.zonename + "\"," + Environment.NewLine);
                sb.Append("  \"code\":\"" + item1.zoneid + "\"," + Environment.NewLine);
                sb.Append("  \"sub\":[" + Environment.NewLine);
                MsgBase _base2 = getzoneCode(item1.zoneid);
                foreach (var item2 in _base2.data)
                {
                    sb.Append("    {\"name\":\"" + item2.zonename + "\"," + Environment.NewLine);
                    sb.Append("     \"code\":\"" + item2.zoneid + "\"," + Environment.NewLine);
                    sb.Append("     \"sub\":[" + Environment.NewLine);
                    MsgBase _base3 = getzoneCode(item2.zoneid);
                    foreach (var item3 in _base3.data)
                    {
                        sb.Append("        {\"name\":\"" + item3.zonename + "\"," + Environment.NewLine);
                        sb.Append("         \"code\":\"" + item3.zoneid + "\"" + Environment.NewLine);
                        sb.Append("         }," + Environment.NewLine);
                    }
                    sb.Append("     ]},"+Environment.NewLine );
                }
                sb.Append("]},");
            }
            this.textEdit_Result.Text = sb.ToString();
        }

        private MsgBase getzoneCode(int code)
        {    
            PostData postdata = new PostData() { higher_zoneid = code };
            MsgBase response = HttpService.HttpServiceLogic.Post<PostData, MsgBase>(new Uri(url),postdata);
            return response;
        }

    }


    class MsgBase
    {
        public int respnum { set; get; }
        public int count { set; get; }

        public List<Zone> data;

        public MsgBase()
        {
            data = new List<Zone>();
        }
    }
    public class Zone
    {
        public int zoneid { set;get;}
        public string zonename { set; get; }
    }

    public class PostData
    {
        public int higher_zoneid { set; get; }
    }
}
