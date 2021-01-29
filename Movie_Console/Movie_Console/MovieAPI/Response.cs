using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Console.MovieAPI
{
    public class Response
    {
        public Movie Data { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
