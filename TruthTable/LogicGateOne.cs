using System;
namespace TruthTable
{
    public class LogicGateOne : ILogicGate
    {
        public bool _1 { get; set; }
        public bool _2 { get; set; }
        public bool _3 { get; set; }

        public LogicGateOne(bool _1, bool _2, bool _3)
        {
            this._1 = _1;
            this._2 = _2;
            this._3 = _3;
        }

        public string PrintOut()
        {
            return string.Format( "value1: {0} value2: {1} value3: {2} resault: {3}",
                BoolConverter(this._1),
                BoolConverter(this._2),
                BoolConverter(this._3),
                BoolConverter(((_1 || _2) && _3)));
        }

        public int BoolConverter(bool value)
        {
            if (value)
                return 1;
            return 0;
        }
    }
}
