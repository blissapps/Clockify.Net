using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Clockify.Net.Models;
using Clockify.Net.Models.Groups;
using RestSharp;

namespace Clockify.Net
{
    public partial class ClockifyClient
    {
        /// <summary>
        /// Find all groups on workspace
        /// </summary>
        public async Task<Response<IEnumerable<GroupDto>>> GetAllGroupsOnWorkspace(string workspaceId, AllGroupsRequestParams parameters = null)
        {
            var request = new RestRequest($"workspaces/{workspaceId}/user-groups");
            
            if(parameters != null){
                request.AddJsonBody<AllGroupsRequestParams>(parameters);
            }

            return Response<IEnumerable<GroupDto>>.FromRestResponse(await _client.ExecuteGetAsync<IEnumerable<GroupDto>>(request).ConfigureAwait(false));
        }
    }
}
