﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.Data.Data;

namespace UMS.Data.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        public IDepartmentRepository Department { get;}
        public ICourseTypeRepository CourseType { get; }
        public ICourseProtoTypeRepository CourseProtoType { get; }
        public ICourseRepository Course { get;  }
        public ICoursePrerequisiteRepository CoursePrerequisite { get; }
        public ICourseToCoursePrerequisiteRepository CourseToCoursePrerequisite { get; }
        public ISemesterRepository Semester { get; }
        public IClassTimeRepository ClassTime{ get; }
        public IDayRepository Day { get; }
        public ISectionRepository Section { get; }
        public IActivityRepository Activity { get; }
        public IApplicationUserRepository ApplicationUser { get; }
        public IUserDetialsRepository UserDetials { get; }
        public IUserRepository User { get; }
        public IClaimRepository Claims { get; }
        public IPreRegistrationCourseRepository PreRegistationCourses { get;  }
        public IPreregiCoursesRepository PreregiCourses { get; }
        public IAssignRegistrationCourseRepository AssignRegistrationCourse { get; }
        public IRegistrationCourseRepository RegistrationCourse { get; }
        public ICourseContentRepository CourseContent { get; }
        public IAdminDashboardRepository AdminDashboard { get; }
        public ITeacherCourseRepository TeacherCourse { get; }
        public IStudentRegisteationCourseRepository StudentRegisteationCourse { get;  }
        public IStudentSemeterFeeRepository StudentSemeterFee { get; }
        public IEmployeeDetialsRepository EmployeeDetials { get; }
        Task SaveAsync();
    }
}
