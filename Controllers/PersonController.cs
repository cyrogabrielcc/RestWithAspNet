﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestWithAspNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController  : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

    }
}
