﻿using System;

namespace CommentingService.DTOs
{
    public class CommentReplyCreateDto
    {
        /// <summary>
        /// Replies comment
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Date and time of reply
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Id of comment
        /// </summary>
        public Guid CommentId { get; set; }
        /// <summary>
        /// Id of user
        /// </summary>
        public Guid UserId { get; set; }
    }
}
