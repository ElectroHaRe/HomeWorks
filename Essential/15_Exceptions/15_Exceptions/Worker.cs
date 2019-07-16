namespace _15_Exceptions
{
    using System;

    struct Worker
    {
        public Worker(string name, string post, int employment_year)
        {
            Name = name;
            Post = post;
            EmploymentYear = employment_year;
            if (EmploymentYear < DateTime.Now.Year - 300 || EmploymentYear > DateTime.Now.Year)
                throw new Exception("Неверно указана дата регистрации струдника на должности");
        }

        public readonly string Name;
        public readonly string Post;
        public readonly int EmploymentYear;
    }
}
