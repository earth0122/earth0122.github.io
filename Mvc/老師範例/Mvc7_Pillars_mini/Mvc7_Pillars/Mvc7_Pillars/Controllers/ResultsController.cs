using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Net.Http.Headers;
using System.Drawing;
using System.Net;
using System.Runtime.Versioning;
using System.Text;
using System.Text.Json;


namespace Mvc7_Pillars.Controllers
{
    public class ResultsController : Controller
    {
        private readonly IWebHostEnvironment _env;
        public ResultsController(IWebHostEnvironment env)
        {
            _env = env;
        }


        #region 回傳ViewResult物件

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Index2()
        {
            return new ViewResult();
        }

        public ViewResult Index3()
        {
            return View();
        }

        public IActionResult Index4()
        {
            return new ViewResult();
        }

        //呼叫View()方法,同時傳入一個model物件
        public ViewResult FriendsList()
        {
            List<Friend> friends = new List<Friend>
            {
                new Friend { Id=1, Name="David", Email="david@gmail.com" },
                new Friend { Id=2, Name="Mary", Email="mary@gmail.com" },
                new Friend { Id=3, Name="Cindy", Email="cindy@gmail.com" },
            };

            return View(friends);
        }

        //GetMassage()以指定View名稱調用Message.cshtml檢視
        public ViewResult GetMessage()
        {
            return View("Message");
        }

        #endregion

        #region 回傳PartialViewResult物件
        public PartialViewResult getPartialView()
        {
            //回傳_CardPartial.cshtml部分檢視
            return PartialView("_CardPartial");
        }

        #endregion

        #region 回傳ContentResult物件
        public ContentResult About()
        {
            return Content("聖殿祭司"); //回傳純文字
        }

        public ContentResult AboutName()
        {
            return Content("<h3>ASP.NET Core MVC</h3>", "text/html");  //回傳HTML
        }

        public ContentResult getInfomation()
        {
            //指定編碼
            string info = "這是plain text純文字";
            return Content(info, "text/plain", Encoding.UTF8);  //回傳純文字,並指定編碼
        }

        public ContentResult AboutMe()
        {
            //回傳HTML Tags
            string time = DateTime.Now.ToLongTimeString();
            return Content($"<h2>聖殿祭司, {time}</h2>", "text/html", Encoding.UTF8);  //回傳html
        }

        public ContentResult AlertMessage()
        {
            //要回傳一段JavaScript也不成問題
            string script = "alert('This is JavaScriptResult!')";

            return Content(script, "application/javascript");

            //return Content($"<html><head></head><body>{script}</body></html>", "text/html");
        }

        public ContentResult JsFunction()
        {
            string script = "function showMessage(){ alert('這是JavaScriptResult定義的function'); }";

            return Content(script, "application/javascript");
        }


        public IActionResult JsPage()
        {
            return View();
        }


        #endregion

        #region 回傳EmptyResult物件
        public EmptyResult Empty()
        {
            return new EmptyResult();
        }


        public EmptyResult Nothing()
        {
            EmptyResult empty = new EmptyResult();
            return empty;
        }

        public IActionResult DoNothing()
        {
            return new EmptyResult();
        }

        #endregion


        #region 回傳JsonResult物件
        //https://docs.microsoft.com/zh-tw/aspnet/core/web-api/advanced/formatting?view=aspnetcore-3.0
        //https://docs.microsoft.com/zh-tw/dotnet/standard/serialization/system-text-json-how-to

        public JsonResult JsonFriends()
        {
            List<Friend> friends = new List<Friend>
            {
                new Friend { Id=1, Name="David", Email="david@gmail.com", City="Taipei", Phone="0925-157-886" },
                new Friend { Id=2, Name="Mary", Email="mary@gmail.com",City="Taoyuan" , Phone="0970-286-335"},
                new Friend { Id=3, Name="Cindy", Email="cindy@gmail.com",City="Kaohsiung", Phone="0937-258-119" },
            };

            var json1 = Json(friends);
            var json2 = Json(friends, new JsonSerializerOptions { WriteIndented = true });

            return Json(friends);
        }

