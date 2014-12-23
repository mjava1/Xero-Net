using Xero.Api.Common;
using Xero.Api.Core.Model;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public class FoldersEndpoint : XeroReadEndpoint<FoldersEndpoint, Folder, FolderResponse>
    {
        public FoldersEndpoint(XeroHttpClient client) 
            : base(client, "/files.xro/1.0/folders")
        {
        }

        public FolderResponse Create(Folder item)
        {
            return Post(item);
        }

        protected FolderResponse Post(Folder data)
        {
            try
            {
                Client.Parameters = Parameters;
                return Client.PostOne<FolderResponse>(ApiEndpointUrl, data);
            }
            finally
            {
                ClearQueryString();
            }
        }
    }
}