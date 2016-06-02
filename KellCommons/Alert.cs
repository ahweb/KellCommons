using System;
using System.Data;
using System.Configuration;
using System.Web.SessionState;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Alert ��ժҪ˵��
//ASP.NET�еĵ�����Ϣ�Ի�����
/// </summary>
namespace KellCommons
{
    public class Alert
    {
        /// <summary>
        /// ShowMsgBox ��ʾ��Ϣ�Ի���
        /// </summary>
        /// <param name="message">��Ҫ��ʾ����Ϣ</param>
        public static void ShowMsgBox(string message)
        {
            HttpContext.Current.Response.Write("<script>alert(\"" + message + "\");</script>");
        }
        public static void thisTransfer(string url)
        {
            HttpContext.Current.Response.Write("<script>window.location='" + url + "';</script>");
        }

        public static void ShowMsgBox(string message, string url)
        {
            HttpContext.Current.Response.Write("<script>alert(\"" + message + "\");location.href='" + url + "';</script>");
        }
        public static void ShowMsgBox(string message, string url, string FrmName)
        {
            HttpContext.Current.Response.Write("<script>alert(\"" + message + "\");window.top." + FrmName + ".location='" + url + "';</script>");
        }

        public static void ShowMsgBoxClose(string message)
        {
            HttpContext.Current.Response.Write("<script>alert(\"" + message + "\");opener.location.reload(true);window.close();</script>");
        }
        public static void ShowMsgBoxFreshNoClose(string message)
        {
            HttpContext.Current.Response.Write("<script>alert(\"" + message + "\");opener.location.reload(true);</script>");
        }
        public static void ShowMsgBoxAndOpen(string message, string dirURL, string openURL, int openWidth, int openHeight)
        {
            HttpContext.Current.Response.Write("<script>alert(\"" + message + "\");window.open('" + openURL + "','popupnav',   'width=" + openWidth + ",height=" + openHeight + ",resizable=1,scrollbars=no');window.location.href='" + dirURL + "';</script>");

        }
        /// <summary>
        /// �رձ����ڣ�����ˢ�¸������е�IFRAME
        /// </summary>
        public static void ShowMsgBoxCloseIframeFresh(string message, string fatherIframe)
        {
            HttpContext.Current.Response.Write("<script>alert(\"" + message + "\");window.top." + fatherIframe + ".location.href=window.top." + fatherIframe + ".location.href;window.top.hidePopWin();</script>");
        }
        public static void SearchWin(string url)
        {
            HttpContext.Current.Response.Write("<script>window.top.frmMain.location='" + url + "';window.top.hidePopWin();</script>");
        }

        public static void ShowMsgBoxCloseIframeFresh(string fatherIframe)
        {
            HttpContext.Current.Response.Write("<script>window.top." + fatherIframe + ".location.href=window.top." + fatherIframe + ".location.href;window.top.hidePopWin();</script>");
        }
        public static void frmTransfer(string url, string FrmName)
        {
            HttpContext.Current.Response.Write("<script>window." + FrmName + ".location='" + url + "';</script>");
        }
        public static void AlertSession(int dirType, string direc)
        {
            if (dirType == 1)//ת������ҳ
            {
                HttpContext.Current.Response.Write("<script>alert('����û��½���ڸ�ҳ��ͣ��ʱ������������µ�½��');window.top.location='" + direc + "Default.aspx';</script>");
            }
            else//�ر�
            {
                HttpContext.Current.Response.Write("<script>alert('����û��½���ڸ�ҳ��ͣ��ʱ������������´���վ��');window.close();</script>");
            }
        }


        /**/
        /// <summary>
        /// �������ڲ����ص�ǰһҳ��
        /// </summary>
        /// <param name="m">��ʾ��Ϣ����</param>
        public static void ShowMsgBoxBack(string message)
        {
            HttpContext.Current.Response.Write("<script>alert(\"" + message + "\");history.back(-1);</script>");
        }
        /// <summary>
        /// ��ʾһ����ʾ
        /// </summary>
        public static void ShowMsgTip(string message, Label infoLab)
        {
            string tipMsg = "";
            tipMsg += "<table width='96%' border='0' align='center' cellpadding='0' cellspacing='0' bgcolor='#F3F3F3' style='border:1px dotted red'>";
            tipMsg += "<tr>";
            tipMsg += "    <td bgcolor='#FDF3D5' height='20px'>&nbsp;&nbsp;��ʾ:" + message + " ";
            tipMsg += "     </td>";
            tipMsg += "  </tr>";
            tipMsg += "</table>";
            infoLab.Text = tipMsg;
        }

        private string alert;
        /**/
        /// <summary>
        /// �������ڲ����ص�ǰһҳ��
        /// </summary>
        /// <param name="m">��ʾ��Ϣ����</param>
        public Alert(string m)
        {
            this.alert = "<script>alert('" + m + "');histroy.back(-1);</script>";
        }

        /// <summary>
        /// Back ����ǰ������
        /// </summary>
        public static void Back()
        {
            HttpContext.Current.Response.Write("<script>history.back();</script>");
        }

        /// <summary>
        /// �رյ�ǰ���ڣ���ˢ�¸�����
        /// </summary>
        public static void winClose()
        {
            HttpContext.Current.Response.Write("<script>javascript:opener.location.reload(true);window.close();</script>");
        }
        /// <summary>
        /// innerHTML ����ǰ������
        /// </summary>
        public static void innerHTML(string HtmlCont, string showMsg)
        {
            HttpContext.Current.Response.Write("<script>document.getElementById('" + HtmlCont + "').innerHTML = \"" + showMsg + "\";</script>");
        }


    }
}