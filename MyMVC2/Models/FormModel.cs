﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MyMVC2.Models
{
    public class SubmitDataModel
    {
        [Required]
        [DisplayName("Submit Data")]
        public string SubmitData { get; set; }
    }
}
