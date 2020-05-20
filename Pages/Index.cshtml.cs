using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using dotnetweb;

namespace dotnetweb.Pages
{
    public class IndexModel : PageModel
    {
        public string[] Messages {
            get {
                return new string[] {
                    "Hello Build!",
                    "Would you like a Cup<T>?",
                    ".NET all the things!",
                    "Would you like to play a game?",
                    "We need internet in Australia!!!",
                    "Bill Gates is awesome",
                    "Developers Developers Developers",
                    "This is a really long string. We might have to wait a while for this string to eat donuts. DONUTS DONUTS DONUTS for all the Developres Developers Developers"
                    
                };
            }
        }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
