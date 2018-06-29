using Notes.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notes.Models
{
    public class NotesModel
    {
        public List<Category> Categories { get; set; }

        public string NewCategoryName { get; set; }

        public Note NewNote { get; set; }
    }
}