﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.DataAccessLayer
{
    public class Templates
    {
        public static List<ITemplate> CreateTemplateList()
        {
            return new List<ITemplate> {
                new WhatIsTemplate(),
                new WhereIsTemplate(),
                new WhenTemplate(),
                new TillWhenTemplate(),
                new ActionToTemplate(),
                new ParamsOnlyTemplate()
            };
        }
    }
}