using Pictorial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial.Entities.Concrete
{
    public class Word : IEntity
    {
        #region Private Properties
        private int id;
        private int courseId;
        private string mainWord;
        private string meanOfWord;
        private DateTime insertDate;
        private DateTime updateDate;
        #endregion

        #region Public Properties
        public int Id
        {
            get { return id; }
            set 
            { 
                id = value; 
            }
        }
        public int CourseId
        {
            get { return courseId; }
            set 
            { 
                courseId = value; 
            }
        }
        public string MainWord
        {
            get { return mainWord; }
            set 
            { 
                mainWord = value; 
            }
        }
        public string MeanOfWord
        {
            get { return meanOfWord; }
            set
            {
                meanOfWord = value;
            }

        }
        public DateTime InsertDate
        {
            get { return insertDate; }
            set
            {
                insertDate = value;
            }
        }
        public DateTime UpdateDate
        {
            get { return updateDate; }
            set
            {
                updateDate = value;
            }
        }
        #endregion
    }
}
