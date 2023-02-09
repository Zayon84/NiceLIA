using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NiceLia.Data;
using NiceLia.Models.Domain;
using NiceLia.Models.ViewModel;

namespace NiceLia.Pages.Users
{
    public class AddUserModel : PageModel
    {
		private readonly UserDbContext dbContext;
        [BindProperty]
        public AddUserViewModel AddUserRequest { get; set; }

        public AddUserModel(UserDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
		public void OnGet()
        {
        }

        public void OnPost()
        {
            var userDomainModel = new User
            {
                Name = AddUserRequest.Name,
                Email = AddUserRequest.Email,
                Education = AddUserRequest.Education,
                Location = AddUserRequest.Location,
                PhoneNr = AddUserRequest.PhoneNr,
                School = AddUserRequest.School
            };

            dbContext._users.Add(userDomainModel);
            dbContext.SaveChanges();
        }
    }
}