        #endregion

        #region 回傳FileResult
        public FileResult FileResult()
        {
            return File("~/pdf/CorePDF.pdf", "application/pdf");
        }

        public FileResult FileImage()
        {
            return File("~/images/WhiteTwilek.jpg", "image/jpeg");
        }

        #endregion

        #region 回傳FileContentResult
        public FileContentResult FileContentResult()
        {
            var pdfBytes = System.IO.File.ReadAllBytes("wwwroot/pdf/CorePDF.pdf");

            return new FileContentResult(pdfBytes, "application/pdf");
        }

        // compile with: /reference:System.Drawing.Common.dll 
        public FileContentResult ByteArrayContent()
        {
            string root = Directory.GetCurrentDirectory();
            var pathFile = $"{root}/wwwroot/images/darthmual.jpg";
            Bitmap bitmap = new Bitmap(pathFile);
            ImageConverter converter = new ImageConverter();
            byte[] imageArray = (byte[])converter.ConvertTo(bitmap, typeof(byte[]));

            MediaTypeHeaderValue mediaType = new MediaTypeHeaderValue("application/octet-stream");


            return new FileContentResult(imageArray, mediaType);
            //return File(imageArray, "image/jpeg", "darthmual.jpg");
        }
        #endregion

        #region 回傳FileStreamResult物件
        [SupportedOSPlatform("windows")]
        public FileStreamResult FileStream()
        {
            string root = Directory.GetCurrentDirectory();
            Bitmap bitmap = new Bitmap($"{root}/wwwroot/images/vader.jpg");
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            ms.Seek(0, SeekOrigin.Begin);

            return File(ms, "image/jpeg", "vader.jpg");
        }


        #endregion


        #region 回傳PhysicalFileResult
        public PhysicalFileResult PhysicalFileResult()
        {
            return new PhysicalFileResult(Directory.GetCurrentDirectory() + "/wwwroot/pdf/CorePDF.pdf", "application/pdf");

            //return new PhysicalFileResult(_env.ContentRootPath + "/wwwroot/pdf/CorePDF.pdf", "application/pdf");
        }
        #endregion

        #region 回傳VirtualFileResult
        public VirtualFileResult VirtualFileResult()
        {
            return new VirtualFileResult("/pdf/CorePDF.pdf", "application/pdf");
        }
        #endregion


        #region 回傳RedirectResult

        //傳統網頁轉向語法
        public void TraditionalRedirect()
        {
            //HTTP/1.1 302 Found, 臨時轉向
            Response.Redirect("https://www.tempdomain.com/");
        }

        //Http 302 -- 臨時轉向
        public RedirectResult RedirectTemp()
        {
            return Redirect("https://www.tempdomain.com/");
        }

        //Http 301 -- 永久轉向, 例如網站搬到新的Domain
        public RedirectResult RedirectToNewDomain()
        {
            return RedirectPermanent("https://www.newdomain.com.tw"); //永久導向新的Domain
        }


        #endregion

        #region 回傳RedirectToActionResult
        //RedirectToAction()會發出302的臨時轉向HTTP狀態代碼
        public RedirectToActionResult RedirectToActionResult1()
        {
            return RedirectToAction("Index"); //指定Action名稱
        }

        public RedirectToActionResult RedirectToActionResult2()
        {
            //指定Action, Controller名稱
            return RedirectToAction("Index", "Friends");
        }

        public RedirectToActionResult RedirectToActionResult3()
        {
            //指定Action,Controller及路由參數
            return RedirectToAction("Index", "Friends", new { id = 1 });
        }

        public RedirectToActionResult RedirectToActionResult4()
        {
            //指定Action及路由參數
            return RedirectToAction("Index", new { id = 1 });
        }

        //RedirectToActionResult()會發出301的永久轉向HTTP狀態代碼
        public RedirectToActionResult RedirectToActionResult5()
        {
            //指定永久轉向網址
            return RedirectToActionPermanent("https://www.newdomain.com.tw");
        }

        #endregion

        #region 回傳RedirectToRouteResult

