using System.Runtime.Serialization;

namespace PlanningAPI.Models
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "userName")]
        public string UserName { get; set; }

        [DataMember(Name = "surname")]
        public string Surname { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "secondName")]
        public string SecondName { get; set; }
    }
}