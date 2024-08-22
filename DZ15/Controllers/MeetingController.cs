using DZ15.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO.Pipes;

namespace DZ15.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeetingController : ControllerBase
    {
        private new List<Meeting> nameAges = new List<Meeting>()
        {
            new Meeting{Id = 1, Name = "Alexandr", Age = 20},
            new Meeting{Id = 2, Name = "Olga", Age = 45},
            new Meeting{Id = 3, Name = "Dmitry", Age = 34},
            new Meeting{Id = 4, Name = "Ivan", Age = 26},
            new Meeting{Id = 5, Name = "Sveta", Age = 48},
            new Meeting{Id = 6, Name = "Grisha", Age = 29}
        };

        private readonly ILogger<MeetingController> _logger;

        public MeetingController(ILogger<MeetingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMeeting")]
        public IEnumerable<Meeting> Get(List<Meeting> nameAges)
        {
            return Enumerable.Range(1, 5).Select(index => new Meeting
            {
                Id = nameAges[index].Id,
                Name = nameAges[index].Name,
                Age = nameAges[index].Age,
                Date = DateTime.Now,


            })
            .ToArray();


        }
    }
}
