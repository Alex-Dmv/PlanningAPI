using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PlanningAPI.Models;

namespace PlanningAPI.PlanningAPIContext
{
    public class PlanningInitializer : System.Data.Entity.CreateDatabaseIfNotExists<PlanningAPIContext>
    {
        protected override void Seed(PlanningAPIContext context)
        {
            var users = new List<User>
            {
                new User
                {
                    FirstName = "Иван",
                    SecondName = "",
                    Surname = "Петров",
                    UserName = "user1"
                },
                new User
                {
                    FirstName = "Пётр",
                    SecondName = "",
                    Surname = "Иванов",
                    UserName = "user2"
                },
                new User
                {
                    FirstName = "Артём",
                    SecondName = "",
                    Surname = "Васильев",
                    UserName = "user3"
                },
                new User
                {
                    FirstName = "Сергей",
                    SecondName = "",
                    Surname = "Кузнецов",
                    UserName = "user4"
                },
                new User
                {
                    FirstName = "Артём",
                    SecondName = "",
                    Surname = "Некрасов",
                    UserName = "user5"
                },
                new User
                {
                    FirstName = "Артём",
                    SecondName = "",
                    Surname = "Некрасов",
                    UserName = "user6"
                }
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
            var tasks = new List<Task>
            {
                //new Task
                //{
                //    CreationAuthor = users.FirstOrDefault(x => x.Id == 1),
                //    CreationDate = DateTime.Parse("2021-06-05"),
                //    Description = "",
                //    EndDate = DateTime.Parse("2021-06-05"),
                //    Executor = users.FirstOrDefault(x => x.Id == 3),
                //    Order = 1,
                //    PlanEndDate = DateTime.Parse("2021-06-08"),
                //    PlanStartDate = DateTime.Parse("2021-06-05"),
                //    Status = 1,
                //    Subject = "Анализ"
                //},
                new Task
                {
                    CreationAuthor = context.Users.FirstOrDefault(x => x.Id == 1),
                    CreationDate = DateTime.Parse("2021-06-05"),
                    Description = "",
                    EndDate = DateTime.Parse("2021-06-05"),
                    Executor = context.Users.FirstOrDefault(x => x.Id == 1),
                    Order = 1,
                    PlanEndDate = DateTime.Parse("2021-06-08"),
                    PlanStartDate = DateTime.Parse("2021-06-05"),
                    Status = 1,
                    Subject = "Анализ"
                },
                new Task
                {
                    CreationAuthor = users.FirstOrDefault(x => x.Id == 1),
                    CreationDate = DateTime.Parse("2021-06-05"),
                    Description = "",
                    EndDate = DateTime.Parse("2021-06-05"),
                    Executor = users.FirstOrDefault(x => x.Id == 4),
                    Order = 1,
                    PlanEndDate = DateTime.Parse("2021-06-08"),
                    PlanStartDate = DateTime.Parse("2021-06-07"),
                    Status = 1,
                    Subject = "Анализ"
                },
                new Task
                {
                    CreationAuthor = users.FirstOrDefault(x => x.Id == 1),
                    CreationDate = DateTime.Parse("2021-06-05"),
                    Description = "",
                    EndDate = DateTime.Parse("2021-06-05"),
                    Executor = users.FirstOrDefault(x => x.Id == 3),
                    Order = 1,
                    PlanEndDate = DateTime.Parse("2021-06-08"),
                    PlanStartDate = DateTime.Parse("2021-06-07"),
                    Status = 1,
                    Subject = "Планирование"
                },
                new Task
                {
                    CreationAuthor = users.FirstOrDefault(x => x.Id == 1),
                    CreationDate = DateTime.Parse("2021-06-05"),
                    Description = "",
                    EndDate = DateTime.Parse("2021-06-05"),
                    Executor = users.FirstOrDefault(x => x.Id == 2),
                    Order = 1,
                    PlanEndDate = DateTime.Parse("2021-06-09"),
                    PlanStartDate = DateTime.Parse("2021-06-08"),
                    Status = 1,
                    Subject = "Проектирование"
                },
                new Task
                {
                    CreationAuthor = users.FirstOrDefault(x => x.Id == 1),
                    CreationDate = DateTime.Parse("2021-06-05"),
                    Description = "",
                    EndDate = DateTime.Parse("2021-06-05"),
                    Executor = users.FirstOrDefault(x => x.Id == 3),
                    Order = 1,
                    PlanEndDate = DateTime.Parse("2021-06-11"),
                    PlanStartDate = DateTime.Parse("2021-06-08"),
                    Status = 1,
                    Subject = "Разработка"
                },
                new Task
                {
                    CreationAuthor = users.FirstOrDefault(x => x.Id == 1),
                    CreationDate = DateTime.Parse("2021-06-05"),
                    Description = "",
                    EndDate = DateTime.Parse("2021-06-05"),
                    Executor = null,
                    Order = 1,
                    PlanEndDate = DateTime.Parse("2021-06-11"),
                    PlanStartDate = DateTime.Parse("2021-06-10"),
                    Status = 1,
                    Subject = "Тестирование"
                },
                new Task
                {
                    CreationAuthor = users.FirstOrDefault(x => x.Id == 3),
                    CreationDate = DateTime.Parse("2021-06-05"),
                    Description = "",
                    EndDate = DateTime.Parse("2021-06-05"),
                    Executor = null, //users.FirstOrDefault(x => x.Id == 4),
                    Order = 1,
                    PlanEndDate = DateTime.Parse("2021-06-16"),
                    PlanStartDate = DateTime.Parse("2021-06-13"),
                    Status = 1,
                    Subject = "Анализ требований"
                },
                new Task
                {
                    CreationAuthor = users.FirstOrDefault(x => x.Id == 3),
                    CreationDate = DateTime.Parse("2021-06-05"),
                    Description = "",
                    EndDate = DateTime.Parse("2021-06-05"),
                    Executor = null, //users.FirstOrDefault(x => x.Id == 2),
                    Order = 1,
                    PlanEndDate = DateTime.Parse("2021-06-15"),
                    PlanStartDate = DateTime.Parse("2021-06-11"),
                    Status = 1,
                    Subject = "Разработка"
                },
                new Task
                {
                    CreationAuthor = users.FirstOrDefault(x => x.Id == 1),
                    CreationDate = DateTime.Parse("2021-06-05"),
                    Description = "",
                    EndDate = DateTime.Parse("2021-06-05"),
                    Executor = null, //users.FirstOrDefault(x => x.Id == 5),
                    Order = 1,
                    PlanEndDate = DateTime.Parse("2021-06-12"),
                    PlanStartDate = DateTime.Parse("2021-06-17"),
                    Status = 1,
                    Subject = "План"
                }
            };
            tasks.ForEach(t => context.Tasks.Add(t));
            context.SaveChanges();
        }
        
    }
}