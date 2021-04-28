using Shared;
using System.Collections.Generic;
using DAL;
using System.Linq;


namespace BL
    {
    public class CommentsBL
        {
             public IEnumerable<Comment> GetComments(int eventId)
            {
            IEnumerable<Comment> comments=null;
             
            var query = from c in (new CommentsDAL().GetComments(eventId))
                        orderby c.Date
                        select c;
            if(query!=null)
                {
                comments = query.ToList();
                }
            return comments;      
            }
        }
    }
