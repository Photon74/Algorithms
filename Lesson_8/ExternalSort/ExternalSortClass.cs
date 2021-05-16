using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExternalSorter
{
    public class ExternalSort
    {
        public static int FlushSize => 256;
        public static List<string> TempFiles { get; private set; }

        public static void IntArrayFile(string filePath)
        {
            TempFiles = new List<string>();
            // разбиение большого файла на малые сортированные файлы
            try
            {
                using (var streamReader = new FileStream(filePath, FileMode.Open))
                using (var reader = new BinaryReader(streamReader))
                {
                    var count = 0;
                    while (streamReader.Position < streamReader.Length)
                    {
                        var tempArr = new int[(int)FileSize.KByte];
                        for (var i = 0; i < tempArr.Length; i++)
                        {
                            tempArr[i] = reader.ReadInt32();
                        }
                        Array.Sort(tempArr);

                        var tempFileName = Path.GetFileNameWithoutExtension(filePath) + count.ToString() + Path.GetExtension(filePath);
                        TempFiles.Add(tempFileName);

                        using (var streamWriter = new FileStream(tempFileName, FileMode.Create))
                        using (var writer = new BinaryWriter(streamWriter))
                        {
                            for (var i = 0; i < tempArr.Length; i++)
                            {
                                writer.Write(tempArr[i]);
                                if (i % FlushSize == 0) writer.Flush();
                            }
                        }
                        count++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            File.Delete(filePath);  // удаление исходного файла

            // собирание временных файлов в один(имя совпадает с исходным)
            try
            {
                using (var streamWriter = new FileStream(filePath, FileMode.Create))
                using (var writer = new BinaryWriter(streamWriter))
                {
                    var length = TempFiles.Count;
                    var streamReader = new FileStream[length];
                    var reader = new BinaryReader[length];
                    var tempIntArr = new int[length];

                    for (var i = 0; i < length; i++)
                    {
                        streamReader[i] = new FileStream(TempFiles[i], FileMode.Open);
                        reader[i] = new BinaryReader(streamReader[i]);
                        tempIntArr[i] = reader[i].ReadInt32();
                    }

                    var count = 0;
                    bool next;
                    do
                    {
                        next = false;
                        var minInt = tempIntArr[1];

                        for (var i = 0; i < length; i++)
                        {
                            if (streamReader[i].Position < streamReader[i].Length) next = true;
                        }

                        for (var i = 0; i < length; i++)
                        {
                            if (tempIntArr[i] < minInt)
                            {
                                minInt = tempIntArr[i];
                            }
                        }

                        writer.Write(minInt);
                        if (count % FlushSize == 0) writer.Flush();

                        var index = Array.IndexOf(tempIntArr, minInt);

                        if (streamReader[index].Position < streamReader[index].Length)
                        {
                            tempIntArr[index] = reader[index].ReadInt32();
                        }
                        else
                        {
                            tempIntArr[index] = int.MaxValue;
                        }
                        count++;
                    } while (next);

                    for (var i = 0; i < length; i++)
                    {
                        reader[i].Close(); // закрытие потоков
                        File.Delete(TempFiles[i]);  // удаление временных файлов
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
