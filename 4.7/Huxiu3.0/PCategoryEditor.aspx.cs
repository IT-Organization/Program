﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PCategoryEditor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Regex r = new Regex("^[1-9]d*|0$");

        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null && r.IsMatch(Request.QueryString["id"]))//要把是否为空放前面
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);

                using (var db = new huxiuEntities())
                {
                    PassageCategory person = (from it in db.PassageCategory where it.PCategoryId == id select it).FirstOrDefault();

                    if (person != null)
                    {
                        name.Text = person.CategoryName;
                    }
                    else
                        Response.Write("<script>alert('地址栏有误');location='/PCategoryList.aspx'</script>");

                }
            }
            Response.Write("<script>alert('地址栏有误');location='/PCategoryList.aspx'</script>");
        }
    }

    protected void btnEditor_Click(object sender, EventArgs e)
    {
        if (name.Text.Trim().Length > 0)
        {
            using (var db = new huxiuEntities())
            {
                PassageCategory person = (from it in db.PassageCategory where it.PCategoryId == id select it).FirstOrDefault();

                person.CategoryName = name.Text.Trim();

                if (db.SaveChanges() == 1)
                    Response.Write("<script>alert('修改成功');location='/PCategoryList.aspx'</script>");
                else
                    Response.Write("<script>alert('修改失败请重试')</script>");

            }
        }
        else
            Response.Write("<script>alert('不能为空')</script>");

    }

    protected void editor_Click(object sender, EventArgs e)
    {
        btnEditor.Visible = true;
        editor.Visible = false;
        name.Enabled = true;
    }
}