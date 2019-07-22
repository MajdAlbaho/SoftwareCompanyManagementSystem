using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareCompanyManagementSystem.Model
{
    public class ProjectModel
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public int ProgrammingLanguageId { get; set; }
        public int ProjectTypeId { get; set; }
        public string CustomerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DeliverDate { get; set; }

        public string ProjectTypeName { get; set; }
        public string ProjectLanguageName { get; set; }
    }
}
