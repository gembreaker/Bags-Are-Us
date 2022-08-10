using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WebApp2020.Shared.ViewModels
{
    public abstract class BaseFilterViewModel
    {
        //public string SearchString { get; set; }

        public int PageSize { get; set; } = 10;

        public int[] PageSizes
        {
            get { return new int[] { 10, 20, 50 }; }
        }

        /// <summary>
        /// Gets the number of pages in the record set retrieved based on the page size
        /// </summary>
        [Display(Name = "Pages")]
        public int PageCount
        {
            get
            {
                if (PageSize == 0)
                    return 1;
                else
                    return (int)Math.Ceiling((double)RecordCount / PageSize);
            }
        }

        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// Gets a list of available page numbers for the recordset retrieved. Simply returns 1...Page Count as a collection
        /// </summary>
        [Display(Name = "Pages")]
        public int[] Pages
        {
            get { return Enumerable.Range(1, PageCount).ToArray(); }
        }

        /// <summary>
        /// Gets or sets the current number of records retrieved
        /// </summary>
        [Display(Name = "Number of Records")]
        public int RecordCount { get; set; }

        /// <summary>
        /// Gets the number of records to skip to display the records for the selected page number
        /// </summary>
        [Display(Name = "Skip")]
        public int SkipCount { get { return (PageNumber - 1) * PageSize; } }
    }
}
