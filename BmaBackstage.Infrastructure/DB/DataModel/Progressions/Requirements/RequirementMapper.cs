using BmaBackstage.Infrastructure.DB.DataModel.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DomainRequirements = BmaBackstage.Domain.Entities.Progressions.Requirements;

namespace BmaBackstage.Infrastructure.DB.DataModel.Progressions.Requirements
{
    internal static class RequirementMapper
    {
        public static Requirement FromEntity(DomainRequirements.AbstractRequirement requirement)
        {
            if (requirement == null)
            {
                throw new ArgumentNullException("RequirementMapper.FromEntity cannot map a null Domain object to a DB object.");
            }
            var ageRequirement = requirement as DomainRequirements.AgeRequirement;
            if (ageRequirement != null)
            {
                return new AgeRequirement
                {
                    Id = ageRequirement.Id,
                    Name = ageRequirement.Name,
                    Person = Person.FromEntity(ageRequirement.Person),
                    RequiredAge = ageRequirement.RequiredAge,
                };
            }
            var attendanceRequirement = requirement as DomainRequirements.AttendanceRequirement;
            if (attendanceRequirement != null)
            {
                throw new NotImplementedException("Unable to convert Domain Lesson class to DB type");
                // TODO: Need to be able to convert lessons
                // return new AttendanceRequirement
                // {
                //     Id = attendanceRequirement.Id,
                //     Lessons = new List<Lesson> { } // attendanceRequirement.Lessons
                // };
            }
            var manualApprovalRequirement = requirement as DomainRequirements.ManualApprovalRequirement;
            if (manualApprovalRequirement != null)
            {
                return new ManualApprovalRequirement
                {
                    Id = manualApprovalRequirement.Id,
                    Passed = manualApprovalRequirement.Passed,
                    Name = manualApprovalRequirement.Name
                };
            }
            throw new ArgumentException($"RequirementMapper.FromEntity unsupported mapping to database type from {requirement.GetType().FullName}");
        }

        public static DomainRequirements.AbstractRequirement ToEntity(Requirement requirement)
        {
            if (requirement == null)
            {
                throw new ArgumentNullException("RequirementMapper.FromEntity cannot map a null Domain object to a Entity.");
            }
            var AgeRequirement = requirement as AgeRequirement;
            if (AgeRequirement != null)
            {
                throw new NotImplementedException("RequirementMapper.ToEntity unsupported mapping to entity type from AgeRequirement because Person mapping is incomplete");
                //return new DomainRequirements.AgeRequirement
                //{
                //    Id = AgeRequirement.Id,
                //    Name = AgeRequirement.Name,
                //    Person = Person.
                //}
            }
            var manualApprovalRequirement = requirement as ManualApprovalRequirement;
            if (manualApprovalRequirement != null)
            {
                return new DomainRequirements.ManualApprovalRequirement
                (
                    name: manualApprovalRequirement.Name,
                    passed: manualApprovalRequirement.Passed,
                    id: manualApprovalRequirement.Id
                );
            }

            throw new ArgumentException($"RequirementMapper.ToEntity unsupported mapping to entity type from {requirement.GetType().FullName}");
        }
    }
}
