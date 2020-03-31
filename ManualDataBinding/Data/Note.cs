using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {
        /// <summary>
        /// An event handler triggered when this note changes
        /// </summary>
        public event EventHandler NoteChanged;

        private string title = DateTime.Now.ToString();

        /// <summary>
        /// The title of the Note
        /// </summary>
        public string Title {
            get { return title; }
            set 
            {
                if (value == title) return;
                title = value;
                NoteChanged?.Invoke(this, new EventArgs());
            } 
        }

        private string body = "";
        /// <summary>
        /// The text of the note
        /// </summary>
        public string Body
        {
            get { return body; }
            set
            {
                if (value == body) return;
                body = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }
    }
}
