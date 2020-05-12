using ReportGeneration.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReportGeneration.Web.Models
{
    public class VoteModel
    {
        [Required]
        public int CommentId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public bool IsLiked { get; set; }

        public Vote Vote()
        {
            var vote = new Vote
            {
                CommentId = CommentId,
                UserId = UserId,
                IsLiked = IsLiked
            };
            return vote;
        }
    }
}
