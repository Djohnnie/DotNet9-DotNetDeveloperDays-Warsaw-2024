using System.Formats.Tar;
using System.IO.Compression;



var file = @"C:\TAR\archive.tar";


if (File.Exists(file))
{
    File.Delete(file);
}


if (File.Exists($"{file}.gz"))
{
    File.Delete($"{file}.gz");
}


TarFile.CreateFromDirectory(@"C:\TAR_TEST", @"C:\TAR\archive.tar", false);


var destination = @$"C:\TAR\{Guid.NewGuid()}";
Directory.CreateDirectory(destination);
TarFile.ExtractToDirectory(@"C:\TAR\archive.tar", destination, true);



using var memoryStream = new MemoryStream();
TarFile.CreateFromDirectory(@"C:\TAR_TEST", memoryStream, false);
using var gZippedFileStream = File.Create($"{file}.gz");
using var gZipStream = new GZipStream(gZippedFileStream, CompressionMode.Compress);
memoryStream.Seek(0, SeekOrigin.Begin);
memoryStream.CopyTo(gZipStream);



using var fileStream = File.OpenRead(file);
using var reader = new TarReader(fileStream, leaveOpen: true);

TarEntry entry;

do
{
    entry = reader.GetNextEntry();

    if (entry != null)
    {
        Console.WriteLine($"{entry.EntryType}: {entry.Name} (offset {entry.DataOffset} bytes, length {entry.Length} bytes)");
    }

} while (entry != null);