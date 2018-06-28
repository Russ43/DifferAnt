using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DifferAnt.Models;

namespace DifferAnt.Parsers
{
    internal class GitParser : IParser
    {
        #region IParser methods
        public ChangeList ParseChangeList(Stream stream)
        {
            ChangeList changeList = new ChangeList();
            using (StreamReader reader = new StreamReader(stream))
            {
                string line = reader.ReadLine();
                while(line != null)
                {
                    line = line.Trim();
                    if(!(line.Length == 0))
                    {
                        IList<string> parts = line.Split(' ', '\t');
                        if (parts.Count < 2)
                            throw new Exception("Line must have at least two parts.");
                        string path1 = parts[1];
                        string modificationCode = parts[0];
                        switch(modificationCode)
                        {
                            case "M": changeList.Add(new Change() { Kind = ChangeKind.Edit, Path = parts[1] }); break;
                            case "A": changeList.Add(new Change() { Kind = ChangeKind.Add, Path = parts[1] }); break;
                            case "D": changeList.Add(new Change() { Kind = ChangeKind.Remove, Path = parts[1] }); break;
                            default: throw new Exception($"Unrecognized modification code '{modificationCode}'.");
                        }
                    }
                }
            }

            return changeList;
        } 
        #endregion
    }
}
