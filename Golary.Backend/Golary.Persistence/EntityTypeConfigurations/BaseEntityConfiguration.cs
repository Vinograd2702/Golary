using Golary.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Golary.Persistence.EntityTypeConfigurations
{
    // Конфигурация сущностей
    // Отделение от контекста конфигурации
    // Определение конфигурации единыx полей для всех сущностей базы данных
    internal class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(entity => entity.Id);  // Присваивание полю Id значения ключа PrimaryKey, основной ключ
            builder.HasIndex(entity => entity.Id).IsUnique();   // Индекс сущности уникален
        }
    }
}
