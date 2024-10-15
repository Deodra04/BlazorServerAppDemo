
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerAppDemo.Data
{
    [Serializable]
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MemberId { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}
