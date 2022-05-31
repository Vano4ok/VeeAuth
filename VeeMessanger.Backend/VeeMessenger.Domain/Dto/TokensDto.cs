using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeeMessenger.Data.Entities;

namespace VeeMessenger.Domain.Dto
{
    public class TokensDto
    {
        public string AccessToken { get; set; } = string.Empty;

        public RefreshSession RefreshSession { get; set; } = new RefreshSession();
    }
}
