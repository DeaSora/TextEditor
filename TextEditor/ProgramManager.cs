using System;

namespace TextEditor
{
    internal class ProgramManager
    {
        public void Execute()
        {
            {
                var editor = new TextEditor();
                editor.Editor();
            }
        }
    }
}
