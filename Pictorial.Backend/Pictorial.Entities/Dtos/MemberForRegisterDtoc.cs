﻿using Pictorial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Entities.Dtos
{
    public class MemberForRegisterDtoc: IDto
    {
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
