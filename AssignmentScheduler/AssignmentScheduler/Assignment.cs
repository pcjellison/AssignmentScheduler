using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentScheduler
{
    class Assignment
    {
        //Global Fields
        private string _className;
        private string _assignmentName;
        private DateTime _dueDate;
        private string _description;
        private IList<Assignment> assignmentList = new List<Assignment>();

        public Assignment(string cn, string at, DateTime dd, int an, string desc)
        {
            _className = cn;
            _assignmentName = at + an;
            _dueDate = dd;
            _description = desc;
            assignmentList.Add(this);
        }
        

        //Getters/Setters for Assignment fields
        public string ClassName
        {
            get
            {
                return _className;
            }
            set
            {
                _className = value;
            }
        }
        
        protected string AssignmentName
        {
            get
            {
                return _assignmentName;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return _dueDate;
            }
            set
            {
                _dueDate = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        
        //Methods

        /// <summary>
        /// Searches every assignment to find match and deletes it from the list
        /// </summary>
        /// <param name="an">name of assignment to search for</param>
        /// <param name="cn">name of associated class</param>
        public void DeleteAssignment(string an, string cn)
        {
            foreach(Assignment assign in assignmentList)
            {
                if(assign.AssignmentName == an && assign.ClassName == cn)
                {
                    assignmentList.Remove(assign);
                }
            }
        }
    }
}
