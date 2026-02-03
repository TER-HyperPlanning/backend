using HP2.Domain.Common;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HP2.Domain.Models
{
    public class MatiereTestModel : BaseModel
    {
        public int Id { get; set; }

        public string? Nom { get; set; }

        public string? Description { get; set; }

        public DateTime? DateCreation { get; set; }

    }
}
