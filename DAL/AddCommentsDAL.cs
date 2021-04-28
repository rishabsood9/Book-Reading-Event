using Shared;
namespace DAL
    {
    public  class AddCommentsDAL
        {

           public void AddComments(Comment comment)
            {
            using (BookReadingContext context = new BookReadingContext())
                {
                context.Comments.Add(comment);
                context.SaveChanges();
                }
            }
        }
    }
