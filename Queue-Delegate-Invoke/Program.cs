using Queue_Delegate_Invoke.Entities;
using Queue_Delegate_Invoke.Utilities.Business;
using Queue_Delegate_Invoke.Utilities.Constants;
using Queue_Delegate_Invoke.Utilities.Invoke;
using Queue_Delegate_Invoke.Utilities.Response;

namespace Queue_Delegate_Invoke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new People()
            {
                Id = 1,
                FirstName = "Nijat",
                LastName = "",
                Age = 25
            };

            var validationIssue = new BusinessRules().Run(CheckIfNameIsValid(people.FirstName, Messages.FirstNameMustNotBeEmpty),
                                                          CheckIfNameIsValid(people.LastName, Messages.LastNameMustNotBeEmpty),
                                                          CheckIfAgeIsLargerThanOrEqualsTo18(people.Age));

            if (validationIssue != null)
            {
                Console.WriteLine($"An error has occured: {validationIssue.Message}");
                return;
            }



        }

        static Invoke<Func<IResult>> CheckIfAgeIsLargerThanOrEqualsTo18(int age) => new(() => age >= 18 ? new SuccessResult() : new ErrorResult(Messages.AgeMustBeLargerThanOrEqualsTo18));

        static Invoke<Func<IResult>> CheckIfNameIsValid(string name, string message) => new(() => !string.IsNullOrEmpty(name) ? new SuccessResult() : new ErrorResult(message));
    }
}