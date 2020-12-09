using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class ImageModel
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string AltText { get; set; }
        public string Path { get; set; }

        public ProjectModel Project { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
