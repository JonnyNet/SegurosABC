namespace SegurosABC.Repositories.Extensions
{
	public static class DataReaderExtension
	{
		public static IEnumerable<T> Select<T>(this IDataReader reader,
									   Func<IDataReader, T> projection)
		{
			while (reader.Read())
			{
				yield return projection(reader);
			}
		}

		public static T GetValue<T>(this IDataReader reader, string fieldName)
		{
			T value = default;
			var fieldValue = reader[fieldName];
			if (fieldValue is not DBNull)
			{
				value = (T)Convert.ChangeType(fieldValue, typeof(T));
			}
			return value;
		}
	}
}
