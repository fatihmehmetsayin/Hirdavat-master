﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hirdavat_Api_Nesne2.Dto
{
    public class CategoryDto
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


    }
}
