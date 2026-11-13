using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    public class Member
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public byte Photo { get; set; }
    }
}
