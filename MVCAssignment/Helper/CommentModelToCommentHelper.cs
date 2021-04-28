using System.Collections.Generic;
using AutoMapper;
using Shared;
using MVCAssignment.Models;

namespace MVCAssignment.Helper
    {
    public class CommentModelToCommentHelper
        {
        public Comment CommentModelToCommentMapping(CommentModel c)
            {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<CommentModel, Comment>();

            });
            IMapper iMapper = config.CreateMapper();

            var source = c;

            var destination = iMapper.Map<CommentModel, Comment>(source);
            return destination;
            }

        }
    }