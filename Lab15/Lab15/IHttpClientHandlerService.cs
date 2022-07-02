using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Lab15
{
    public interface IHttpClientHandlerService
    {
        HttpClientHandler GetInsecureHandler();
    }
}
