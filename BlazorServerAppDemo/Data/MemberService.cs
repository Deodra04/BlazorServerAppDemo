using BlazorServerAppDemo.Migrations;

namespace BlazorServerAppDemo.Data
{
    public class MemberService
    {
        public List<Member> GetMembers () { 
            using (var context = new AppDBContext())
            {
                var memberList = context.Members.ToList ();
                return memberList;
            }
        }
        public Member GetMemberById(string memberId)
        {

            using (var context = new AppDBContext())
            {
                var member = context.Members?.SingleOrDefault(m => m.MemberId == memberId);
                return member;
            }
        }
        public void AddMember(Member member)
        {
            if (member != null)
            {
                using (var context = new AppDBContext())
                {
                    var mem = new Member {
                        MemberName = member.MemberName,
                        Email = member.Email,
                        Age = member.Age,
                        JoiningDate = member.JoiningDate
                    };
                    context.Members.Add(mem);
                    context.SaveChanges();
                }
            }
        }
    }
}
