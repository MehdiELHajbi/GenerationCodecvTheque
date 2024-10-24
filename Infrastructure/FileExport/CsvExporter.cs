using Application.Contracts.Infrastructure;
using CsvHelper;
using Domain;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Infrastructure
{
    public class CsvExporter : ICsvExporter
    {


        public byte[] ExportDataBaseToCsv<T>(List<T> records)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

                //csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
                csvWriter.WriteRecords(records);
            }

            return memoryStream.ToArray();
        }
    }

}
