using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu Projeto ASPNET Core 1", "Minha Descrição de Projeto",1,1,10000),
                new Project("Meu Projeto ASPNET Core 2", "Minha Descrição de Projeto",1,1,20000),
                new Project("Meu Projeto ASPNET Core 3", "Minha Descrição de Projeto",1,1,30000)
            };

            Users = new List<User>
            {
                new User("Wladimir", "wladimir@mail.com",new DateTime(1992,1,1)),
                new User("Fabiana", "fabiana@mail.com",new DateTime(1999,1,1)),
                new User("Maria", "maria@mail.com",new DateTime(1990,1,1))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