        //RedirectToRoute()指定URL路由資訊作轉向
        public RedirectToRouteResult RedirectToRouteResult1()
        {
            return RedirectToRoute("blog", new { Controller = "Blog", action = "ReadArticle" });
        }

        public RedirectToRouteResult RedirectToRouteResult2()
        {
            return RedirectToRoute("default", new { id = 3 });
        }

        public RedirectToRouteResult RedirectToRouteResult3()
        {
            return RedirectToRoute(new { id = 4 });
        }

        #endregion

        public LocalRedirectResult LocalRedirectResult1()
        {
            LocalRedirectResult localRedirect = new LocalRedirectResult("/Friends/Index");
            localRedirect.Permanent = false;     //301 or 302
            localRedirect.PreserveMethod = true; //307 or 308

            return localRedirect;

            //return LocalRedirect("/Friends/Index", false, true);
        }

        //HTTP 狀態碼 : https://developer.mozilla.org/zh-TW/docs/Web/HTTP/Status

        #region 回傳StatusCodeResult

        //StatusCodeResult Class : https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.statuscoderesult?view=aspnetcore-3.0

        //回傳任意指定HTTP狀態代碼
        public StatusCodeResult StatusCodeResult()
        {
            //return new StatusCodeResult(400);

            return new StatusCodeResult((int)HttpStatusCode.BadRequest);
        }

        //200 OK - 請求成功
        public OkResult OKresult()
        {
            return Ok();
        }

        //204 No Content - 沒有任何內容回傳
        public NoContentResult NoContentResult()
        {
            return NoContent();
        }

        //400 Bad Request - 由於語法無效，服務器無法理解該請求
        public BadRequestResult BadRequestResult()
        {
            return BadRequestResult();
        }

        //401 Unauthorized - 缺少授權而回傳之錯誤
        public UnauthorizedResult UnauthorizedResult()
        {
            return Unauthorized();
        }

        //404 Not Found - 伺服器找不到請求的資源
        public NotFoundResult NotFoundResult()
        {
            return NotFound();
        }

        //409 Conflict - 請求與目前伺服器狀態衝突
        public ConflictResult ConflictResult()
        {
            return Conflict();
        }

        //415 Unsupported Media Type - 請求資料的媒體型態不被伺服器支援，故拒絕請求
        public UnsupportedMediaTypeResult UnsupportedMediaTypeResult()
        {
            return new UnsupportedMediaTypeResult();
        }

        //422　Unprocessable　Entity - 請求格式正確，但由於語義錯誤而無法遵循
        public UnprocessableEntityResult UnprocessableEntityResult1()
        {
            return UnprocessableEntity();
        }


        #endregion


        //HTTP 狀態碼 : https://developer.mozilla.org/zh-TW/docs/Web/HTTP/Status

        #region 回傳ObjectResult

        //ObjectResult Class :https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.objectresult?view=aspnetcore-3.0

        public ObjectResult ObjectResult1()
        {
            return new ObjectResult(new { statuscode = 200, date = DateTime.Now.ToLongDateString() });
        }

        //回傳200 OK - 請求成功狀態代碼
        public OkObjectResult OkObjectResult1()
        {
            var msgObject = new
            {
                statuscode = StatusCodes.Status200OK,
                time = DateTime.Now.ToLongTimeString(),
                name = "The request has succeeded.",
                date = DateTime.Now.ToLongDateString()
            };

            return new OkObjectResult(msgObject);
        }


        //W3C : (201 Create)代表Request請求成功,且新資源已被建立成為一個結果
        //回應一個201狀態代碼, 並在Response Headers中有一個Location Header
        public CreatedResult CreatedResult1()
        {
            var msgObject = new
            {
                statuscode = StatusCodes.Status201Created,
                date = DateTime.Now.ToLongDateString(),
                time = DateTime.Now.ToLongTimeString(),
                name = "A new resource has been created as a result."
            };

            return Created("https://dotnet.microsoft.com/download", msgObject);
        }

