﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewStudentProject.Helpers
{
    public static class HtmlHelpers
    {
        // this HtmlHelper helper refers to an extension created
        public static string Truncate(this HtmlHelper helper, string input, int length)
        {
            if (input.Length <= length)
                return input;
            else return input.Substring(0, length) + "...";
        }


    }
}