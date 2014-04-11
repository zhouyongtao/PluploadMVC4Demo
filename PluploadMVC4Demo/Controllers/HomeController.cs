using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PluploadMVC4Demo.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 文件上传
        /// </summary>
        /// <returns></returns>
        public ActionResult Upload()
        {
            for (int i = 0; i < Request.Files.Count; i++)
            {
                var file = Request.Files[i];
                if (file != null)
                    file.SaveAs(AppDomain.CurrentDomain.BaseDirectory + "Uploads/" + file.FileName);
            }
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
    }
}
