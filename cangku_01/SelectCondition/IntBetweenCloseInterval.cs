﻿namespace DbLink2
{
    public class IntBetweenCloseInterval : SelectCondition
    {
        private readonly int? _max;
        private readonly int? _min;

        public IntBetweenCloseInterval(string fieldName, int max, int min) : base(fieldName)
        {
            _max = max;
            _min = min;
        }

        public IntBetweenCloseInterval(string fieldName, string maxStringNullable, string minStringNullable) :base(fieldName)
        {
            if (!string.IsNullOrEmpty(maxStringNullable))
                _max = int.Parse(maxStringNullable);
            if (!string.IsNullOrEmpty(minStringNullable))
                _min = int.Parse(minStringNullable);
        }

        public override string MakeClause() =>IsValidCondition() ? $"{FieldName}>={_min} and {FieldName}<={_max}" : "";
        public override bool IsValidCondition() => _max != null && _min != null;
    }
}