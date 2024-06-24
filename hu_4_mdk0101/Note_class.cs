using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hu_4_mdk0101;

namespace hu_4_mdk0101
{
    public class Note_class: ICloneable, IComparable<Note_class>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public int[] Birthdate { get; set; }
        public object Clone() 
        {
            return this.MemberwiseClone();
        }
        public int CompareTo(Note_class other)
        {
            return string.Compare(this.PhoneNumber.Substring(0, 3),
                other.PhoneNumber.Substring(0, 3));
        }
    }
    
}
public class LastNameComparer : IComparer
{
    public int Compare(object x, object y)
    {
        Note_class note1 = (Note_class)x;
        Note_class note2 = (Note_class)y;
        return string.Compare(note1.LastName + note1.FirstName, note2.LastName + note2.FirstName);
    }
}
