using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HrProject_Data
{
     public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CommentText { get; set; }

        [Required]
        public Guid Author { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

        // linkage to Posts

        // this will set the foreigh key to thr primay key in Post
        [ForeignKey(nameof(Post))]
        public int PostID { get; set; }

        // navigation property - I believe this is used to access Post properties from the comment class
        public virtual Post Post { get; set; }


        /// rough in for Replies

        //public virtual List<Reply> Reply { get; set; }

        //[ForeignKey(nameof(Reply))]

        //public int ReplyId { get; set; }

    }
}
