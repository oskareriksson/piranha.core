﻿/*
 * Copyright (c) 2016-2017 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * https://github.com/piranhacms/piranha.core
 * 
 */

namespace Piranha.Extend.Fields
{
    [Field(Name = "String", Shorthand = "String")]
    public class StringField : SimpleField<string>
    {
        public static implicit operator StringField(string str) {
            return new StringField() { Value = str };
        }
    }
}
