using System;
using System.Collections.Generic;
using AutoMapper;
using Shared;
using MVCAssignment.Models;


namespace MVCAssignment.Helper
    {
    public class CommentToCommentModelHelper
        {
        public CommentModel CommentToCommentModelMapping(Comment c)
            {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<Comment, CommentModel>();

            });
            IMapper iMapper = config.CreateMapper();

            var source = c;

            var destination = iMapper.Map<Comment, CommentModel>(source);
            return destination;
            }

        public IEnumerable<CommentModel> GetCommentModels(IEnumerable<Comment> comments)
            {
            List<CommentModel> commentModels = new List<CommentModel>();
            foreach (var item in comments)
                {
                commentModels.Add(CommentToCommentModelMapping(item));
                }
            return commentModels;

            }
        }
    }