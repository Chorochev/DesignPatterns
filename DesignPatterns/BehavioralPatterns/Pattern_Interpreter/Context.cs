using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns.Pattern_Interpreter
{
    /// <summary>
    /// Context: содержит общую для интерпретатора информацию. Может использоваться 
    /// объектами терминальных и нетерминальных выражений для сохранения состояния 
    /// операций и последующего доступа к сохраненному состоянию.
    /// </summary>
    class Context
    {
        Dictionary<string, int> variables;
        public Context()
        {
            variables = new Dictionary<string, int>();
        }
        // получаем значение переменной по ее имени
        public int GetVariable(string name)
        {
            return variables[name];
        }

        public void SetVariable(string name, int value)
        {
            if (variables.ContainsKey(name)) variables[name] = value;
            else variables.Add(name, value);
        }
    }
}
