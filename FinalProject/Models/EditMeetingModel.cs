﻿using FluentValidation;

namespace FinalProject.Models
{
    public class EditMeetingModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }

    public class EditMeetingModelValidator : AbstractValidator<EditMeetingModel>
    {
        public EditMeetingModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(30).MinimumLength(2);
            RuleFor(x => x.StartDate).NotEmpty().Must(DateIsValid).WithMessage("Date must be either 15, or 30, or 45, or 00 minutes");
            RuleFor(x => x.EndDate).NotEmpty().Must(DateIsValid).WithMessage("Date must be either 15, or 30, or 45, or 00 minutes");

            RuleFor(m => new { m.StartDate, m.EndDate }).Must(x => x.StartDate.HasValue && x.EndDate.HasValue
                ? x.StartDate.Value.AddMinutes(30) <= x.EndDate.Value && x.StartDate.Value.AddHours(24) >= x.EndDate.Value
                : true)
            .WithMessage("Start date must be smaller than End date with duration between as 30mins or more");
        }

        private bool DateIsValid(DateTime? date)
        {
            if (!date.HasValue)
            {
                return false;
            }

            if (date.Value.Second != 0 || date.Value.Millisecond != 0)
            {
                return false;
            }

            var minute = date.Value.Minute;
            if (minute != 0 && minute != 15 && minute != 30 && minute != 45)
            {
                return false;
            }

            return true;
        }
    }
}
