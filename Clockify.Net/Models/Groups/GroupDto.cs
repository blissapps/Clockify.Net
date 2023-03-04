using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Clockify.Net.Models.Groups
{
    public class GroupDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> UserIds { get; set; }
        public string WorkspaceId { get; set; }
    }
}