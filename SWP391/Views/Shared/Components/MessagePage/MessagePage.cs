using Microsoft.AspNetCore.Mvc;

namespace XTLASPNET
{
    [ViewComponent]
    public class MessagePage : ViewComponent
    {
        public const string COMPONENTNAME = "MessagePage";
        // Dữ liệu nội dung trang thông báo
        public class Message
        {
            public string Title { set; get; } = "Notification";
            public string HtmlContent { set; get; } = "";
            public string UrlRedirect { set; get; } = "/";
            public int SecondWait { set; get; } = 3;
        }
        public MessagePage() { }
        public IViewComponentResult Invoke(Message message)
        {
            this.HttpContext.Response.Headers.Add("REFRESH", $"{message.SecondWait};URL={message.UrlRedirect}");
            return View(message);
        }
    }
}