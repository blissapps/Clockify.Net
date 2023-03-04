using System.Text.Json.Serialization;

namespace Clockify.Net.Models.Groups
{
    public class AllGroupsRequestParams
    {
        public string ProjectId { get; set; }
        public string Name { get; set; }

        [JsonPropertyName("sort-column")]
        public string SortColumn { get; set; }

        [JsonPropertyName("sort-order")]
        public string SortOrder { get; set; }

        public int Page { get; set; }

        [JsonPropertyName("page-size")]
        public int PageSize { get; set; }
    }
}