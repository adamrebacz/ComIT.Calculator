using System;
namespace TruthTable
{
    public class LogicGateTwo : ILogicGate
    {
        public bool _1 { get; set; }
        public bool _2 { get; set; }
        public bool _3 { get; set; }
        public bool _4 { get; set; }

        public LogicGateTwo(bool _1, bool _2, bool _3, bool _4)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
            this._4 = _4;
        }

        public string PrintOut()
        {
            return string.Format("value1: {0} value2: {1} value3: {2} value4: {3} resault: {4}",
                BoolConverter(this._1),
                BoolConverter(this._2),
                BoolConverter(this._3),
                BoolConverter(this._4),
                BoolConverter(((_1 || _2) ||  (_3 && _4))));
        }

        public int BoolConverter(bool value)
        {
            if (value)
                return 1;
            return 0;
        }
    }
}
