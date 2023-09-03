using FluentValidation;
using FinalProject;
using Models;
using System.ComponentModel.DataAnnotations;


namespace FinalProject.Models
    
{
    

    public class CreateRecurrentMeetingModelValidator : AbstractValidator<CreateRecurrentMeetingModel>
    {
        

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
