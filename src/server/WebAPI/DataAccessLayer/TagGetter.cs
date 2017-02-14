﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.DataAccessLayer
{
    public class TagGetter
    {
        public static IEnumerable<object> GetTags()
        {
            var dataContext = new PersonDataContext();
            var isAdmin = CurrentMisparIshi.IsAdmin();
            return dataContext.TagPrimes
                .Where(tag => tag.AllowNonAdminsToAdd || isAdmin)
                .Select(tag => new {
                    tag = tag.Tag
                })
                .ToList();
        }
    }
}