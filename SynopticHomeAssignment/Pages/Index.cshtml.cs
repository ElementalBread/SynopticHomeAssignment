using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CommonClasses;

namespace SynopticHomeAssignment.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;
        private Account _account;

        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        public void OnGet() {
            if(_account == null) {

            }
        }
    }
}