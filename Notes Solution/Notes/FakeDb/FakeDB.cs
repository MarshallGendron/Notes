using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Notes.FakeDb
{
    public static class FakeDB
    {
        static FakeDB()
        {
            TempList = TempList = new List<Category>()
            {
                new Category()
                {
                    Name = "Car",
                    Notes = new List<Note>()
                    {
                        new Note()
                        {
                            Question = "How do you start a car?",
                            Answer = "1. Hold down the break. 2. Put the key in. 3. Turn the key."
                        },
                        new Note()
                        {
                            Question = "How do you change the oil in your car?"
                        },
                        new Note()
                        {
                            Question = "What is a 4L Engine?",
                            Answer = "Engine displacement is measured in liters or cubic centimeters." +
                            "That measurement represents the total displacement of all the cylinders in an " +
                            "engine."
                        }
                    }
                },
                new Category()
                {
                    Name = "Food",
                    Notes = new List<Note>()
                    {
                        new Note()
                        {
                            Question = "How do you fry an egg?",
                            Answer = "Put oil in heated pan. Put egg in pan. Wait."
                        },
                        new Note()
                        {
                            Question = "What is in birds nest soup?",
                            Answer = "A birds nest."
                        }
                    }
                },
                new Category()
                {
                    Name = "Programming",
                    Notes = new List<Note>()
                    {
                        new Note()
                        {
                            Question = "Stack vs. Heap?",
                            Answer = "Both are stored in RAM. The stack is for static memory allocation. " +
                            "The heap, for dynamic memory allocation. To be continued." +
                            "https://www.c-sharpcorner.com/article/C-Sharp-heaping-vs-stacking-in-net-part-i/"
                        },
                        new Note()
                        {
                            Question = "What is base64 and what is it commonly used for?",
                            Answer = "Binary data converted to a string of commonly used ASCII characters." +
                            " Pt. 2 - tbd"
                        },
                        new Note()
                        {
                            Question = "Whats the difference between asynchronous and parallel programming?",
                            Answer = "Async - Focuses on responsiveness. Parallel focuses on performance."
                        },
                        new Note()
                        {
                            Question = "Stack vs Queue?",
                            Answer = "Stack is a last in first out (LIFO) data structure. A Queue is pretty much " +
                            "the opposite to that. Much like a line you wait in, it's first in first out."
                        },
                        new Note()
                        {
                            Question = "LESS vs SASS?",
                            Answer = "LESS - an attempt to extend css. You can declare variables to use in the stylesheet " +
                            "along with functions. When you compile it you have to/ or your tool will convert it to a css file " +
                            "so the browser can interpret it. SASS ??"
                        }
                    }
                }
            };
        }

        private static List<Category> TempList;
        public static IList<Category> GetCategories()
        {
            return TempList;
        }

        public static void AddCategory(string name)
        {
            TempList.Add(new Category() { Name = name });
        }

    }

    public class Category
    {
        public Category()
        {
            this.Notes = new List<Note>();
        }
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        public IList<Note> Notes { get; set; }
    }

    public class Note
    {
        [Display(Name = "Question")]
        public string Question { get; set; }

        [Display(Name = "Answer")]
        public string Answer { get; set; }
    }
}