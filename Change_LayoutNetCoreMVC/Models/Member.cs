using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Change_LayoutNetCoreMVC.Models
{
    public class Member
    {
        [Key]
        public string RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public MemberStatus Status { get; set; }

        public Member()
        {
            this.Gender = Gender.Male;
            this.Status = MemberStatus.Activated;
        }
    }
    public enum Gender
    {
        Female = 1,
        Male = 2,
        Other = 3
    }

    public enum MemberStatus
    {
        Activated = 1,
        Deactivated = 2
    }
}
