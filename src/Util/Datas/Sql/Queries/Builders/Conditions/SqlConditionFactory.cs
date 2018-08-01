﻿using System;
using Util.Datas.Queries;

namespace Util.Datas.Sql.Queries.Builders.Conditions {
    /// <summary>
    /// Sql查询条件工厂
    /// </summary>
    public static class SqlConditionFactory {
        /// <summary>
        /// 创建Sql查询条件
        /// </summary>
        /// <param name="name">列名</param>
        /// <param name="parameter">参数</param>
        /// <param name="operator">操作符</param>
        public static ICondition Create( string name, string parameter, Operator @operator ) {
            switch( @operator ) {
                case Operator.Equal:
                    return new EqualCondition( name, parameter );
                case Operator.NotEqual:
                    return new NotEqualCondition( name, parameter );
                case Operator.Greater:
                    return new GreaterCondition( name, parameter );
                case Operator.Less:
                    return new LessCondition( name, parameter );
                case Operator.GreaterEqual:
                    return new GreaterEqualCondition( name, parameter );
                case Operator.LessEqual:
                    return new LessEqualCondition( name, parameter );
                case Operator.Contains:
                    return new LikeCondition( name, parameter );
                case Operator.Starts:
                    return new LikeCondition( name, parameter );
                case Operator.Ends:
                    return new LikeCondition( name, parameter );
            }
            throw new NotImplementedException( $"运算符 {@operator.Description()} 未实现" );
        }
    }
}