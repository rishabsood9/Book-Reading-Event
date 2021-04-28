using Shared;
using System.Linq;
using System.Collections.Generic;
namespace DAL
    {
    public class CommentsDAL
        {
            public IEnumerable<Comment> GetComments(int eventId)
            {
            IEnumerable<Comment> comments=null;
            using (BookReadingContext context = new BookReadingContext())
                {
                var query = from c in context.Comments
                            where c.EventId == eventId
                            select c;
                if(query !=null)
                    {
                    comments = query.ToList();
                    }
                return comments;
                }
            }
        }
    }
