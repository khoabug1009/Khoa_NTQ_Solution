using DataLayer.DAO;
using Khoa_NTQ_Solution.Areas.Admin.Model;
using Khoa_NTQ_Solution.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Khoa_NTQ_Solution.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.Email, Encryptor.MD5Hash( model.PassWord));
                if (result == 1 )
                {
                    
                    var user = dao.GetById(model.Email);
                    var userSession = new UserLogin();
                    userSession.Email = user.Email;
                    userSession.UserID = user.ID;
                    Session.Add(CommonConstants.USER_SESION, userSession);
                    if (user.Role == 1)
                    {
                        return RedirectToAction("Index", "HomeAdmin");
                    }
                    else
                    {
                        return RedirectToAction("Index", "HomeUser");
                    }
                    
                }
                else if(result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else if(result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đã bị xóa");
                }else if(result == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng Nhập không đúng");
                }
                
            }
            return View("Index");
        }
    }
}