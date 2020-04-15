using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{   
    public class Note : ICloneable
    {
        private string _name = "Без названия";
        
        public string Name
        {
            get
            {
                return _name;
                
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Длина текста больше 50 символов");
                }
                else _name = value;
            }
        }

        public Category Category { get; set; }
      
        public DateTime CreateDateTime { get; private set; }

        public DateTime ChangeDateTime { get; private set; }

        public object Clone()
        {
            Note note = new Note();
            note.Name = this.Name;
            note.Category = this.Category;
            note.CreateDateTime = this.CreateDateTime;
            note.ChangeDateTime = this.ChangeDateTime;
            return note;
        }
    }



    
}

