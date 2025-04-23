using Microsoft.AspNetCore.Mvc;
using AmooAI.Models;

namespace AmooAI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<News>> Get()
        {
            var news = new List<News>
            {
                new News
                {
                    Id = 1,
                    Title = "مسابقه هوش مصنوعی برای کودکان",
                    Summary = "اولین مسابقه هوش مصنوعی ویژه کودکان در ایران برگزار می‌شود. این مسابقه برای کودکان 8 تا 12 سال طراحی شده است."
                },
                new News
                {
                    Id = 2,
                    Title = "کارگاه آموزشی رایگان",
                    Summary = "کارگاه آموزشی رایگان هوش مصنوعی برای کودکان 8 تا 12 سال در مراکز آموزشی سراسر کشور برگزار می‌شود."
                },
                new News
                {
                    Id = 3,
                    Title = "کتاب جدید هوش مصنوعی",
                    Summary = "انتشار کتاب جدید آموزش هوش مصنوعی برای کودکان با عنوان 'هوش مصنوعی برای کودکان'."
                },
                new News
                {
                    Id = 4,
                    Title = "برگزاری نمایشگاه هوش مصنوعی",
                    Summary = "نمایشگاه دستاوردهای هوش مصنوعی کودکان در تاریخ 15 خرداد در تهران برگزار می‌شود."
                },
                new News
                {
                    Id = 5,
                    Title = "افتتاح مرکز آموزش هوش مصنوعی",
                    Summary = "اولین مرکز تخصصی آموزش هوش مصنوعی برای کودکان در تهران افتتاح شد."
                },
                new News
                {
                    Id = 6,
                    Title = "برنامه تلویزیونی هوش مصنوعی",
                    Summary = "شبکه آموزش از هفته آینده برنامه جدیدی با موضوع آموزش هوش مصنوعی به کودکان پخش می‌کند."
                }
            };

            return Ok(news);
        }
    }
} 