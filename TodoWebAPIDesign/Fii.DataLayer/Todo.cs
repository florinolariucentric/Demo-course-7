using System;

namespace Fii.DataLayer
{
    public class Todo
    {
        private Todo()
        {
            // EF
        }

        public Todo(string description, bool isCompleted)
        {

            Id = Guid.NewGuid();
            SetProperties(description, isCompleted);
        }

        public void Update(string description, bool isCompleted)
        {

            SetProperties(description, isCompleted);
        }


        public Guid Id { get; private set; }
        public string Description { get; private set; }

        public bool IsCompleted { get; private set; }

        private void SetProperties(string description, bool isCompleted)
        {
            Description = description;
            IsCompleted = isCompleted;
        }
    }
}
