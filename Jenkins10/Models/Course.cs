using System.ComponentModel.DataAnnotations.Schema;
using Jenkins10.Models;
using System.Collections.Generic;

namespace Jenkins10.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public string Description { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

