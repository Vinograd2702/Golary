using System;

namespace Golary.Application.Common.Exceptions
{
    // Исключение - не найден объект в БД
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key) 
            : base($"Entity \"{name}\" ({key}) not found.") { }
    }
}
