using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class ProfileViewModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public bool firstLogin { get; set; }
        public ProfileMobilePhoneViewModel mobilePhone { get; set; }
        public ProfileMobilePhoneViewModel phone { get; set; }
        public string companyName { get; set; }
        public List<ProfileFileViewModel> files { get; set; }
        public List<ProfileInterviewViewModel> interviews { get; set; }
        public List<ProfileAddressViewModel> addresses { get; set; }
    }
}
