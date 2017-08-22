using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Aras;
using Aras.IOM;

namespace ArasCheckItem
{
    public partial class Form1 : Form
    {
        private HttpServerConnection mc_conn = null;
        private Innovator mc_innovator = null;

        public Form1()
        {
            InitializeComponent();

            SettingConnectionButton(false);
            pro_CheckItem.Minimum = 0;
            pro_CheckItem.Maximum = 100;
        }

        private void GetConnection(string l_serverurl,string l_db,string l_username,string l_password)
        {
            mc_conn = IomFactory.CreateHttpServerConnection(l_serverurl.Trim(), l_db.Trim(), l_username.Trim(), Innovator.ScalcMD5(l_password.Trim()));            
        }

        private void GetInnovator()
        {
            mc_innovator = IomFactory.CreateInnovator(mc_conn);
        }

        private void ShowError(string errormessage)
        {
            MessageBox.Show(errormessage);
        }

        private void SettingConnectionButton(bool bln_ConnectionFlag)
        {
            btn_ConnectionAras.Enabled = !bln_ConnectionFlag;
            btn_disconnection.Enabled = bln_ConnectionFlag;


            txt_serverurl.Enabled = !bln_ConnectionFlag;
            txt_DB.Enabled = !bln_ConnectionFlag;
            txt_username.Enabled = !bln_ConnectionFlag;
            txt_password.Enabled = !bln_ConnectionFlag;

            txt_DataList.Enabled = bln_ConnectionFlag;
            txt_SearchAML.Enabled = bln_ConnectionFlag;
            btn_CheckExist.Enabled = bln_ConnectionFlag;
            btn_Clear.Enabled = bln_ConnectionFlag;
        }

        private void SettingProcess(int maxValue, int CurrentValue)
        {
            decimal getvalue = CurrentValue * 100 / maxValue;
            pro_CheckItem.Value = (int)getvalue;
        }

        private void btn_ConnectionAras_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txt_serverurl.Text.Trim()))
                {
                    throw new Exception("Server Url Is Null Or Empty !");
                }

                if (string.IsNullOrEmpty(txt_DB.Text.Trim()))
                {
                    throw new Exception("DB Name Is Null Or Empty !");
                }

                if (string.IsNullOrEmpty(txt_username.Text.Trim()))
                {
                    throw new Exception("User Name Is Null Or Empty !");
                }

                if (string.IsNullOrEmpty(txt_password.Text.Trim()))
                {
                    throw new Exception("Password Is Null Or Empty !");
                }

                GetConnection(txt_serverurl.Text, txt_DB.Text, txt_username.Text, txt_password.Text);
                GetInnovator();

                Item login_result = mc_conn.Login();
                if (login_result.isError()) throw new Exception("Login failed, please check connection infomation.");

                SettingConnectionButton(true);
            }
            catch (Exception ex)
            {
                ShowError("Connection Aras Error:" + ex.Message);
            }
        }

        private void btn_disconnection_Click(object sender, EventArgs e)
        {
            mc_conn = null;
            mc_innovator = null;
            SettingConnectionButton(false);
        }

        private void btn_CheckExist_Click(object sender, EventArgs e)
        {
            try
            {
                if (mc_innovator == null)
                {
                    throw new Exception("Please Connection To Aras First.");
                }

                if (string.IsNullOrEmpty(txt_DataList.Text.Trim()))
                {
                    throw new Exception("Please Enter need Check Data.");
                }

                if (string.IsNullOrEmpty(txt_SearchAML.Text.Trim()))
                {
                    throw new Exception("Please Enter Search AML .");
                }

                string l_currentPath = System.AppDomain.CurrentDomain.BaseDirectory;
                string l_ExistfileName = "ExistResult.txt";
                string l_NoExistfileName = "NoExistResult.txt";
                StringBuilder l_getExistResultText = new StringBuilder();
                StringBuilder l_getNoExistResultText = new StringBuilder();
                //------------------------------------------------------------------
                string[] l_getDataRow = txt_DataList.Text.Trim().Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                int l_columnIdx = 0;
                for (int rowIDX = 0; rowIDX < l_getDataRow.Length; rowIDX++)
                {
                    SettingProcess(l_getDataRow.Length - 1, rowIDX);

                    string[] l_getDataColumn = l_getDataRow[rowIDX].Split(new char[] { '\t' });
                    if (l_getDataColumn!=null && l_getDataColumn.Length!=0)
                    {
                        l_columnIdx = l_getDataColumn.Length;
                    }

                    string l_AML = "";
                    string l_tempAML = txt_SearchAML.Text.Trim();
                    for (int columnIDX = 0; columnIDX < l_columnIdx; columnIDX++)
                    {
                        l_tempAML = l_tempAML.Replace("$" + (columnIDX + 1), l_getDataColumn[columnIDX]);
                    }

                    l_AML = "<AML>" + l_tempAML + "</AML>";
                    Item l_GetItem = mc_innovator.applyAML(l_AML);

                    if (l_GetItem.isError())
                    {
                        l_getNoExistResultText.Append((rowIDX + 1) + ": " + l_getDataRow[rowIDX] + "\r\n");
                        continue;
                    }

                    if (l_GetItem.getItemCount() == 0)
                    {
                        l_getNoExistResultText.Append((rowIDX + 1) + ": " + l_getDataRow[rowIDX] + "\r\n");
                        continue;
                    }

                    if (l_GetItem.getItemCount() > 0)
                    {
                        StringBuilder l_getItemID = new StringBuilder();
                        for (int k = 0; k < l_GetItem.getItemCount(); k++)
                        {
                            l_getItemID.Append(l_GetItem.getItemByIndex(k).getProperty("id") + ",");
                        }
                        l_getExistResultText.Append((rowIDX + 1) + ": " + l_getDataRow[rowIDX] + "(" + l_getItemID.ToString() + ")" + "\r\n");
                    }
                }
                
                WriteFile(l_currentPath, l_ExistfileName, l_getExistResultText.ToString());
                WriteFile(l_currentPath, l_NoExistfileName, l_getNoExistResultText.ToString());

            }
            catch (Exception ex)
            {
                ShowError("Check Data Error:" + ex.Message);
            }
        }

        public static void WriteFile(string strFilePath, string strFileName, string strContent)
        {
            if (!Directory.Exists(strFilePath))
            {
                Directory.CreateDirectory(strFilePath);
            }

            if (File.Exists(strFilePath + strFileName))
            {
                File.Delete(strFilePath + strFileName);
            }

            using (FileStream fs = new FileStream(strFilePath + strFileName, FileMode.Append, FileAccess.Write))
            {
                StreamWriter stream = new StreamWriter(fs, System.Text.Encoding.UTF8);//写入以UTF-8
                stream.WriteLine(strContent);
                stream.Flush();
                stream.Close();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_DataList.Text = "";
        }
    }
}
