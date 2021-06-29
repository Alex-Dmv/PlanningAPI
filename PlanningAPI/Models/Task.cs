using System;
using System.Runtime.Serialization;
using PlanningAPI.Services;


namespace PlanningAPI.Models
{
    [DataContract]
    public class Task
    {
        private UserService userService;

        public Task()
        {
            this.userService = new UserService();
        }

        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "subject")]
        public string Subject { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [IgnoreDataMember]
        public User CreationAuthor { get; set; }

        [DataMember(Name = "creationAuthor")]
        public long? CreationAuthorId
        {
            get { return (this.CreationAuthor != null ? (long?)this.CreationAuthor.Id : null); }
            set
            {
                if (value.HasValue)
                {
                    this.CreationAuthor = userService.GetUser(value.Value);
                }
            }
        }

        [IgnoreDataMember]
        public User Executor { get; set; }

        [DataMember(Name = "executor")]
        public long? ExecutorId
        {
            get { return (this.Executor != null ?  (long?)this.Executor.Id : null);  }
            set
            {
                if (value.HasValue)
                {
                    this.Executor = this.userService.GetUser(value.Value);
                }
            }
        }

        [DataMember(Name = "creationDate")]
        public DateTime? CreationDate { get; set; }

        [DataMember(Name = "planStartDate")]
        public DateTime? PlanStartDate { get; set; }

        [DataMember(Name = "planEndDate")]
        public DateTime? PlanEndDate { get; set; }

        [DataMember(Name = "endDate")]
        public DateTime? EndDate { get; set; }

        [DataMember(Name = "status")]
        public int Status { get; set; }

        [DataMember(Name = "order")]
        public int Order { get; set; }
    }

    public class TaskModel
    {

    }
}