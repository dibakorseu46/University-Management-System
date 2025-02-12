﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.Models.Models;

namespace UMS.Data.IRepository
{
    public interface IStudentRegisteationCourseRepository:IRepository<StudentRegisteationCourse>
    {
        Task UpdateAsync(StudentRegisteationCourse studentRegisteationCourse);
        Task<IEnumerable<StudentRegisteationCourse>> GetAllCourses(string userId);
        Task<int> CreditCompleted(string userId);
        Task<StudentRegisteationCourse> GetCourseGrade(string userId, Guid courseId);
        Task<IEnumerable<Guid>> GetCompleteCourseId(string userId);
        Task<Guid> GetSemester(Guid courseId);
        Task<int> CreditAtempeted(string userId);
        Task<IEnumerable<StudentRegisteationCourse>> GetCourseBySemester(string userId, Guid semesterId);
        Task<int> GetSemesterCredits(string userId, Guid semesterId);
        Task<IEnumerable<string>> GetSemesterList(string userId);
        Task<bool> GetPrerequisiteCourseChecker(string userId, Guid courseId);
        Task<double> GetCompletedCGPA(string userId);
        Task<double> GetAttempedCGPA(string userId);
        Task<double> GetSemesterGPA(string userId, Guid semesterId);
        Task<IEnumerable<StudentRegisteationCourse>> GetRegisterCourseBySemester(string userId, Guid semesterId);
    }
}
