using System;

static void Program(string[] journal)
{
    Journal myJournal = new Journal();
    myJournal.Write();
    myJournal.ExportToCSV();
}