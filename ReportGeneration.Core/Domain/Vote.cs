using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ReportGeneration.Core.Domain
{
    public class Vote   
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int CommentId { get; set; }
        public Comment Comment { get; set; }

        public bool IsLiked { get; set; }
    }
}
