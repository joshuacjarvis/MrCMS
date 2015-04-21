﻿using System.Collections.Generic;
using System.Linq;
using MrCMS.Services;

namespace MrCMS.Website.Optimization
{
    public class AppStylesheetBundle : IStylesheetBundle
    {
        private readonly IEnumerable<IAppStylesheetList> _stylesheetLists;

        public AppStylesheetBundle(IEnumerable<IAppStylesheetList> stylesheetLists)
        {
            _stylesheetLists = stylesheetLists;
        }

        public string Url { get { return "~/stylesheets/apps"; } }

        public IEnumerable<string> Files
        {
            get { return _stylesheetLists.SelectMany(list => list.UIStylesheets); }
        }
    }
}