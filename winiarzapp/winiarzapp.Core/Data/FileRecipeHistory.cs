using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Winiarzapp.Core.Data
{
    [Serializable]
    public class FileRecipeHistory : IRecipeHistory
    {
        private const string FILE_PATH = @"C:\temp\History_Of_Batches.xml";
      
        
        /// <summary>
        /// Lista przechowująca listę zapisanych nastawów. 
        /// </summary>
        private List<Batch> History; 
        

      
        public IEnumerable<Batch> Batches
        {
           get
            {
                return History;
            }

            set
            {
                if (value != null)
                    History = (List<Batch>)value;
                else History = null;  
            
            }              
        }
        
      
        public FileRecipeHistory()
        {
           if(File.Exists(FILE_PATH)) History = DeserializeList<Batch>();
           else  History = new List<Batch>();

        }
        /// <summary>
        /// Dodaj nastaw do historii.
        /// </summary>
        public void AddBatch(Batch batch)
        {
           if (History == null) History = new List<Batch>() { batch };
            else
            {
                History.Add(batch);
            }
        }
        /// <summary>
        /// Serializuje listę do pliku xml, a następnie usuwa jej referencje z pamięci.
        /// </summary>
        public void Dispose()
        {
            SerializeList<Batch>(History); 
            History = null;

        }
        /// <summary>
        /// Usuń nastaw z historii.
        /// </summary>
        public void RemoveBatch(Batch batch)
        {
           if(History!= null && batch!=null)
           {
              History.RemoveAll(b => b.Equals(batch));
           }
        }
        
        /// <summary>
        /// Metoda pomocnicza do odczytu zapisanej historii nastawów z pliku xml. 
        /// </summary>
        

         private List<T> DeserializeList<T>()
        {
            
            var xml = File.ReadAllText(FILE_PATH);
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

            using (var reader = new StringReader(xml))
            {
               return (List<T>)serializer.Deserialize(reader);          
                
            }
        }
        /// <summary>
        /// 
        /// Metoda pomocnicza do serializacji listy obiektów. 
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        private void SerializeList<T>(List<T> list)
        {
            if (list != null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                using (FileStream stream = new FileStream(FILE_PATH, FileMode.Create))
                {
                    serializer.Serialize(stream, list);
                }
            }
        }
    }
}
