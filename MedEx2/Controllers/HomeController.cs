using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MedExFinal.Models;
using MedEx2.Models;
using MedEx2.DAL;
using System.IO;

namespace MedEx2.Controllers
{
    
    public class HomeController : Controller
    {
        private MedExContext db = new MedExContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Certifications(int DoctorId = 1)
        {
            Certifications_CertComplete certifications_CertComplete = new Certifications_CertComplete();

            certifications_CertComplete.Certificates = db.Certificates.ToList();

            ViewBag.Doctor = db.Doctors.Find(DoctorId);
            ViewBag.DoctorId = DoctorId;
            certifications_CertComplete.CompletedCerts = db.CompletedCert.ToList();
            ViewBag.Certs = db.Certificates.ToList();
            return View(certifications_CertComplete);
        }

        namespace FileUpload.Controllers
    {
        public class UploadController : Controller
        {
            // GET: Upload  
            public ActionResult Index()
            {
                return View();
            }
            [HttpGet]

            public ActionResult UploadFile()
            {
                return View();
            }
            [HttpPost]

            public ActionResult UploadFile(HttpPostedFileBase file)
            {
                try
                {
                    if (file.ContentLength > 0)
                    {
                        string _FileName = Path.GetFileName(file.FileName);
                        string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                        file.SaveAs(_path);
                    }
                    ViewBag.Message = "File Uploaded Successfully!!";
                    return View();
                }
                catch
                {
                    ViewBag.Message = "File upload failed!!";
                    return View();
                }
            }
        }
    }
}
}