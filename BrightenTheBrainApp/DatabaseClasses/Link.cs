using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Example2
{
    public class Link
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; } //Primary key, and unique identifier of entries
        public string link { get; set; } //PDF's URL link. 
        public string PDFName { get; set; } //PDFName for display in the filing cabinet. 
        public int AmountAccessed { get; set; } //count of times a person has accessed a PDF, used for favorites bar
    }
}
