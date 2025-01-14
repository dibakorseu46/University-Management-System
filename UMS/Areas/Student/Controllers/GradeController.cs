﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UMS.Data.IRepository;
using UMS.Models.ViewModels;

namespace UMS.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize(Roles="Student,Super Admin")]
    public class GradeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public GradeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [Route("Grade")]
        public  async Task< IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            GradeVM gradeVM = new GradeVM()
            {
                courseList = await _unitOfWork.StudentRegisteationCourse.GetAllCourses(userId),
                UserId = userId,
                CreditAttempted=await _unitOfWork.StudentRegisteationCourse.CreditAtempeted(userId),
                CreditCompletd=await _unitOfWork.StudentRegisteationCourse.CreditCompleted(userId),
                SemesterList=await _unitOfWork.StudentRegisteationCourse.GetSemesterList(userId) ,
                AttempedCGPA=await _unitOfWork.StudentRegisteationCourse.GetAttempedCGPA(userId),
                CompletedCGPA=await _unitOfWork.StudentRegisteationCourse.GetCompletedCGPA(userId)
            };
            var semsterList = await _unitOfWork.Semester.GetStudentRegisterSemester(userId);                
            foreach (var semester in semsterList)
            {
                var courseListBysemester = await _unitOfWork.StudentRegisteationCourse.GetCourseBySemester(userId, semester.Id);
                var semesterCredit = await _unitOfWork.StudentRegisteationCourse.GetSemesterCredits(userId, semester.Id);
                var semesterGPA = await _unitOfWork.StudentRegisteationCourse.GetSemesterGPA(userId, semester.Id);
                gradeVM.CourseCount.Add(courseListBysemester.Count());
                gradeVM.SemesterGPA.Add(semesterGPA);
                gradeVM.Credits.Add(semesterCredit);
            }
            return View(gradeVM);
        }
    }
}
