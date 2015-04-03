namespace _1.DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using DocumentSystem.TypeDocument;
    using DocumentSystem.TypeDocument.BinaryTypeDoc;
    /// <summary>
    /// 
    /// http://bgcoder.com/Contests/65/OOP-2013-Sample-Exam for Example
    /// 
    /// </summary>
    public class MainProgram
    {
        private static ICollection<IDocument> documents = new List<IDocument>();
        static void Main()
        {
            IList<string> allCommands = ReadAllCommands();
            ExecuteCommands(allCommands);
        }

        private static IList<string> ReadAllCommands()
        {
            List<string> commands = new List<string>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "")
                {
                    // End of commands
                    break;
                }
                commands.Add(commandLine);
            }
            return commands;
        }

        private static void ExecuteCommands(IList<string> commands)
        {
            foreach (var commandLine in commands)
            {
                int paramsStartIndex = commandLine.IndexOf("[");
                string cmd = commandLine.Substring(0, paramsStartIndex);
                int paramsEndIndex = commandLine.IndexOf("]");
                string parameters = commandLine.Substring(
                    paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
                ExecuteCommand(cmd, parameters);
            }
        }

        private static void ExecuteCommand(string cmd, string parameters)
        {
            string[] cmdAttributes = parameters.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmd == "AddTextDocument")
            {
                AddTextDocument(cmdAttributes);
            }
            else if (cmd == "AddPDFDocument")
            {
                AddPdfDocument(cmdAttributes);
            }
            else if (cmd == "AddWordDocument")
            {
                AddWordDocument(cmdAttributes);
            }
            else if (cmd == "AddExcelDocument")
            {
                AddExcelDocument(cmdAttributes);
            }
            else if (cmd == "AddAudioDocument")
            {
                AddAudioDocument(cmdAttributes);
            }
            else if (cmd == "AddVideoDocument")
            {
                AddVideoDocument(cmdAttributes);
            }
            else if (cmd == "ListDocuments")
            {
                ListDocuments();
            }
            else if (cmd == "EncryptDocument")
            {
                EncryptDocument(parameters);
            }
            else if (cmd == "DecryptDocument")
            {
                DecryptDocument(parameters);
            }
            else if (cmd == "EncryptAllDocuments")
            {
                EncryptAllDocuments();
            }
            else if (cmd == "ChangeContent")
            {
                ChangeContent(cmdAttributes[0], cmdAttributes[1]);
            }
            else
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }
        }

        private static void AddTextDocument(string[] attributes)
        {
            IDocument doc = new TextDocument("");
            AddDocument(attributes, doc);
        }

        private static void AddPdfDocument(string[] attributes)
        {
            IDocument doc = new PDF("");
            AddDocument(attributes, doc);
        }

        private static void AddWordDocument(string[] attributes)
        {
            IDocument doc = new Word("");
            AddDocument(attributes, doc);
        }

        private static void AddExcelDocument(string[] attributes)
        {
            IDocument doc = new Excel("");
            AddDocument(attributes, doc);
        }

        private static void AddAudioDocument(string[] attributes)
        {
            IDocument doc = new Audio("");
            AddDocument(attributes, doc);
        }

        private static void AddVideoDocument(string[] attributes)
        {
            IDocument doc = new Video("");
            AddDocument(attributes, doc);
        }

        private static void ListDocuments()
        {
            // TODO
        }

        private static void EncryptDocument(string name)
        {
            var encrDoc = documents.Where(d => d.Name == name && d is IEncryptable);

            if (encrDoc.Any())
            {
                foreach (IDocument doc in encrDoc)
                {
                    var encDoc = doc as IEncryptable;
                    if (encDoc != null)
                    {
                        encDoc.Encrypt();
                        Console.WriteLine("Document encrypted: {0}", name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support encryption: {0}", name);
                    }
                }
            }
            else
            {
                Console.WriteLine("Document not found: {0}", name);
            }
        }

        private static void DecryptDocument(string name)
        {
            var encrDoc = documents.Where(d => d.Name == name && d is IEncryptable);

            if (encrDoc.Any())
            {
                foreach (IDocument doc in encrDoc)
                {
                    var encDoc = doc as IEncryptable;
                    if (encDoc != null)
                    {
                        encDoc.Decrypt();
                        Console.WriteLine("Document decrypted: {0}", name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support decryption: {0}", name);
                    }
                }
            }
            else
            {
                Console.WriteLine("Document not found: {0}", name);
            }
        }

        private static void EncryptAllDocuments()
        {
            var encrDocs = documents.Where(d => d is IEncryptable);

            if (encrDocs.Any())
            {
                foreach (IEncryptable doc in encrDocs)
                {
                    doc.Encrypt();
                }

                Console.WriteLine("All documents encrypted");
            }
            else
            {
                Console.WriteLine("No encryptable documents found");
            }
        }

        private static void ChangeContent(string name, string content)
        {
            // TODO
        }

        private static void AddDocument(string[] attributes, IDocument doc)
        {
            foreach (string att in attributes)
            {
                string[] keyValue = att.Split('=');
                doc.LoadProperty(keyValue[0], keyValue[1]);
            }

            if (string.IsNullOrEmpty(doc.Name))
            {
                Console.WriteLine("Document has no name");
            }
            else
            {
                documents.Add(doc);
                Console.WriteLine("Document added: {0}", doc.Name);
            }
        }
    }
}
