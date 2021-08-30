using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountController : Controller
    {
        private readonly IFirstCounter firstCounter;
        private readonly ISecondCounter secondCounter;
        public CountController(IFirstCounter firstCounter, ISecondCounter secondCounter)
        {
            this.firstCounter = firstCounter;
            this.secondCounter = secondCounter;
        }


        [HttpGet]
        public int Get()
        {
            firstCounter.IncrementAndGet();
            return secondCounter.IncrementAndGet();
        }
    }
}
