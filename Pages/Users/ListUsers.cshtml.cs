using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NiceLia.Data;
using NiceLia.Models.Domain;

namespace NiceLia.Pages.Users
{
    public class ListUsersModel : PageModel
    {
        private readonly UserDbContext dbContext;

        public List<User> _Users { get; set; }

        public ListUsersModel(UserDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void OnGet()
        {
            _Users = dbContext._users.ToList();
        }
    }
}
