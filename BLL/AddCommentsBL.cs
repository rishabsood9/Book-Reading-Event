using Shared;
using DAL;

namespace BL
    {
    public class AddCommentsBL
        {
            public void AddComment(Comment comment)
            {
            AddCommentsDAL addComments = new AddCommentsDAL();
            addComments.AddComments(comment);
            }
        }
    }
