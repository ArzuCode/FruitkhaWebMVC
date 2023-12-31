﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services.Abstract
{
    public interface ICommentManager
    {
        List<Comment> GetNewComment(int newId);
        void AddComment(Comment comment);
    }
}