        //回應一個201狀態代碼, 並在Response Headers中有一個Location Header
        public CreatedAtActionResult CreatedAtActionResult1()
        {
            var msgObject = new
            {
                statuscode = StatusCodes.Status201Created,
                date = DateTime.Now.ToLongDateString(),
                time = DateTime.Now.ToLongTimeString()
            };

            return new CreatedAtActionResult("CreatedAtActionResult1", "Results", new { Id = 1392 }, msgObject);
        }

        //回應一個201狀態代碼, 並在Response Headers中有一個Location Header
        public CreatedAtRouteResult CreatedAtRouteResult1()
        {
            var msgObject = new
            {
                statuscode = StatusCodes.Status201Created,
                date = DateTime.Now.ToLongDateString(),
                time = DateTime.Now.ToLongTimeString(),
            };

            return new CreatedAtRouteResult(new { EmployeeId = 15284 }, msgObject);
        }

        //回應一個Accepted(202)狀態代碼, 並在Response Headers中有一個Location Header
        public AcceptedResult AcceptedResult1()
        {
            var msgObject = new
            {
                statuscode = StatusCodes.Status202Accepted,
                date = DateTime.Now.ToLongDateString(),
                time = DateTime.Now.ToLongTimeString(),
                result = "Your Request had been Accepted."
            };

            return new AcceptedResult("https://api.codemagic.com.tw", msgObject);
        }

        //回應一個Accepted(202)狀態代碼
        public AcceptedAtActionResult AcceptedAtActionResult1()
        {
            var msgObject = new
            {
                StatusCode = StatusCodes.Status202Accepted,
                date = DateTime.Now.ToLongDateString(),
                time = DateTime.Now.ToLongTimeString(),
            };

            return new AcceptedAtActionResult("CreatedAtActionResult1", "Results", new { ProductId = 1392 }, msgObject);
        }

        //回應一個Accepted(202)狀態代碼
        public AcceptedAtRouteResult AcceptedAtRouteResult1()
        {
            var msgObject = new
            {
                statuscode = StatusCodes.Status202Accepted,
                date = DateTime.Now.ToLongDateString(),
                time = DateTime.Now.ToLongTimeString(),
            };

            return new AcceptedAtRouteResult(new { EmployeeId = 15284 }, msgObject);
        }

        //回應400狀態代碼
        public BadRequestObjectResult BadRequestObjectResult1()
        {
            var msgObject = new
            {
                statuscode = StatusCodes.Status400BadRequest,
                date = DateTime.Now.ToLongDateString(),
                time = DateTime.Now.ToLongTimeString()
            };

            return new BadRequestObjectResult(msgObject);
        }

        //回應401狀態代碼
        public UnauthorizedObjectResult UnauthorizedObjectResult1()
        {
            var msgObject = new
            {
                statuscode = StatusCodes.Status401Unauthorized,
                date = DateTime.Now.ToLongDateString(),
                time = DateTime.Now.ToLongTimeString()
            };

            return new UnauthorizedObjectResult(msgObject);
        }

        //回應404狀態代碼
        public NotFoundObjectResult NotFoundObjectResult1()
        {
            var msgObject = new
            {
                statuscode = StatusCodes.Status404NotFound,
                date = DateTime.Now.ToLongDateString(),
                time = DateTime.Now.ToLongTimeString()
            };

            return new NotFoundObjectResult(msgObject);
        }

        //回應409狀態代碼
        public ConflictObjectResult ConflictObjectResult1()
        {
            var msgObject = new
            {
                statuscode = StatusCodes.Status409Conflict,
                date = DateTime.Now.ToLongDateString(),
                time = DateTime.Now.ToLongTimeString()
            };

            return new ConflictObjectResult(msgObject);
        }

        //回應422狀態代碼
        public UnprocessableEntityObjectResult UnprocessableEntityObjectResult1()
        {
            ModelStateDictionary modelState = new ModelStateDictionary();
            modelState.AddModelError("StatusCode", StatusCodes.Status422UnprocessableEntity.ToString());
            modelState.AddModelError("Date", DateTime.Now.ToLongDateString());
            modelState.AddModelError("Time", DateTime.Now.ToLongTimeString());

            return new UnprocessableEntityObjectResult(modelState);
        }


        #endregion
    }
}
