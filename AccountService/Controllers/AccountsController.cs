using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Google.Cloud.Firestore;

namespace AccountService.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : Controller {
        private readonly ILogger<AccountsController> _logger;
        private FirestoreDb db = FirestoreDb.Create("synopticassignmen");

        public AccountsController(ILogger<AccountsController> logger) {
            _logger = logger;
        }

        [HttpPost("~/register/{email}/{password}")]
        public async Task register(string email, string password) {
            DocumentReference docRef = db.Collection("users").Document(email);
            Dictionary<string, object> user = new Dictionary<string, object>
            {
                { "email", email},
                { "password", password },
            };
            await docRef.SetAsync(user);
        }


        [HttpGet("~/login/{email}/{password}")]
        public async Task<bool> login(string email, string password) {
            CollectionReference usersRef = db.Collection("users");
            QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot.Documents) {
                Dictionary<string, object> documentDictionary = document.ToDictionary();

                Console.WriteLine(documentDictionary);

                if (String.Compare(documentDictionary["email"].ToString(),email)==0) {
                    if (String.Compare(documentDictionary["password"].ToString(), password) == 0) {
                        return true;
                    }
                }
            }
            return false;
        }
    }
    
}
