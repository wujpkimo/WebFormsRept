using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<(string name, string tel)> navs = new List<(string name, string tel)>(){
                ("str","str"),("str1","str1"),("str2","str2") };
            List<MyClass> navs1 = new List<MyClass>(){
                new MyClass(){Name="<div>test</div>",Tel="str" },
                new MyClass(){Name="str1",Tel="str1" },
                new MyClass(){Name="str2",Tel="str2" }};
            String[] myStringArray = new String[] { "one", "two", "three" };

            rptr.DataSource = navs1;
            rptr.DataBind();
        }

        private class MyClass
        {
            public string Name { get; set; }
            public string Tel { get; set; }
        }
    }
}