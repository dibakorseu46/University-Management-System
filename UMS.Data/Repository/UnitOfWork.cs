﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.Data.Data;
using UMS.Data.IRepository;

namespace UMS.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Department = new DepartmentRepository(db);
            CourseType = new CourseTypeRepository(db);
            CourseProtoType = new CourseProtoTypeRepository(db);
            Course = new CourseRepository(db);
            CoursePrerequisite = new CoursePrerequisiteRepository(db);
            CourseToCoursePrerequisite = new CourseToCoursePrerequisiteRepository(db);
        }
        public IDepartmentRepository Department { get; private set; }

        public ICourseTypeRepository CourseType { get; private set; }

        public ICourseProtoTypeRepository CourseProtoType { get; private set; }
        public ICourseRepository Course { get; private set; }

        public ICoursePrerequisiteRepository CoursePrerequisite { get; private set; }

        public ICourseToCoursePrerequisiteRepository CourseToCoursePrerequisite { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}