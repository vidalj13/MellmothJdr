using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Microsoft.EntityFrameworkCore
{
    internal static class ModelBuilderExtensions
    {
        /// <summary>
        /// Saves all the enums as strings in the DB.
        /// </summary>
        public static void SaveEnumAsString(this ModelBuilder modelBuilder)
        {
            modelBuilder.Model
                .GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType.BaseType == typeof(Enum))
                .ToList()
                .ForEach(p =>
                {
                    Type type = typeof(EnumToStringConverter<>).MakeGenericType(p.ClrType);
                    ValueConverter converter = Activator.CreateInstance(type, new ConverterMappingHints()) as ValueConverter;

                    p.SetValueConverter(converter);
                });
        }
    }
}
