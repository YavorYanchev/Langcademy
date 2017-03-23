using Langcademy.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Data.Models
{
    public class Answer 
    {
        [Key]
        public int Id { get; set; }
        //************************

         

        //****************************

        //public string Text { get; set; }

        //public int ForWordToTranslateId { get; set; }

        //public virtual WordToTranslate ForWordToTranslate { get; set; }

        //public bool IsCorrect { get; set; }

        //public bool IsDeleted { get; set; }

        //public DateTime? DeletedOn { get; set; }
    }
}
