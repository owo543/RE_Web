using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace RE_Web
{
    /// <summary>
    /// Handler1 的摘要描述
    /// </summary>
    public class Handler1 : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["ID"].ToString() == "000")
            {
                context.Response.Redirect("test1");
                if (context.Session["Passwd"].ToString() == "9999")
                {
                    context.Session["login"] = "ok";
                    
                    context.Application["onlineCount"] = Convert.ToInt32(context.Application["onlineCount"]) + 1;
                    context.Response.Redirect("test1");
                }
                
            }

            
            
            //context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}