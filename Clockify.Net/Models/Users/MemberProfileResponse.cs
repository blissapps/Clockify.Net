using System.Collections.Generic;
using Clockify.Net.Models.Memberships;

namespace Clockify.Net.Models.Users
{
    public class MemberProfileResponse
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string WeekStart { get; set; }
        public string WorkCapacity { get; set; }
        public List<string> WorkingDays { get; set; }
        public string WorkspaceNumber { get; set; }
        public List<UserCustomFieldValueFullDtoV1> UserCustomFields { get; set; }
        public bool HasPassword { get; set; }
        public bool HasPendingApprovalRequest { get; set; }
    }
}