using Microsoft.AspNetCore.Mvc;
using AmooAI.Models;

namespace AmooAI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LessonsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Lesson>> Get()
        {
            var lessons = new List<Lesson>
            {
                new Lesson
                {
                    Id = 1,
                    Title = "مقدمه ای بر هوش مصنوعی",
                    Description = "در این درس با مفاهیم پایه هوش مصنوعی آشنا می‌شویم و یاد می‌گیریم که هوش مصنوعی چیست و چگونه کار می‌کند."
                },
                new Lesson
                {
                    Id = 2,
                    Title = "یادگیری ماشین چیست؟",
                    Description = "آشنایی با مفاهیم اولیه یادگیری ماشین و کاربردهای آن در زندگی روزمره."
                },
                new Lesson
                {
                    Id = 3,
                    Title = "ربات‌ها و هوش مصنوعی",
                    Description = "نحوه استفاده از هوش مصنوعی در ربات‌ها و کاربردهای آن در صنعت و زندگی روزمره."
                },
                new Lesson
                {
                    Id = 4,
                    Title = "تشخیص تصویر با هوش مصنوعی",
                    Description = "آموزش نحوه تشخیص اشیاء و چهره‌ها توسط کامپیوتر با استفاده از هوش مصنوعی."
                },
                new Lesson
                {
                    Id = 5,
                    Title = "چت‌بات‌های هوشمند",
                    Description = "آشنایی با نحوه کار چت‌بات‌ها و یادگیری ساخت یک چت‌بات ساده."
                },
                new Lesson
                {
                    Id = 6,
                    Title = "بازی‌های هوشمند",
                    Description = "نحوه استفاده از هوش مصنوعی در بازی‌های کامپیوتری و ساخت بازی‌های هوشمند."
                }
            };

            return Ok(lessons);
        }
    }
} 