using System;

namespace UnitOfWork
{
    public interface IEntity<TPk> where TPk : IComparable
    {
        TPk Id { get; set; }
    }
}
