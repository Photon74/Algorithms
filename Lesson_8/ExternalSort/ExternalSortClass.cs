using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExternalSorter
{
    public class ExternalSort
    {
        public static List<string> TempFiles { get; private set; }

        public static void IntArrayFile(string filePath)
        {
            TempFiles = new List<string>();
            // разбиение большого файла на малые сортированные файлы
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    int count = 0;
                    while (reader.PeekChar() >= -1)
                    {
                        int[] tempArr = new int[(int)FileSize.MByte];
                        for (int i = 0; i < tempArr.Length - 1; i++)
                        {
                            tempArr[i] = reader.ReadInt32();
                        }
                        Array.Sort(tempArr);

                        string tempFileName = Path.GetFileNameWithoutExtension(filePath) + count.ToString() + Path.GetExtension(filePath);
                        TempFiles.Add(tempFileName);

                        using (BinaryWriter writer = new BinaryWriter(File.Open(tempFileName, FileMode.OpenOrCreate)))
                        {
                            for (int i = 0; i < tempArr.Length; i++)
                            {
                                writer.Write(tempArr[i]);
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

            File.Delete(filePath);

            // собирание файлов в кучу
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate)))
                {
                    int minInt = int.MaxValue;
                    int length = TempFiles.Count;
                    BinaryReader[] binaryReaders = new BinaryReader[length];
                    int[] tempIntArr = new int[length];

                    for (int i = 0; i < length; i++)
                    {
                        binaryReaders[i] = new BinaryReader(File.Open(TempFiles[i], FileMode.Open));
                        binaryReaders[i].ReadInt32();
                    }
                    for (int i = 0; i < length; i++)
                    {
                        tempIntArr[i] = binaryReaders[i].ReadInt32();
                    }

                    bool next;
                    do
                    {
                        next = false;

                        for (int i = 0; i < length; i++)
                        {
                            if (tempIntArr[i] < minInt)
                            {
                                minInt = tempIntArr[i];
                            }
                        }

                        int index = Array.IndexOf(tempIntArr, minInt);

                        if (binaryReaders[index].PeekChar() > -1)
                        {
                            tempIntArr[index] = binaryReaders[index].ReadInt32();
                        }
                        else
                        {
                            tempIntArr[index] = int.MaxValue;
                        }

                        for (int i = 0; i < length; i++)
                        {
                            if (binaryReaders[i].PeekChar() > -1) next = true;
                        }

                    } while (next);

                    for (int i = 0; i < length; i++)
                    {
                        binaryReaders[i].Close();
                        File.Delete(TempFiles[i]);
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
